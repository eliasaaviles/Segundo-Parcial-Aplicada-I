namespace SegundoParcial1.UI
{
    partial class RegistroEntradaArticulos
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
            this.label1 = new System.Windows.Forms.Label();
            this.EntradaIDNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ArticuloComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CantidadBox = new System.Windows.Forms.TextBox();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.NuevoBoton = new System.Windows.Forms.Button();
            this.GuardarBoton = new System.Windows.Forms.Button();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EntradaIDNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrada De Articulos ID:";
            // 
            // EntradaIDNum
            // 
            this.EntradaIDNum.Location = new System.Drawing.Point(140, 11);
            this.EntradaIDNum.Name = "EntradaIDNum";
            this.EntradaIDNum.Size = new System.Drawing.Size(59, 20);
            this.EntradaIDNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha: ";
            // 
            // FechaPicker
            // 
            this.FechaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaPicker.Location = new System.Drawing.Point(111, 50);
            this.FechaPicker.Name = "FechaPicker";
            this.FechaPicker.Size = new System.Drawing.Size(99, 20);
            this.FechaPicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Articulo:";
            // 
            // ArticuloComboBox
            // 
            this.ArticuloComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ArticuloComboBox.FormattingEnabled = true;
            this.ArticuloComboBox.Items.AddRange(new object[] {
            "                      "});
            this.ArticuloComboBox.Location = new System.Drawing.Point(65, 86);
            this.ArticuloComboBox.Name = "ArticuloComboBox";
            this.ArticuloComboBox.Size = new System.Drawing.Size(234, 21);
            this.ArticuloComboBox.TabIndex = 5;
            this.ArticuloComboBox.SelectedIndexChanged += new System.EventHandler(this.ArticuloBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad:";
            // 
            // CantidadBox
            // 
            this.CantidadBox.Location = new System.Drawing.Point(71, 133);
            this.CantidadBox.Name = "CantidadBox";
            this.CantidadBox.Size = new System.Drawing.Size(69, 20);
            this.CantidadBox.TabIndex = 7;
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Location = new System.Drawing.Point(224, 11);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(75, 23);
            this.BuscarBoton.TabIndex = 8;
            this.BuscarBoton.Text = "Buscar";
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // NuevoBoton
            // 
            this.NuevoBoton.Location = new System.Drawing.Point(16, 176);
            this.NuevoBoton.Name = "NuevoBoton";
            this.NuevoBoton.Size = new System.Drawing.Size(75, 23);
            this.NuevoBoton.TabIndex = 9;
            this.NuevoBoton.Text = "Nuevo";
            this.NuevoBoton.UseVisualStyleBackColor = true;
            this.NuevoBoton.Click += new System.EventHandler(this.NuevoBoton_Click);
            // 
            // GuardarBoton
            // 
            this.GuardarBoton.Location = new System.Drawing.Point(124, 176);
            this.GuardarBoton.Name = "GuardarBoton";
            this.GuardarBoton.Size = new System.Drawing.Size(75, 23);
            this.GuardarBoton.TabIndex = 10;
            this.GuardarBoton.Text = "Guardar";
            this.GuardarBoton.UseVisualStyleBackColor = true;
            this.GuardarBoton.Click += new System.EventHandler(this.GuardarBoton_Click);
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Location = new System.Drawing.Point(224, 175);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(75, 23);
            this.EliminarBoton.TabIndex = 11;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.UseVisualStyleBackColor = true;
            this.EliminarBoton.Click += new System.EventHandler(this.EliminarBoton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistroEntradaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 204);
            this.Controls.Add(this.EliminarBoton);
            this.Controls.Add(this.GuardarBoton);
            this.Controls.Add(this.NuevoBoton);
            this.Controls.Add(this.BuscarBoton);
            this.Controls.Add(this.CantidadBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ArticuloComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EntradaIDNum);
            this.Controls.Add(this.label1);
            this.Name = "RegistroEntradaArticulos";
            this.Text = "RegistroEntradaArticulos";
            this.Load += new System.EventHandler(this.RegistroEntradaArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EntradaIDNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown EntradaIDNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ArticuloComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CantidadBox;
        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.Button NuevoBoton;
        private System.Windows.Forms.Button GuardarBoton;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}