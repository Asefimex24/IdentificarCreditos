using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;
using Identifica.Logica;



namespace Identifica.Presentacion
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        string AnalitoCarteraPath = ""; 
        string edoCtaTelecomPath = "";        

        DataTable TableCtaTelecomm;
        DataTable TableAnalitico;
        DataTable TableNoidentificado;

        private void FrmHome_Load(object sender, EventArgs e)
        {
            InicializarDatatableNoIdentificados();
            iniciaTblTelecom();
            iniciaTblCartera();            
        }

        private void InicializarDatatableNoIdentificados() {
            LNoIdentificados nd = new LNoIdentificados();
            this.TableNoidentificado = nd.iniciaNoIdentificados();      
        }

        private void iniciaTblTelecom() {
            LCtaTelecom tel = new LCtaTelecom();
            this.TableCtaTelecomm = tel.iniciaTabletelecom();
        }

        private void iniciaTblCartera() {
            LRepCartera crt = new LRepCartera();
            this.TableAnalitico = crt.iniciaTableCartera();
        }

        private OpenFileDialog cargar_archivos()
        {
            // Crear una instancia del OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Configurar propiedades (opcional)
            openFileDialog.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Seleccionar archivo";
            // Mostrar el diálogo y verificar si el usuario seleccionó un archivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog;
            }
            else
            {
                return openFileDialog;
            }
        }

        //carga los datos del edo de cta telecom
        private void btnAdTelecom_Click(object sender, EventArgs e)
        {
            OpenFileDialog cargar = new OpenFileDialog();                
            cargar = cargar_archivos();

            if (cargar.FileName != "")
            {
                edoCtaTelecomPath = cargar.FileName;

                LCtaTelecom tl = new LCtaTelecom();
                TableCtaTelecomm = tl.setTableTelecom();

                //crea el objeto de  y se carga la ruta del archivo de edo de cta telecomm            
                SLDocument ctaTelecomm = new SLDocument(this.edoCtaTelecomPath);
                //esta funcion carga los datos de excel al datatable (revisar la clase LCtaTelecom)
                tl.loadCtaTelecom(TableCtaTelecomm, ctaTelecomm);

                if (TableCtaTelecomm.Rows.Count > 0)
                {
                    btnAdTelecom.BackColor = Color.ForestGreen;
                    btnAdTelecom.Text = "Archivo Cargado";
                    lblCtasTelecom.Text = "Registros Cargados: " + TableCtaTelecomm.Rows.Count.ToString();
                }
                else {
                    Alerta("Ocurrió un error al cargar los datos de Telecomm");
                }
            }
        }

        private void btnAdAnalitico_Click(object sender, EventArgs e)
        {
            OpenFileDialog cargar = new OpenFileDialog();                
            cargar = cargar_archivos();
            
            if (cargar.FileName != "")
            {           
                AnalitoCarteraPath = cargar.FileName;

                LRepCartera lrc = new LRepCartera();
                TableAnalitico = lrc.setRepCarteraTable();
                
                //crea el objeto y se carga la ruta del archivo de Reporte Analitico de Cartera
                SLDocument Cartera = new SLDocument(this.AnalitoCarteraPath);
                lrc.loadCartera(TableAnalitico, Cartera);

                if (TableAnalitico.Rows.Count > 0)
                {
                    btnAdAnalitico.BackColor = Color.ForestGreen;
                    btnAdAnalitico.Text = "Archivo Cargado";
                    lblCreditosCargados.Text = "Créditos Cargados: " + TableAnalitico.Rows.Count.ToString();
                }
                else {
                    Alerta("Ocurrió un error al cargar los datos");
                }                
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string refTelecom = "";

            if (TableAnalitico.Rows != null && TableCtaTelecomm.Rows != null)
            {
                foreach (DataRow filaTelecom in TableCtaTelecomm.Rows)
                {
                    //obtiene la referencia
                    refTelecom = Convert.ToString(filaTelecom["Referencia"]);

                    //extrae la fecha de nac
                    string fechaNac = refTelecom.Substring(5, 4);
                    string creditoBien;

                    if (Convert.ToInt64(fechaNac) == 0)
                    {
                        creditoBien = refTelecom.Substring(9, 10);
                        dgvlista.Rows.Add(filaTelecom["A1"], filaTelecom["Referencia"], creditoBien, Convert.ToString(filaTelecom["fecha"]), filaTelecom["A2"], filaTelecom["Monto"], filaTelecom["Centavos"], filaTelecom["A3"]);
                    }
                    else if (Convert.ToInt64(fechaNac) > 0)
                    {
                        //obtiene los dos primeros digitos del crédito
                        string credito1 = refTelecom.Substring(11, 3) + "0";

                        //agrega un 0 intermedio y completa el numero de crédito
                        string intentoReal1 = credito1 + refTelecom.Substring(14, 5);

                        //busca el credito en el rep analitico
                        LRepCartera repC = new LRepCartera();
                        int intentoBuscar = repC.buscaCredit(intentoReal1, TableAnalitico);
                        //int intentoBuscar = buscaCredit(intentoReal1);

                        if (intentoBuscar == 0)
                        {
                            string credito2 = refTelecom.Substring(11, 3) + "00";
                            string intentoReal2 = credito2 + refTelecom.Substring(14, 5);
                            int intentoBuscar2 = repC.buscaCredit(intentoReal2, TableAnalitico);                                

                            if (intentoBuscar2 == 1)
                            {
                                dgvlista.Rows.Add(filaTelecom["A1"], filaTelecom["Referencia"], intentoReal2, filaTelecom["fecha"], filaTelecom["A2"], filaTelecom["Monto"], filaTelecom["Centavos"], filaTelecom["A3"]);
                            }
                            else
                            {
                                TableNoidentificado.Rows.Add(filaTelecom["A1"], filaTelecom["Referencia"], filaTelecom["fecha"], filaTelecom["A2"], filaTelecom["Monto"], filaTelecom["Centavos"], filaTelecom["A3"]);
                            }
                        }
                        else if (intentoBuscar == 1)
                        {
                            dgvlista.Rows.Add(filaTelecom["A1"], filaTelecom["Referencia"], intentoReal1, filaTelecom["fecha"], filaTelecom["A2"], filaTelecom["Monto"], filaTelecom["Centavos"], filaTelecom["A3"]);
                        }
                    }
                }
                TotalRegistros();
            }
            else {
                Alerta("No se han adjuntado ninguno de los archivos necesarios");
            }
        }

        private void TotalRegistros() {
            if (dgvlista.Rows.Count > 0) {
                lblTotalIdentificado.Text = dgvlista.Rows.Count.ToString();
            }
            if (TableNoidentificado.Rows.Count > 0) {
                lblNoIdentificados.Text = TableNoidentificado.Rows.Count.ToString();
            }
        }

        private void lblNoIdentificados_DoubleClick(object sender, EventArgs e)
        {           
        }

        private void lblNoIdentificados_Click(object sender, EventArgs e)
        {
            if (TableNoidentificado.Rows.Count > 0)
            {
                FrmNoIdentificados ni = new FrmNoIdentificados(this.TableNoidentificado);
                ni.ShowDialog();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (dgvlista.Rows.Count>0) {
                TableAnalitico.Clear();
                TableCtaTelecomm.Clear();
                TableNoidentificado.Clear();
                dgvlista.Rows.Clear();
                lblNoIdentificados.Text = "000";
                lblTotalIdentificado.Text = "000";
            }           
        }

        public void exportExcel() {

            if (dgvlista.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = false;
                worksheet = workbook.Sheets["Hoja1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Telecom_Identificados";

                // Cabeceras
                for (int i = 0; i < dgvlista.Columns.Count + 1; i++)
                {
                    if (i > 0 && i < dgvlista.Columns.Count + 1)
                    {
                        worksheet.Cells[1, i] = dgvlista.Columns[i - 1].HeaderText;
                    }
                }

                // recorre las filas del datagrid y vacia los valores en el worksheet de Excel
                int ii = 2;
                foreach (DataGridViewRow fila in dgvlista.Rows)
                {
                    int j = 1;
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        if (j == 2)
                        {
                            worksheet.Cells[ii, j].NumberFormat = "@";
                        }
                        worksheet.Cells[ii, j] = Convert.ToString(celda.Value).ToString();
                        j++;
                    }
                    ii++;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos de Excel|*.xlsx";
                saveFileDialog.Title = "Guardar archivo";

                DateTime fecha = DateTime.Today;
                string fechaHoy = fecha.Day.ToString() + fecha.Month.ToString() + fecha.Year.ToString() + fecha.Minute.ToString() + fecha.Second.ToString();

                saveFileDialog.FileName = "TelecomExport_" + fechaHoy;
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    Console.WriteLine("Ruta en: " + saveFileDialog.FileName);
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    app.Quit();
                }
            }
            else {
                Alerta("No existen datos para exportar...");
            }
        }

        private void ptbExportar_Click(object sender, EventArgs e)
        {
            exportExcel();
        }

        private void ptbExportar_MouseEnter(object sender, EventArgs e)
        {
            ptbExportar.BorderStyle = BorderStyle.FixedSingle;
        }

        private void ptbExportar_MouseHover(object sender, EventArgs e)
        {           
        }

        private void ptbExportar_MouseLeave(object sender, EventArgs e)
        {
            ptbExportar.BorderStyle = BorderStyle.None;
        }

        private void Alerta(string mensaje) {
            FrmNoIdentificados ident = new FrmNoIdentificados();
            ident.alerta(mensaje);
        }

    }
}
