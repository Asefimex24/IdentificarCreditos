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

        DataTable listaNoident;

        private void FrmNoIdentificados_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = listaNoident;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
