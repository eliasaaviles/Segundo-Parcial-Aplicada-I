namespace SegundoParcial.UI.Consulta
{
    partial class ConsutaProducto
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
            this.label4 = new System.Windows.Forms.Label();
            this.Fechaspanel = new System.Windows.Forms.Panel();
            this.HastaPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.DesdePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.CriterioBox = new System.Windows.Forms.TextBox();
            this.FiltroCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Fechaspanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Filtrar usando Rango de fechas";
            // 
            // Fechaspanel
            // 
            this.Fechaspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Fechaspanel.Controls.Add(this.HastaPicker);
            this.Fechaspanel.Controls.Add(this.label3);
            this.Fechaspanel.Controls.Add(this.DesdePicker);
            this.Fechaspanel.Controls.Add(this.label6);
            this.Fechaspanel.Location = new System.Drawing.Point(165, 53);
            this.Fechaspanel.Margin = new System.Windows.Forms.Padding(2);
            this.Fechaspanel.Name = "Fechaspanel";
            this.Fechaspanel.Size = new System.Drawing.Size(391, 30);
            this.Fechaspanel.TabIndex = 43;
            // 
            // HastaPicker
            // 
            this.HastaPicker.CustomFormat = "dd/MM/yyyy";
            this.HastaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaPicker.Location = new System.Drawing.Point(247, 6);
            this.HastaPicker.Margin = new System.Windows.Forms.Padding(2);
            this.HastaPicker.Name = "HastaPicker";
            this.HastaPicker.Size = new System.Drawing.Size(139, 20);
            this.HastaPicker.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hasta";
            // 
            // DesdePicker
            // 
            this.DesdePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdePicker.Location = new System.Drawing.Point(41, 6);
            this.DesdePicker.Margin = new System.Windows.Forms.Padding(2);
            this.DesdePicker.Name = "DesdePicker";
            this.DesdePicker.Size = new System.Drawing.Size(139, 20);
            this.DesdePicker.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Desde";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BuscarBoton);
            this.groupBox1.Controls.Add(this.CriterioBox);
            this.groupBox1.Controls.Add(this.FiltroCombo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(643, 41);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por:";
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Location = new System.Drawing.Point(563, 14);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(75, 23);
            this.BuscarBoton.TabIndex = 4;
            this.BuscarBoton.Text = "Buscar";
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // CriterioBox
            // 
            this.CriterioBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CriterioBox.Location = new System.Drawing.Point(224, 14);
            this.CriterioBox.Name = "CriterioBox";
            this.CriterioBox.Size = new System.Drawing.Size(321, 20);
            this.CriterioBox.TabIndex = 3;
            // 
            // FiltroCombo
            // 
            this.FiltroCombo.FormattingEnabled = true;
            this.FiltroCombo.Items.AddRange(new object[] {
            "ID",
            "Descripcion",
            "Precio",
            "Cantidad cotizada"});
            this.FiltroCombo.Location = new System.Drawing.Point(44, 13);
            this.FiltroCombo.Name = "FiltroCombo";
            this.FiltroCombo.Size = new System.Drawing.Size(121, 21);
            this.FiltroCombo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Criterio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(11, 88);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 10;
            this.dataGridView.Size = new System.Drawing.Size(545, 244);
            this.dataGridView.TabIndex = 40;
            // 
            // ConsutaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 387);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Fechaspanel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Name = "ConsutaProducto";
            this.Text = "ConsutaProducto";
            this.Load += new System.EventHandler(this.ConsutaProducto_Load);
            this.Fechaspanel.ResumeLayout(false);
            this.Fechaspanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel Fechaspanel;
        private System.Windows.Forms.DateTimePicker HastaPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DesdePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CriterioBox;
        private System.Windows.Forms.ComboBox FiltroCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button BuscarBoton;
    }
}