namespace Identifica.Presentacion
{
    partial class FrmTestLecturaNuevo
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
            this.dgvlista = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditOK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdTelecom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCtasTelecom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlista
            // 
            this.dgvlista.AllowUserToAddRows = false;
            this.dgvlista.AllowUserToDeleteRows = false;
            this.dgvlista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A,
            this.referencia,
            this.creditOK,
            this.fecha,
            this.AB,
            this.monto,
            this.cent,
            this.ac});
            this.dgvlista.Location = new System.Drawing.Point(17, 69);
            this.dgvlista.Name = "dgvlista";
            this.dgvlista.ReadOnly = true;
            this.dgvlista.RowHeadersVisible = false;
            this.dgvlista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvlista.Size = new System.Drawing.Size(1154, 347);
            this.dgvlista.TabIndex = 49;
            // 
            // A
            // 
            this.A.HeaderText = "A";
            this.A.Name = "A";
            this.A.ReadOnly = true;
            // 
            // referencia
            // 
            this.referencia.HeaderText = "REFERENCIA";
            this.referencia.Name = "referencia";
            this.referencia.ReadOnly = true;
            // 
            // creditOK
            // 
            this.creditOK.HeaderText = "CREDITO-OK";
            this.creditOK.Name = "creditOK";
            this.creditOK.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // AB
            // 
            this.AB.HeaderText = "A";
            this.AB.Name = "AB";
            this.AB.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.HeaderText = "MONTO";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // cent
            // 
            this.cent.HeaderText = "CENTAVOS";
            this.cent.Name = "cent";
            this.cent.ReadOnly = true;
            // 
            // ac
            // 
            this.ac.HeaderText = "A";
            this.ac.Name = "ac";
            this.ac.ReadOnly = true;
            // 
            // btnAdTelecom
            // 
            this.btnAdTelecom.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdTelecom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdTelecom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdTelecom.FlatAppearance.BorderSize = 0;
            this.btnAdTelecom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAdTelecom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdTelecom.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdTelecom.ForeColor = System.Drawing.Color.White;
            this.btnAdTelecom.Location = new System.Drawing.Point(17, 31);
            this.btnAdTelecom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdTelecom.Name = "btnAdTelecom";
            this.btnAdTelecom.Size = new System.Drawing.Size(131, 32);
            this.btnAdTelecom.TabIndex = 48;
            this.btnAdTelecom.Text = "Adjuntar Telecom";
            this.btnAdTelecom.UseVisualStyleBackColor = false;
            this.btnAdTelecom.Click += new System.EventHandler(this.btnAdTelecom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 47;
            this.label1.Text = "Cargar edo cta Telecom";
            // 
            // lblCtasTelecom
            // 
            this.lblCtasTelecom.AutoSize = true;
            this.lblCtasTelecom.Location = new System.Drawing.Point(180, 40);
            this.lblCtasTelecom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCtasTelecom.Name = "lblCtasTelecom";
            this.lblCtasTelecom.Size = new System.Drawing.Size(0, 19);
            this.lblCtasTelecom.TabIndex = 50;
            // 
            // FrmTestLecturaNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 428);
            this.Controls.Add(this.lblCtasTelecom);
            this.Controls.Add(this.dgvlista);
            this.Controls.Add(this.btnAdTelecom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmTestLecturaNuevo";
            this.Text = "FrmTestLecturaNuevo";
            this.Load += new System.EventHandler(this.FrmTestLecturaNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlista;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn AB;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ac;
        private System.Windows.Forms.Button btnAdTelecom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCtasTelecom;
    }
}