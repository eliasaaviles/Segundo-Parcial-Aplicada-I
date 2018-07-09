namespace SegundoParcial.UI.Consulta
{
    partial class ConsultaPersona
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
            this.label1 = new System.Windows.Forms.Label();
            this.FiltroCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CriterioBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HastaPicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DesdePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro:";
            // 
            // FiltroCombo
            // 
            this.FiltroCombo.FormattingEnabled = true;
            this.FiltroCombo.Items.AddRange(new object[] {
            "ID",
            "Nombres",
            "Cedula",
            "Direccion",
            "Telefono"});
            this.FiltroCombo.Location = new System.Drawing.Point(43, 21);
            this.FiltroCombo.Name = "FiltroCombo";
            this.FiltroCombo.Size = new System.Drawing.Size(93, 21);
            this.FiltroCombo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Criterio:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // CriterioBox
            // 
            this.CriterioBox.Location = new System.Drawing.Point(211, 21);
            this.CriterioBox.Name = "CriterioBox";
            this.CriterioBox.Size = new System.Drawing.Size(244, 20);
            this.CriterioBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CriterioBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FiltroCombo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda Por:";
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Location = new System.Drawing.Point(552, 43);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(75, 23);
            this.BuscarBoton.TabIndex = 5;
            this.BuscarBoton.Text = "Buscar";
            this.BuscarBoton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Buscar Por Rango De Fechas:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HastaPicker);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.DesdePicker);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(167, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 31);
            this.panel1.TabIndex = 7;
            // 
            // HastaPicker
            // 
            this.HastaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastaPicker.Location = new System.Drawing.Point(199, 8);
            this.HastaPicker.Name = "HastaPicker";
            this.HastaPicker.Size = new System.Drawing.Size(100, 20);
            this.HastaPicker.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hasta:";
            // 
            // DesdePicker
            // 
            this.DesdePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdePicker.Location = new System.Drawing.Point(50, 8);
            this.DesdePicker.Name = "DesdePicker";
            this.DesdePicker.Size = new System.Drawing.Size(100, 20);
            this.DesdePicker.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Desde:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 121);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(636, 188);
            this.dataGridView.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ConsultaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 355);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BuscarBoton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultaPersona";
            this.Text = "ConsultaPersona";
            this.Load += new System.EventHandler(this.ConsultaPersona_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltroCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CriterioBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker HastaPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DesdePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button1;
    }
}