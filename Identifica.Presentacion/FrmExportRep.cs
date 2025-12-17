using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Identifica.Presentacion
{
    public partial class FrmExportRep : Form
    {
        public FrmExportRep()
        {
            InitializeComponent();
        }

        private void FrmExportRep_Load(object sender, EventArgs e)
        {

        }

        //funcion para exportar el contenido de Datagridview a Excel
        public void ExporToPdf(DataGridView dgv) {

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
    }
}
