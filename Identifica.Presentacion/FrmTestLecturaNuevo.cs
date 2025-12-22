using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Identifica.Logica;
using SpreadsheetLight;

namespace Identifica.Presentacion
{
    public partial class FrmTestLecturaNuevo : Form
    {
        public FrmTestLecturaNuevo()
        {
            InitializeComponent();
        }

        DataTable ctaTelComTable;
        string edoCtaTelecomPath;


        private void FrmTestLecturaNuevo_Load(object sender, EventArgs e)
        {
            iniciaTableTelecom();
        }

        private void iniciaTableTelecom() {
            LCtaTelecom tel = new LCtaTelecom();
            ctaTelComTable = tel.iniciaTabletelecom();
        }

        private void btnAdTelecom_Click(object sender, EventArgs e)
        {
            OpenFileDialog cargar = new OpenFileDialog();
            FrmHome home = new FrmHome();
            cargar = home.cargar_archivos();

            if (cargar.FileName != "")
            {
                edoCtaTelecomPath = cargar.FileName;

                LCtaTelecom tl = new LCtaTelecom();
                ctaTelComTable = tl.setTableTelecom();

                //crea el objeto de  y se carga la ruta del archivo de edo de cta telecomm            
                SLDocument ctaTelecomm = new SLDocument(this.edoCtaTelecomPath);
                //esta funcion carga los datos de excel al datatable (revisar la clase LCtaTelecom)
                tl.loadCtaTelecom(ctaTelComTable, ctaTelecomm);

                if (ctaTelComTable.Rows.Count > 0)
                {
                    btnAdTelecom.BackColor = Color.ForestGreen;
                    btnAdTelecom.Text = "Archivo Cargado";
                    lblCtasTelecom.Text = "Registros Leidos: " + ctaTelComTable.Rows.Count.ToString();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al cargar los datos de Telecomm");
                }
            }
        }
    }
}
