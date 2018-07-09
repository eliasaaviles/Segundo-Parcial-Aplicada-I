namespace SegundoParcial.UI.Registro
{
    partial class RegistroProducto
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
            this.CantidadCotizadaBox = new System.Windows.Forms.TextBox();
            this.VencimientoPicker = new System.Windows.Forms.DateTimePicker();
            this.DescripcionBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.PrecioNum = new System.Windows.Forms.NumericUpDown();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.NuevoBoton = new System.Windows.Forms.Button();
            this.GuardarBoton = new System.Windows.Forms.Button();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CantidadCotizadaBox
            // 
            this.CantidadCotizadaBox.Location = new System.Drawing.Point(140, 205);
            this.CantidadCotizadaBox.Name = "CantidadCotizadaBox";
            this.CantidadCotizadaBox.Size = new System.Drawing.Size(189, 20);
            this.CantidadCotizadaBox.TabIndex = 52;
            // 
            // VencimientoPicker
            // 
            this.VencimientoPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VencimientoPicker.Location = new System.Drawing.Point(140, 167);
            this.VencimientoPicker.MinDate = new System.DateTime(2018, 5, 26, 0, 0, 0, 0);
            this.VencimientoPicker.Name = "VencimientoPicker";
            this.VencimientoPicker.Size = new System.Drawing.Size(189, 20);
            this.VencimientoPicker.TabIndex = 51;
            this.VencimientoPicker.Value = new System.DateTime(2018, 7, 2, 0, 0, 0, 0);
            // 
            // DescripcionBox
            // 
            this.DescripcionBox.Location = new System.Drawing.Point(140, 99);
            this.DescripcionBox.Name = "DescripcionBox";
            this.DescripcionBox.Size = new System.Drawing.Size(189, 20);
            this.DescripcionBox.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Cantidad Cotizada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Fecha de vencimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Descripcion";
            // 
            // IDNum
            // 
            this.IDNum.Location = new System.Drawing.Point(56, 34);
            this.IDNum.Name = "IDNum";
            this.IDNum.Size = new System.Drawing.Size(35, 20);
            this.IDNum.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "ID";
            // 
            // PrecioNum
            // 
            this.PrecioNum.Location = new System.Drawing.Point(140, 132);
            this.PrecioNum.Name = "PrecioNum";
            this.PrecioNum.Size = new System.Drawing.Size(189, 20);
            this.PrecioNum.TabIndex = 56;
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Location = new System.Drawing.Point(151, 30);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(75, 23);
            this.BuscarBoton.TabIndex = 57;
            this.BuscarBoton.Text = "Buscar";
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // NuevoBoton
            // 
            this.NuevoBoton.Location = new System.Drawing.Point(140, 284);
            this.NuevoBoton.Name = "NuevoBoton";
            this.NuevoBoton.Size = new System.Drawing.Size(75, 23);
            this.NuevoBoton.TabIndex = 58;
            this.NuevoBoton.Text = "Nuevo";
            this.NuevoBoton.UseVisualStyleBackColor = true;
            this.NuevoBoton.Click += new System.EventHandler(this.button2_Click);
            // 
            // GuardarBoton
            // 
            this.GuardarBoton.Location = new System.Drawing.Point(26, 284);
            this.GuardarBoton.Name = "GuardarBoton";
            this.GuardarBoton.Size = new System.Drawing.Size(75, 23);
            this.GuardarBoton.TabIndex = 59;
            this.GuardarBoton.Text = "Guardar";
            this.GuardarBoton.UseVisualStyleBackColor = true;
            this.GuardarBoton.Click += new System.EventHandler(this.button3_Click);
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Location = new System.Drawing.Point(254, 284);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(75, 23);
            this.EliminarBoton.TabIndex = 60;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.UseVisualStyleBackColor = true;
            this.EliminarBoton.Click += new System.EventHandler(this.button4_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistroProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 378);
            this.Controls.Add(this.EliminarBoton);
            this.Controls.Add(this.GuardarBoton);
            this.Controls.Add(this.NuevoBoton);
            this.Controls.Add(this.BuscarBoton);
            this.Controls.Add(this.CantidadCotizadaBox);
            this.Controls.Add(this.VencimientoPicker);
            this.Controls.Add(this.DescripcionBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrecioNum);
            this.Name = "RegistroProducto";
            this.Text = "RegistroProducto";
            this.Load += new System.EventHandler(this.RegistroProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox CantidadCotizadaBox;
        private System.Windows.Forms.DateTimePicker VencimientoPicker;
        private System.Windows.Forms.TextBox DescripcionBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown IDNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown PrecioNum;
        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.Button NuevoBoton;
        private System.Windows.Forms.Button GuardarBoton;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}