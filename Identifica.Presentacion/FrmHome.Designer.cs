namespace Identifica.Presentacion
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.lblCreditosCargados = new System.Windows.Forms.Label();
            this.lblCtasTelecom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdAnalitico = new System.Windows.Forms.Button();
            this.btnAdTelecom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.dgvlista = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditOK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalRegistros = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNoIdentificados = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblTotalIdentificado = new System.Windows.Forms.Label();
            this.ptbExportar = new System.Windows.Forms.PictureBox();
            this.hlpAyuda = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExportar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreditosCargados
            // 
            this.lblCreditosCargados.AutoSize = true;
            this.lblCreditosCargados.Location = new System.Drawing.Point(273, 85);
            this.lblCreditosCargados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditosCargados.Name = "lblCreditosCargados";
            this.lblCreditosCargados.Size = new System.Drawing.Size(0, 18);
            this.lblCreditosCargados.TabIndex = 43;
            // 
            // lblCtasTelecom
            // 
            this.lblCtasTelecom.AutoSize = true;
            this.lblCtasTelecom.Location = new System.Drawing.Point(16, 85);
            this.lblCtasTelecom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCtasTelecom.Name = "lblCtasTelecom";
            this.lblCtasTelecom.Size = new System.Drawing.Size(0, 18);
            this.lblCtasTelecom.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Carga Rep Analítico";
            // 
            // btnAdAnalitico
            // 
            this.btnAdAnalitico.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdAnalitico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdAnalitico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdAnalitico.FlatAppearance.BorderSize = 0;
            this.btnAdAnalitico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAdAnalitico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdAnalitico.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdAnalitico.ForeColor = System.Drawing.Color.White;
            this.btnAdAnalitico.Location = new System.Drawing.Point(270, 49);
            this.btnAdAnalitico.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdAnalitico.Name = "btnAdAnalitico";
            this.btnAdAnalitico.Size = new System.Drawing.Size(150, 30);
            this.btnAdAnalitico.TabIndex = 40;
            this.btnAdAnalitico.Text = "Adjuntar Analitico";
            this.btnAdAnalitico.UseVisualStyleBackColor = false;
            this.btnAdAnalitico.Click += new System.EventHandler(this.btnAdAnalitico_Click);
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
            this.btnAdTelecom.Location = new System.Drawing.Point(13, 49);
            this.btnAdTelecom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdTelecom.Name = "btnAdTelecom";
            this.btnAdTelecom.Size = new System.Drawing.Size(150, 30);
            this.btnAdTelecom.TabIndex = 39;
            this.btnAdTelecom.Text = "Adjuntar Telecom";
            this.btnAdTelecom.UseVisualStyleBackColor = false;
            this.btnAdTelecom.Click += new System.EventHandler(this.btnAdTelecom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Cargar edo cta Telecom";
            // 
            // btnProcesar
            // 
            this.btnProcesar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnProcesar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProcesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcesar.FlatAppearance.BorderSize = 0;
            this.btnProcesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesar.ForeColor = System.Drawing.Color.White;
            this.btnProcesar.Location = new System.Drawing.Point(581, 49);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(150, 30);
            this.btnProcesar.TabIndex = 44;
            this.btnProcesar.Text = "Identificar Créditos";
            this.btnProcesar.UseVisualStyleBackColor = false;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
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
            this.dgvlista.Location = new System.Drawing.Point(12, 106);
            this.dgvlista.Name = "dgvlista";
            this.dgvlista.ReadOnly = true;
            this.dgvlista.RowHeadersVisible = false;
            this.dgvlista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvlista.Size = new System.Drawing.Size(1139, 570);
            this.dgvlista.TabIndex = 46;
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
            // lblTotalRegistros
            // 
            this.lblTotalRegistros.AutoSize = true;
            this.lblTotalRegistros.Location = new System.Drawing.Point(958, 679);
            this.lblTotalRegistros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRegistros.Name = "lblTotalRegistros";
            this.lblTotalRegistros.Size = new System.Drawing.Size(175, 18);
            this.lblTotalRegistros.TabIndex = 48;
            this.lblTotalRegistros.Text = "Créditos Identificados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 679);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "No identificados:";
            // 
            // lblNoIdentificados
            // 
            this.lblNoIdentificados.AutoSize = true;
            this.lblNoIdentificados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNoIdentificados.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoIdentificados.Location = new System.Drawing.Point(134, 679);
            this.lblNoIdentificados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoIdentificados.Name = "lblNoIdentificados";
            this.lblNoIdentificados.Size = new System.Drawing.Size(45, 20);
            this.lblNoIdentificados.TabIndex = 50;
            this.lblNoIdentificados.Text = "000";
            this.lblNoIdentificados.Click += new System.EventHandler(this.lblNoIdentificados_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(1088, 9);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 30);
            this.btnNuevo.TabIndex = 51;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblTotalIdentificado
            // 
            this.lblTotalIdentificado.AutoSize = true;
            this.lblTotalIdentificado.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIdentificado.Location = new System.Drawing.Point(1116, 679);
            this.lblTotalIdentificado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIdentificado.Name = "lblTotalIdentificado";
            this.lblTotalIdentificado.Size = new System.Drawing.Size(41, 18);
            this.lblTotalIdentificado.TabIndex = 52;
            this.lblTotalIdentificado.Text = "000";
            // 
            // ptbExportar
            // 
            this.ptbExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbExportar.Image = ((System.Drawing.Image)(resources.GetObject("ptbExportar.Image")));
            this.ptbExportar.Location = new System.Drawing.Point(1110, 49);
            this.ptbExportar.Name = "ptbExportar";
            this.ptbExportar.Size = new System.Drawing.Size(40, 40);
            this.ptbExportar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExportar.TabIndex = 53;
            this.ptbExportar.TabStop = false;
            this.ptbExportar.Click += new System.EventHandler(this.ptbExportar_Click);
            this.ptbExportar.MouseEnter += new System.EventHandler(this.ptbExportar_MouseEnter);
            this.ptbExportar.MouseLeave += new System.EventHandler(this.ptbExportar_MouseLeave);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1163, 713);
            this.Controls.Add(this.ptbExportar);
            this.Controls.Add(this.lblTotalIdentificado);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lblNoIdentificados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalRegistros);
            this.Controls.Add(this.dgvlista);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.lblCreditosCargados);
            this.Controls.Add(this.lblCtasTelecom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdAnalitico);
            this.Controls.Add(this.btnAdTelecom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identificar Creditos [ Ref-Telecomm ]";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExportar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCreditosCargados;
        private System.Windows.Forms.Label lblCtasTelecom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdAnalitico;
        private System.Windows.Forms.Button btnAdTelecom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.DataGridView dgvlista;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.DataGridViewTextBoxColumn referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn AB;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ac;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNoIdentificados;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label lblTotalIdentificado;
        private System.Windows.Forms.PictureBox ptbExportar;
        private System.Windows.Forms.HelpProvider hlpAyuda;
    }
}