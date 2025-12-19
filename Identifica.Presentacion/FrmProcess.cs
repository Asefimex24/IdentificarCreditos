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
    public partial class FrmProcess : Form
    {
        public FrmProcess()
        {
            InitializeComponent();
        }

        private void FrmProcess_Load(object sender, EventArgs e)
        {

        }

        public void procesoIdentificaCreditos(DataTable cartera, DataTable telecom,DataTable noIdentificados, DataGridView dgv )
        {
            string refTelecom = "";
            foreach (DataRow filaTelecom in telecom.Rows)
            {
                //obtiene la referencia
                refTelecom = Convert.ToString(filaTelecom["Referencia"]);

                //extrae la fecha de nac
                string fechaNac = refTelecom.Substring(5, 4);
                string creditoBien;

                if (Convert.ToInt64(fechaNac) == 0)
                {
                    creditoBien = refTelecom.Substring(9, 10);
                    dgv.Rows.Add(filaTelecom["A1"], filaTelecom["Referencia"], creditoBien, Convert.ToString(filaTelecom["fecha"]), filaTelecom["A2"], filaTelecom["Monto"], filaTelecom["Centavos"], filaTelecom["A3"]);
                }
                else if (Convert.ToInt64(fechaNac) > 0)
                {
                    //obtiene los dos primeros digitos del crédito
                    string credito1 = refTelecom.Substring(11, 3) + "0";

                    //agrega un 0 intermedio y completa el numero de crédito
                    string intentoReal1 = credito1 + refTelecom.Substring(14, 5);

                    //busca el credito en el rep analitico
                    LRepCartera repC = new LRepCartera();
                    //int intentoBuscar = repC.buscaCredit(intentoReal1, cartera);
                    //int intentoBuscar = buscaCredit(intentoReal1);

                    int intentoBuscar = buscaCredit(intentoReal1, cartera);

                    if (intentoBuscar == 0)
                    {
                        string credito2 = refTelecom.Substring(11, 3) + "00";
                        string intentoReal2 = credito2 + refTelecom.Substring(14, 5);
                        int intentoBuscar2 = repC.buscaCredit(intentoReal2, cartera);

                        if (intentoBuscar2 == 1)
                        {
                            dgv.Rows.Add(filaTelecom["A1"], filaTelecom["Referencia"], intentoReal2, filaTelecom["fecha"], filaTelecom["A2"], filaTelecom["Monto"], filaTelecom["Centavos"], filaTelecom["A3"]);
                        }
                        else
                        {
                            noIdentificados.Rows.Add(filaTelecom["A1"], filaTelecom["Referencia"], filaTelecom["fecha"], filaTelecom["A2"], filaTelecom["Monto"], filaTelecom["Centavos"], filaTelecom["A3"]);
                        }
                    }
                    else if (intentoBuscar == 1)
                    {
                        dgv.Rows.Add(filaTelecom["A1"], filaTelecom["Referencia"], intentoReal1, filaTelecom["fecha"], filaTelecom["A2"], filaTelecom["Monto"], filaTelecom["Centavos"], filaTelecom["A3"]);
                    }
                }
            }           
        }


        //funcion para exportar el contenido de Datagridview a Excel
        public void ExporToPdf(DataGridView dgv)
        {

            if (dgv.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = false;
                worksheet = workbook.Sheets["Hoja1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Telecom_Identificados";

                // Cabeceras
                for (int i = 0; i < dgv.Columns.Count + 1; i++)
                {
                    if (i > 0 && i < dgv.Columns.Count + 1)
                    {
                        worksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                    }
                }

                // recorre las filas del datagrid y vacia los valores en el worksheet de Excel
                int ii = 2;
                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    int j = 1;
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        if (j == 2)
                        {
                            //establece el tipo de dato como texto para mostrar la referencia completa y sin formato
                            worksheet.Cells[ii, j].NumberFormat = "@";
                        }
                        //guarda le contenido de la celta en la hoja de datos
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
            else
            {
                FrmNoIdentificados nid = new FrmNoIdentificados();
                nid.alerta("No hay datos para exportar...");
            }
        }


        public int buscaCredit(string credito, DataTable cartera)
        {
            int intento = 0;
            foreach (DataRow filaCartera in cartera.Rows)
            {
                string creditCartera = Convert.ToString(filaCartera["credito"]);

                //Validar si los ultimos 4 digitos del credito se encuentra mas de una vez

                ////extraer ultimos 4 digitos del creditos
                //string digitosCredito = credito.Substring(credito.Length - 4, 4);
                ////extraer ultimos 4 digitos del credito en cartera
                //string digitosCredCartera = creditCartera.Substring(creditCartera.Length - 4, 4);

                //if (digitosCredito == digitosCredCartera) {
                //    MessageBox.Show(digitosCredito + "     " + digitosCredCartera);
                //}                

                if (credito == creditCartera)
                {
                    intento = 1;
                    return intento;
                }
            }
            return intento;
        }

        public void setTooltip(Control control, string mensaje) {
            ToolTip tlp = new ToolTip();
            tlp.SetToolTip(control, mensaje);
            
        }
    }
}
