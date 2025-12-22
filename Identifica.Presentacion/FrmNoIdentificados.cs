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
    public partial class FrmNoIdentificados : Form
    {
        public FrmNoIdentificados(DataTable dgv)
        {
            this.listaNoident = dgv;
            InitializeComponent();
        }

        public FrmNoIdentificados() {
            InitializeComponent();
        }

        DataTable listaNoident;

        private void FrmNoIdentificados_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = listaNoident;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void alerta(string mensaje) {
            MessageBox.Show(mensaje,"ATENCIÓN");
        }

        private void ptbExportar_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void ptbExportar_MouseLeave(object sender, EventArgs e)
        {
            if (ptbExportar.BorderStyle == BorderStyle.FixedSingle) {
                ptbExportar.BorderStyle = BorderStyle.None;
            }
            
        }

        private void ptbExportar_MouseMove(object sender, MouseEventArgs e)
        {
        
        }

        private void ptbExportar_MouseHover(object sender, EventArgs e)
        {
            if (ptbExportar.BorderStyle == BorderStyle.None)
            {
                ptbExportar.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void ptbExportar_Click(object sender, EventArgs e)
        {
            FrmProcess pross = new FrmProcess();
            pross.ExporToPdf(dataGridView1, "NoIdentificados");
        }
    }
}
