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
            settooltip();

            HelpProviderBotones();
            
        }

        private void HelpProviderBotones() {
            hlpAyuda = new HelpProvider();
            hlpAyuda.SetShowHelp(this.btnAdTelecom, true);
            hlpAyuda.SetHelpString(this.btnAdTelecom, "Las columnas que deben contener el archivo son las siguientes:" +
                 " |  A | REFERENCIA | FECHA | MONTO | CENTAVOS | A |");
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


        string mensaje1 = "El archivo de Telecom debe contener las siguentes columnas:" +
            "  A - REFERENCIA - FECHA - MONTO - CENTAVOS - A ";

        private void settooltip() {
            FrmProcess pr = new FrmProcess();
            pr.setTooltip(btnAdTelecom, mensaje1);

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
                    lblCtasTelecom.Text = "Registros Leidos: " + TableCtaTelecomm.Rows.Count.ToString();
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

                //genera el datatable con las columnas correspondientes
                LRepCartera lrc = new LRepCartera();
                TableAnalitico = lrc.setRepCarteraTable();
                
                //crea el objeto, carga la ruta del archivo de Reporte Analitico de Cartera y se cargan los datos al Datatable
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

        private void TotalRegistros() {
            if (dgvlista.Rows.Count > 0) {
                lblTotalIdentificado.Text = dgvlista.Rows.Count.ToString();
            }
            if (TableNoidentificado.Rows.Count > 0) {
                lblNoIdentificados.Text = TableNoidentificado.Rows.Count.ToString();
            }
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
                btnAdAnalitico.Text = "Adjuntar Analitico";
                btnAdTelecom.Text = "Adjuntar Telecom";
                btnAdAnalitico.BackColor = System.Drawing.SystemColors.HotTrack;                
                btnAdTelecom.BackColor = System.Drawing.SystemColors.HotTrack;
                lblCreditosCargados.Text = "";
                lblCtasTelecom.Text = "";
                lblNoIdentificados.Text = "000";
                lblTotalIdentificado.Text = "000";
            }           
        }

        private void ptbExportar_Click(object sender, EventArgs e)
        {
            FrmProcess exprep = new FrmProcess();            
            exprep.ExporToPdf(dgvlista);
        }

        private void ptbExportar_MouseEnter(object sender, EventArgs e)
        {
            ptbExportar.BorderStyle = BorderStyle.FixedSingle;
        }

        private void ptbExportar_MouseLeave(object sender, EventArgs e)
        {
            ptbExportar.BorderStyle = BorderStyle.None;
        }

        private void Alerta(string mensaje) {
            FrmNoIdentificados ident = new FrmNoIdentificados();
            ident.alerta(mensaje);
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {           
            if (TableAnalitico.Rows != null && TableCtaTelecomm.Rows != null)
            {
                FrmProcess procIdentifica = new FrmProcess();
                procIdentifica.procesoIdentificaCreditos(this.TableAnalitico, this.TableCtaTelecomm, this.TableNoidentificado, this.dgvlista);
                TotalRegistros();
            }
            else
            {
                Alerta("No se han adjuntado ninguno de los archivos necesarios");
            }
        }
    }
}
