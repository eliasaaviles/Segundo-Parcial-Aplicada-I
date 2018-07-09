namespace SegundoParcial.UI.Registro
{
    partial class RegistroCotizacion
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label visitaIdLabel;
            this.TotalNum = new System.Windows.Forms.NumericUpDown();
            this.ObservacionBox = new System.Windows.Forms.TextBox();
            this.DetalledataGridView = new System.Windows.Forms.DataGridView();
            this.ImporteBox = new System.Windows.Forms.TextBox();
            this.PrecioBox = new System.Windows.Forms.TextBox();
            this.ArticuloCombo = new System.Windows.Forms.ComboBox();
            this.CantidadBox = new System.Windows.Forms.TextBox();
            this.PersonaCombo = new System.Windows.Forms.ComboBox();
            this.IDCotNum = new System.Windows.Forms.NumericUpDown();
            this.FechaPicker = new System.Windows.Forms.DateTimePicker();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.AgregarBoton = new System.Windows.Forms.Button();
            this.NuevoBoton = new System.Windows.Forms.Button();
            this.GuardarBoton = new System.Windows.Forms.Button();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            visitaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TotalNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDCotNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalNum
            // 
            this.TotalNum.Location = new System.Drawing.Point(513, 330);
            this.TotalNum.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.TotalNum.Name = "TotalNum";
            this.TotalNum.ReadOnly = true;
            this.TotalNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TotalNum.Size = new System.Drawing.Size(108, 20);
            this.TotalNum.TabIndex = 109;
            this.TotalNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(474, 337);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(34, 13);
            label7.TabIndex = 108;
            label7.Text = "Total:";
            // 
            // ObservacionBox
            // 
            this.ObservacionBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObservacionBox.Location = new System.Drawing.Point(14, 330);
            this.ObservacionBox.Margin = new System.Windows.Forms.Padding(2);
            this.ObservacionBox.MaxLength = 100;
            this.ObservacionBox.Multiline = true;
            this.ObservacionBox.Name = "ObservacionBox";
            this.ObservacionBox.Size = new System.Drawing.Size(271, 109);
            this.ObservacionBox.TabIndex = 92;
            // 
            // label6
            // 
            label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(11, 315);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(78, 13);
            label6.TabIndex = 107;
            label6.Text = "Observaciones";
            // 
            // DetalledataGridView
            // 
            this.DetalledataGridView.AllowUserToAddRows = false;
            this.DetalledataGridView.AllowUserToDeleteRows = false;
            this.DetalledataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DetalledataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DetalledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView.Location = new System.Drawing.Point(11, 116);
            this.DetalledataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DetalledataGridView.Name = "DetalledataGridView";
            this.DetalledataGridView.ReadOnly = true;
            this.DetalledataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DetalledataGridView.Size = new System.Drawing.Size(611, 196);
            this.DetalledataGridView.TabIndex = 91;
            // 
            // ImporteBox
            // 
            this.ImporteBox.Location = new System.Drawing.Point(334, 88);
            this.ImporteBox.Name = "ImporteBox";
            this.ImporteBox.Size = new System.Drawing.Size(100, 20);
            this.ImporteBox.TabIndex = 106;
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(331, 71);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(45, 13);
            label5.TabIndex = 105;
            label5.Text = "Importe:";
            label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PrecioBox
            // 
            this.PrecioBox.Location = new System.Drawing.Point(228, 88);
            this.PrecioBox.Name = "PrecioBox";
            this.PrecioBox.Size = new System.Drawing.Size(100, 20);
            this.PrecioBox.TabIndex = 104;
            this.PrecioBox.TextChanged += new System.EventHandler(this.PrecioBox_TextChanged);
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(225, 71);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 13);
            label4.TabIndex = 103;
            label4.Text = "Precio:";
            label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(120, 71);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 13);
            label2.TabIndex = 102;
            label2.Text = "Cantidad:";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ArticuloCombo
            // 
            this.ArticuloCombo.FormattingEnabled = true;
            this.ArticuloCombo.Location = new System.Drawing.Point(11, 87);
            this.ArticuloCombo.Name = "ArticuloCombo";
            this.ArticuloCombo.Size = new System.Drawing.Size(100, 21);
            this.ArticuloCombo.TabIndex = 101;
            // 
            // CantidadBox
            // 
            this.CantidadBox.Location = new System.Drawing.Point(123, 88);
            this.CantidadBox.Name = "CantidadBox";
            this.CantidadBox.Size = new System.Drawing.Size(99, 20);
            this.CantidadBox.TabIndex = 100;
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(11, 71);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(45, 13);
            label1.TabIndex = 99;
            label1.Text = "Articulo:";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PersonaCombo
            // 
            this.PersonaCombo.FormattingEnabled = true;
            this.PersonaCombo.Location = new System.Drawing.Point(65, 42);
            this.PersonaCombo.Name = "PersonaCombo";
            this.PersonaCombo.Size = new System.Drawing.Size(452, 21);
            this.PersonaCombo.TabIndex = 98;
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 50);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 13);
            label3.TabIndex = 97;
            label3.Text = "Persona:";
            label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // IDCotNum
            // 
            this.IDCotNum.Location = new System.Drawing.Point(78, 16);
            this.IDCotNum.Name = "IDCotNum";
            this.IDCotNum.Size = new System.Drawing.Size(72, 20);
            this.IDCotNum.TabIndex = 96;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(326, 19);
            fechaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 94;
            fechaLabel.Text = "Fecha:";
            // 
            // FechaPicker
            // 
            this.FechaPicker.CustomFormat = "dd/MM/yyyy";
            this.FechaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaPicker.Location = new System.Drawing.Point(374, 16);
            this.FechaPicker.Margin = new System.Windows.Forms.Padding(2);
            this.FechaPicker.Name = "FechaPicker";
            this.FechaPicker.Size = new System.Drawing.Size(143, 20);
            this.FechaPicker.TabIndex = 95;
            // 
            // visitaIdLabel
            // 
            visitaIdLabel.AutoSize = true;
            visitaIdLabel.Location = new System.Drawing.Point(5, 22);
            visitaIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            visitaIdLabel.Name = "visitaIdLabel";
            visitaIdLabel.Size = new System.Drawing.Size(68, 13);
            visitaIdLabel.TabIndex = 93;
            visitaIdLabel.Text = "CotizacionId:";
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Location = new System.Drawing.Point(156, 13);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(75, 23);
            this.BuscarBoton.TabIndex = 110;
            this.BuscarBoton.Text = "Buscar";
            this.BuscarBoton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // AgregarBoton
            // 
            this.AgregarBoton.Location = new System.Drawing.Point(477, 87);
            this.AgregarBoton.Name = "AgregarBoton";
            this.AgregarBoton.Size = new System.Drawing.Size(75, 23);
            this.AgregarBoton.TabIndex = 111;
            this.AgregarBoton.Text = "Agregar";
            this.AgregarBoton.UseVisualStyleBackColor = true;
            this.AgregarBoton.Click += new System.EventHandler(this.AgregarBoton_Click);
            // 
            // NuevoBoton
            // 
            this.NuevoBoton.Location = new System.Drawing.Point(334, 337);
            this.NuevoBoton.Name = "NuevoBoton";
            this.NuevoBoton.Size = new System.Drawing.Size(75, 23);
            this.NuevoBoton.TabIndex = 112;
            this.NuevoBoton.Text = "Nuevo";
            this.NuevoBoton.UseVisualStyleBackColor = true;
            this.NuevoBoton.Click += new System.EventHandler(this.NuevoBoton_Click);
            // 
            // GuardarBoton
            // 
            this.GuardarBoton.Location = new System.Drawing.Point(334, 376);
            this.GuardarBoton.Name = "GuardarBoton";
            this.GuardarBoton.Size = new System.Drawing.Size(75, 23);
            this.GuardarBoton.TabIndex = 113;
            this.GuardarBoton.Text = "Guardar";
            this.GuardarBoton.UseVisualStyleBackColor = true;
            this.GuardarBoton.Click += new System.EventHandler(this.GuardarBoton_Click);
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Location = new System.Drawing.Point(334, 416);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(75, 23);
            this.EliminarBoton.TabIndex = 114;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.UseVisualStyleBackColor = true;
            this.EliminarBoton.Click += new System.EventHandler(this.EliminarBoton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistroCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.EliminarBoton);
            this.Controls.Add(this.GuardarBoton);
            this.Controls.Add(this.NuevoBoton);
            this.Controls.Add(this.AgregarBoton);
            this.Controls.Add(this.BuscarBoton);
            this.Controls.Add(this.TotalNum);
            this.Controls.Add(label7);
            this.Controls.Add(this.ObservacionBox);
            this.Controls.Add(label6);
            this.Controls.Add(this.DetalledataGridView);
            this.Controls.Add(this.ImporteBox);
            this.Controls.Add(label5);
            this.Controls.Add(this.PrecioBox);
            this.Controls.Add(label4);
            this.Controls.Add(label2);
            this.Controls.Add(this.ArticuloCombo);
            this.Controls.Add(this.CantidadBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.PersonaCombo);
            this.Controls.Add(label3);
            this.Controls.Add(this.IDCotNum);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.FechaPicker);
            this.Controls.Add(visitaIdLabel);
            this.Name = "RegistroCotizacion";
            this.Text = "RegistroCotizacion";
            this.Load += new System.EventHandler(this.RegistroCotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TotalNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDCotNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown TotalNum;
        private System.Windows.Forms.TextBox ObservacionBox;
        private System.Windows.Forms.DataGridView DetalledataGridView;
        private System.Windows.Forms.TextBox ImporteBox;
        private System.Windows.Forms.TextBox PrecioBox;
        private System.Windows.Forms.ComboBox ArticuloCombo;
        private System.Windows.Forms.TextBox CantidadBox;
        private System.Windows.Forms.ComboBox PersonaCombo;
        private System.Windows.Forms.NumericUpDown IDCotNum;
        private System.Windows.Forms.DateTimePicker FechaPicker;
        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.Button AgregarBoton;
        private System.Windows.Forms.Button NuevoBoton;
        private System.Windows.Forms.Button GuardarBoton;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}