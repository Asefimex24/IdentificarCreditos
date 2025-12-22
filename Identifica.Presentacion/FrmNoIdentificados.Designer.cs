namespace Identifica.Presentacion
{
    partial class FrmNoIdentificados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNoIdentificados));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ptbExportar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExportar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1008, 505);
            this.dataGridView1.TabIndex = 0;
            // 
            // ptbExportar
            // 
            this.ptbExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExportar.Image = ((System.Drawing.Image)(resources.GetObject("ptbExportar.Image")));
            this.ptbExportar.Location = new System.Drawing.Point(994, 9);
            this.ptbExportar.Name = "ptbExportar";
            this.ptbExportar.Size = new System.Drawing.Size(30, 30);
            this.ptbExportar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExportar.TabIndex = 54;
            this.ptbExportar.TabStop = false;
            this.ptbExportar.Click += new System.EventHandler(this.ptbExportar_Click);
            this.ptbExportar.MouseEnter += new System.EventHandler(this.ptbExportar_MouseEnter);
            this.ptbExportar.MouseLeave += new System.EventHandler(this.ptbExportar_MouseLeave);
            this.ptbExportar.MouseHover += new System.EventHandler(this.ptbExportar_MouseHover);
            this.ptbExportar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbExportar_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "REFERENCIAS/CREDITOS NO IDENTIFICADOS";
            // 
            // FrmNoIdentificados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1036, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbExportar);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmNoIdentificados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNoIdentificados";
            this.Load += new System.EventHandler(this.FrmNoIdentificados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExportar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox ptbExportar;
        private System.Windows.Forms.Label label1;
    }
}