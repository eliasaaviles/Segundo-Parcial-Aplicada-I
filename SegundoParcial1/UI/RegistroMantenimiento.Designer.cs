namespace SegundoParcial1.UI
{
    partial class RegistroMantenimiento
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
            this.IDnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.FechadateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ProxFechadateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.VehiculocomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TallerBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ArticuloCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PrecioBox = new System.Windows.Forms.TextBox();
            this.AnadirBoton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ImporteBox = new System.Windows.Forms.TextBox();
            this.MantenimientoData = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SubBox = new System.Windows.Forms.TextBox();
            this.ItbisBox = new System.Windows.Forms.TextBox();
            this.TotalBox = new System.Windows.Forms.TextBox();
            this.NuevoBoton = new System.Windows.Forms.Button();
            this.GuardarBoton = new System.Windows.Forms.Button();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.CantidadNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MantenimientoData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento ID: ";
            // 
            // IDnumericUpDown1
            // 
            this.IDnumericUpDown1.Location = new System.Drawing.Point(114, 12);
            this.IDnumericUpDown1.Name = "IDnumericUpDown1";
            this.IDnumericUpDown1.Size = new System.Drawing.Size(55, 20);
            this.IDnumericUpDown1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha del mantenimiento: ";
            // 
            // FechadateTimePicker1
            // 
            this.FechadateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechadateTimePicker1.Location = new System.Drawing.Point(151, 38);
            this.FechadateTimePicker1.Name = "FechadateTimePicker1";
            this.FechadateTimePicker1.Size = new System.Drawing.Size(80, 20);
            this.FechadateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Proximo Mantenimiento:";
            // 
            // ProxFechadateTimePicker1
            // 
            this.ProxFechadateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ProxFechadateTimePicker1.Location = new System.Drawing.Point(378, 38);
            this.ProxFechadateTimePicker1.Name = "ProxFechadateTimePicker1";
            this.ProxFechadateTimePicker1.Size = new System.Drawing.Size(80, 20);
            this.ProxFechadateTimePicker1.TabIndex = 5;
            this.ProxFechadateTimePicker1.ValueChanged += new System.EventHandler(this.ProxFechadateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vehiculo:";
            // 
            // VehiculocomboBox
            // 
            this.VehiculocomboBox.FormattingEnabled = true;
            this.VehiculocomboBox.Location = new System.Drawing.Point(70, 64);
            this.VehiculocomboBox.Name = "VehiculocomboBox";
            this.VehiculocomboBox.Size = new System.Drawing.Size(389, 21);
            this.VehiculocomboBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Taller:";
            // 
            // TallerBox
            // 
            this.TallerBox.FormattingEnabled = true;
            this.TallerBox.Location = new System.Drawing.Point(70, 105);
            this.TallerBox.Name = "TallerBox";
            this.TallerBox.Size = new System.Drawing.Size(389, 21);
            this.TallerBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Articulo:";
            // 
            // ArticuloCombo
            // 
            this.ArticuloCombo.FormattingEnabled = true;
            this.ArticuloCombo.Location = new System.Drawing.Point(12, 163);
            this.ArticuloCombo.Name = "ArticuloCombo";
            this.ArticuloCombo.Size = new System.Drawing.Size(121, 21);
            this.ArticuloCombo.TabIndex = 11;
            this.ArticuloCombo.SelectedIndexChanged += new System.EventHandler(this.ArticuloCombo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Precio:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // PrecioBox
            // 
            this.PrecioBox.Location = new System.Drawing.Point(215, 164);
            this.PrecioBox.Name = "PrecioBox";
            this.PrecioBox.Size = new System.Drawing.Size(91, 20);
            this.PrecioBox.TabIndex = 15;
            // 
            // AnadirBoton
            // 
            this.AnadirBoton.Location = new System.Drawing.Point(408, 164);
            this.AnadirBoton.Name = "AnadirBoton";
            this.AnadirBoton.Size = new System.Drawing.Size(50, 23);
            this.AnadirBoton.TabIndex = 16;
            this.AnadirBoton.Text = "Añadir";
            this.AnadirBoton.UseVisualStyleBackColor = true;
            this.AnadirBoton.Click += new System.EventHandler(this.AnadirBoton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Importe:";
            // 
            // ImporteBox
            // 
            this.ImporteBox.Location = new System.Drawing.Point(315, 164);
            this.ImporteBox.Name = "ImporteBox";
            this.ImporteBox.Size = new System.Drawing.Size(87, 20);
            this.ImporteBox.TabIndex = 18;
            this.ImporteBox.TextChanged += new System.EventHandler(this.ImporteBox_TextChanged);
            // 
            // MantenimientoData
            // 
            this.MantenimientoData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MantenimientoData.Location = new System.Drawing.Point(12, 190);
            this.MantenimientoData.Name = "MantenimientoData";
            this.MantenimientoData.Size = new System.Drawing.Size(446, 115);
            this.MantenimientoData.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(312, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Sub-Total:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(312, 343);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "18% ITBIS:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(312, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Total:";
            // 
            // SubBox
            // 
            this.SubBox.Location = new System.Drawing.Point(371, 315);
            this.SubBox.Name = "SubBox";
            this.SubBox.Size = new System.Drawing.Size(87, 20);
            this.SubBox.TabIndex = 23;
            // 
            // ItbisBox
            // 
            this.ItbisBox.Location = new System.Drawing.Point(372, 341);
            this.ItbisBox.Name = "ItbisBox";
            this.ItbisBox.Size = new System.Drawing.Size(87, 20);
            this.ItbisBox.TabIndex = 24;
            // 
            // TotalBox
            // 
            this.TotalBox.Location = new System.Drawing.Point(372, 369);
            this.TotalBox.Name = "TotalBox";
            this.TotalBox.Size = new System.Drawing.Size(87, 20);
            this.TotalBox.TabIndex = 25;
            // 
            // NuevoBoton
            // 
            this.NuevoBoton.Location = new System.Drawing.Point(19, 343);
            this.NuevoBoton.Name = "NuevoBoton";
            this.NuevoBoton.Size = new System.Drawing.Size(75, 23);
            this.NuevoBoton.TabIndex = 26;
            this.NuevoBoton.Text = "Nuevo";
            this.NuevoBoton.UseVisualStyleBackColor = true;
            this.NuevoBoton.Click += new System.EventHandler(this.NuevoBoton_Click);
            // 
            // GuardarBoton
            // 
            this.GuardarBoton.Location = new System.Drawing.Point(114, 343);
            this.GuardarBoton.Name = "GuardarBoton";
            this.GuardarBoton.Size = new System.Drawing.Size(75, 23);
            this.GuardarBoton.TabIndex = 27;
            this.GuardarBoton.Text = "Guardar";
            this.GuardarBoton.UseVisualStyleBackColor = true;
            this.GuardarBoton.Click += new System.EventHandler(this.GuardarBoton_Click);
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Location = new System.Drawing.Point(215, 343);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(75, 23);
            this.EliminarBoton.TabIndex = 28;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.UseVisualStyleBackColor = true;
            this.EliminarBoton.Click += new System.EventHandler(this.EliminarBoton_Click);
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Location = new System.Drawing.Point(189, 9);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(75, 23);
            this.BuscarBoton.TabIndex = 29;
            this.BuscarBoton.Text = "Buscar";
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // CantidadNum
            // 
            this.CantidadNum.Location = new System.Drawing.Point(140, 163);
            this.CantidadNum.Name = "CantidadNum";
            this.CantidadNum.Size = new System.Drawing.Size(69, 20);
            this.CantidadNum.TabIndex = 30;
            this.CantidadNum.ValueChanged += new System.EventHandler(this.CantidadNum_ValueChanged);
            // 
            // RegistroMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 393);
            this.Controls.Add(this.CantidadNum);
            this.Controls.Add(this.BuscarBoton);
            this.Controls.Add(this.EliminarBoton);
            this.Controls.Add(this.GuardarBoton);
            this.Controls.Add(this.NuevoBoton);
            this.Controls.Add(this.TotalBox);
            this.Controls.Add(this.ItbisBox);
            this.Controls.Add(this.SubBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MantenimientoData);
            this.Controls.Add(this.ImporteBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AnadirBoton);
            this.Controls.Add(this.PrecioBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ArticuloCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TallerBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.VehiculocomboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProxFechadateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechadateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDnumericUpDown1);
            this.Controls.Add(this.label1);
            this.Name = "RegistroMantenimiento";
            this.Text = "RegistroMantenimiento";
            this.Load += new System.EventHandler(this.RegistroMantenimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MantenimientoData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ProxFechadateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox VehiculocomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TallerBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ArticuloCombo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PrecioBox;
        private System.Windows.Forms.Button AnadirBoton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ImporteBox;
        private System.Windows.Forms.DataGridView MantenimientoData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SubBox;
        private System.Windows.Forms.TextBox ItbisBox;
        private System.Windows.Forms.TextBox TotalBox;
        private System.Windows.Forms.Button NuevoBoton;
        private System.Windows.Forms.Button GuardarBoton;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.NumericUpDown CantidadNum;
    }
}