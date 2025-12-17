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
        }

        private void InicializarDatatableNoIdentificados() {

            TableNoidentificado = new DataTable("NoIdentificados");
            //add columnas al datatable
            DataColumn A1 = new DataColumn("A1");
            DataColumn Referencia = new DataColumn("Referencia");
            DataColumn fecha = new DataColumn("fecha");
            DataColumn A2 = new DataColumn("A2");
            DataColumn Monto = new DataColumn("Monto");
            DataColumn Centavos = new DataColumn("Centavos");
            DataColumn A3 = new DataColumn("A3");

            TableNoidentificado.Columns.Add(A1);
            TableNoidentificado.Columns.Add(Referencia);
            TableNoidentificado.Columns.Add(fecha);
            TableNoidentificado.Columns.Add(A2);
            TableNoidentificado.Columns.Add(Monto);
            TableNoidentificado.Columns.Add(Centavos);
            TableNoidentificado.Columns.Add(A3);
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
                TableCtaTelecomm = new DataTable("RepCtaTelecom");
                //add columnas al datatable
                DataColumn A1 = new DataColumn("A1");
                DataColumn Referencia = new DataColumn("Referencia");
                DataColumn fecha = new DataColumn("fecha");
                DataColumn A2 = new DataColumn("A2");
                DataColumn Monto = new DataColumn("Monto");
                DataColumn Centavos = new DataColumn("Centavos");
                DataColumn A3 = new DataColumn("A3");

                TableCtaTelecomm.Columns.Add(A1);
                TableCtaTelecomm.Columns.Add(Referencia);
                TableCtaTelecomm.Columns.Add(fecha);
                TableCtaTelecomm.Columns.Add(A2);
                TableCtaTelecomm.Columns.Add(Monto);
                TableCtaTelecomm.Columns.Add(Centavos);
                TableCtaTelecomm.Columns.Add(A3);

                //crea el objeto y se carga la ruta del archivo de edo de cta telecomm            
                SLDocument ctaTelecomm = new SLDocument(this.edoCtaTelecomPath);
                int valorX = 3;                

                //recorre cada fila del archivo de ctaTelecomm de acuerdo a los valores (posicion-fila , posicion-columna)
                while (!string.IsNullOrEmpty(ctaTelecomm.GetCellValueAsString(valorX, 3))) {
                    
                    //agrega cada fila del archivo edo cta telecom al datatable
                    TableCtaTelecomm.Rows.Add(ctaTelecomm.GetCellValueAsString(valorX, 1),ctaTelecomm.GetCellValueAsString(valorX, 2), ctaTelecomm.GetCellValueAsDateTime(valorX, 5).ToShortDateString(), ctaTelecomm.GetCellValueAsString(valorX, 6), ctaTelecomm.GetCellValueAsString(valorX, 7), ctaTelecomm.GetCellValueAsString(valorX, 8), ctaTelecomm.GetCellValueAsString(valorX, 9));

                    valorX++;
                }
                btnAdTelecom.BackColor = Color.ForestGreen;
                btnAdTelecom.Text = "Archivo Cargado";
                lblCtasTelecom.Text = "Registros Cargados: " + (valorX - 3).ToString();
            }
        }

        private void btnAdAnalitico_Click(object sender, EventArgs e)
        {
            OpenFileDialog cargar = new OpenFileDialog();                
            cargar = cargar_archivos();
            
            if (cargar.FileName != "")
            {
           
                AnalitoCarteraPath = cargar.FileName;                
                TableAnalitico = new DataTable("RepAnalitico");
                DataColumn numCredit = new DataColumn("credito");
                
                TableAnalitico.Columns.Add(numCredit);
                
                //crea el objeto y se carga la ruta del archivo de Reporte Analitico de Cartera
                SLDocument Cartera = new SLDocument(this.AnalitoCarteraPath);
                int valorXCartera = 10;
          
                while (!string.IsNullOrEmpty(Cartera.GetCellValueAsString(valorXCartera, 2)))
                {                   
                    TableAnalitico.Rows.Add(Cartera.GetCellValueAsString(valorXCartera, 2));
                    valorXCartera++;
                }
                btnAdAnalitico.BackColor = Color.ForestGreen;
                btnAdAnalitico.Text = "Archivo Cargado";
                lblCreditosCargados.Text= "Créditos Cargados: " +(valorXCartera-10).ToString();                                            
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string refTelecom = "";
            if (TableAnalitico.Rows.Count > 0 && TableCtaTelecomm.Rows.Count>0) {
                

                foreach (DataRow filaTelecom in TableCtaTelecomm.Rows) {
                    //obtiene la referencia
                    refTelecom = Convert.ToString(filaTelecom["Referencia"]);
                    //extrae la fecha de nac
                    string fechaNac = refTelecom.Substring(5,4);
                    
                    string creditoBien;

                    if (Convert.ToInt64(fechaNac) == 0)
                    {
                        creditoBien = refTelecom.Substring(9, 10);
                        dgvlista.Rows.Add(filaTelecom["A1"], filaTelecom["Referencia"], creditoBien, Convert.ToString(filaTelecom["fecha"]), filaTelecom["A2"], filaTelecom["Monto"], filaTelecom["Centavos"], filaTelecom["A3"]);
                    }
                    else if (Convert.ToInt64(fechaNac) > 0) {

                        //obtiene los dos primeros digitos del crédito
                        string credito1 = refTelecom.Substring(11, 3) + "0";

                        //agrega un 0 intermedio y completa el numero de crédito
                        string intentoReal1 = credito1 + refTelecom.Substring(14, 5);
                        
                        //busca ek credito en el rep analitico
                        int intentoBuscar = buscaCredit(intentoReal1);

                        if (intentoBuscar == 0)
                        {
                            string credito2 = refTelecom.Substring(11,3) + "00";
                            string intentoReal2 = credito2 + refTelecom.Substring(14,5);
                            int intentoBuscar2 = buscaCredit(intentoReal2);

                            if (intentoBuscar2 == 1)
                            {
                                dgvlista.Rows.Add(filaTelecom["A1"], filaTelecom["Referencia"], intentoReal2, filaTelecom["fecha"], filaTelecom["A2"], filaTelecom["Monto"], filaTelecom["Centavos"], filaTelecom["A3"]);
                            }
                            else {

                                TableNoidentificado.Rows.Add(filaTelecom["A1"], filaTelecom["Referencia"], filaTelecom["fecha"], filaTelecom["A2"], filaTelecom["Monto"], filaTelecom["Centavos"], filaTelecom["A3"]);
                            }
                        }
                        else if (intentoBuscar == 1) {
                            dgvlista.Rows.Add(filaTelecom["A1"], filaTelecom["Referencia"], intentoReal1, filaTelecom["fecha"], filaTelecom["A2"], filaTelecom["Monto"], filaTelecom["Centavos"], filaTelecom["A3"]);
                        }            
                    }
                }
                
                TotalRegistros();
            }
        }


        private int buscaCredit(string credito)
        {
            int intento = 0;
            foreach (DataRow filaCartera in TableAnalitico.Rows)
            {
                string creditCartera = Convert.ToString(filaCartera["credito"]);
                
                if (credito == creditCartera) {
                    intento = 1;
                    return intento;
                }                
            }
            return intento;
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
            if (TableAnalitico.Rows.Count > 0 && TableCtaTelecomm.Rows.Count>0 && dgvlista.Rows.Count>0) {
                TableAnalitico.Clear();
                TableCtaTelecomm.Clear();
                TableNoidentificado.Clear();
                dgvlista.Rows.Clear();
                lblNoIdentificados.Text = "000";
                lblTotalIdentificado.Text = "000";
            }            
        }

        public void exportExcel() {
            if (dgvlista.Rows.Count > 0) {

                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = false;
                worksheet = workbook.Sheets["Hoja1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Telecom_Identificados";
                
                // Cabeceras
                for (int i = 0; i < dgvlista.Columns.Count+1; i++)
                {
                    if (i > 0 && i < dgvlista.Columns.Count+1)
                    {
                        worksheet.Cells[1, i] = dgvlista.Columns[i - 1].HeaderText;
                    }
                }
             
                // Valores
                int ii = 2;
                foreach (DataGridViewRow fila in dgvlista.Rows)
                {
                    int j = 1;
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        if (j == 2) {
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
                string fechaHoy = fecha.Day.ToString() + fecha.Month.ToString() + fecha.Year.ToString()+fecha.Minute.ToString()+fecha.Second.ToString();

                saveFileDialog.FileName = "TelecomExport_"+fechaHoy;
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    Console.WriteLine("Ruta en: " + saveFileDialog.FileName);
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    app.Quit();
                }
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

    }
}
