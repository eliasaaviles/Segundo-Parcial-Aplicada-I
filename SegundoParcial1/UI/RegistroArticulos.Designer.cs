namespace SegundoParcial1.UI
{
    partial class RegistroArticulos
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
            this.ArticuloIDNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.DescripcionBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CostoBox = new System.Windows.Forms.TextBox();
            this.GananciaBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PrecioBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InventarioBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.NuevoBoton = new System.Windows.Forms.Button();
            this.GuardarBoton = new System.Windows.Forms.Button();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloIDNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Articulo ID:";
            // 
            // ArticuloIDNum
            // 
            this.ArticuloIDNum.Location = new System.Drawing.Point(77, 12);
            this.ArticuloIDNum.Name = "ArticuloIDNum";
            this.ArticuloIDNum.Size = new System.Drawing.Size(63, 20);
            this.ArticuloIDNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion:";
            // 
            // DescripcionBox
            // 
            this.DescripcionBox.Location = new System.Drawing.Point(78, 51);
            this.DescripcionBox.Name = "DescripcionBox";
            this.DescripcionBox.Size = new System.Drawing.Size(225, 20);
            this.DescripcionBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Costo:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // CostoBox
            // 
            this.CostoBox.Location = new System.Drawing.Point(52, 90);
            this.CostoBox.Name = "CostoBox";
            this.CostoBox.Size = new System.Drawing.Size(65, 20);
            this.CostoBox.TabIndex = 5;
            this.CostoBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // GananciaBox
            // 
            this.GananciaBox.Location = new System.Drawing.Point(234, 90);
            this.GananciaBox.Name = "GananciaBox";
            this.GananciaBox.Size = new System.Drawing.Size(69, 20);
            this.GananciaBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Porciento Ganancia:";
            // 
            // PrecioBox
            // 
            this.PrecioBox.Location = new System.Drawing.Point(52, 116);
            this.PrecioBox.Name = "PrecioBox";
            this.PrecioBox.Size = new System.Drawing.Size(65, 20);
            this.PrecioBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Precio";
            // 
            // InventarioBox
            // 
            this.InventarioBox.Location = new System.Drawing.Point(254, 116);
            this.InventarioBox.Name = "InventarioBox";
            this.InventarioBox.ReadOnly = true;
            this.InventarioBox.Size = new System.Drawing.Size(49, 20);
            this.InventarioBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Disponible en Inventario:";
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Location = new System.Drawing.Point(153, 14);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(75, 23);
            this.BuscarBoton.TabIndex = 12;
            this.BuscarBoton.Text = "Buscar";
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // NuevoBoton
            // 
            this.NuevoBoton.Location = new System.Drawing.Point(15, 177);
            this.NuevoBoton.Name = "NuevoBoton";
            this.NuevoBoton.Size = new System.Drawing.Size(75, 23);
            this.NuevoBoton.TabIndex = 13;
            this.NuevoBoton.Text = "Nuevo";
            this.NuevoBoton.UseVisualStyleBackColor = true;
            this.NuevoBoton.Click += new System.EventHandler(this.NuevoBoton_Click);
            // 
            // GuardarBoton
            // 
            this.GuardarBoton.Location = new System.Drawing.Point(127, 177);
            this.GuardarBoton.Name = "GuardarBoton";
            this.GuardarBoton.Size = new System.Drawing.Size(75, 23);
            this.GuardarBoton.TabIndex = 14;
            this.GuardarBoton.Text = "Guardar";
            this.GuardarBoton.UseVisualStyleBackColor = true;
            this.GuardarBoton.Click += new System.EventHandler(this.GuardarBoton_Click);
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Location = new System.Drawing.Point(224, 177);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(75, 23);
            this.EliminarBoton.TabIndex = 15;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.UseVisualStyleBackColor = true;
            this.EliminarBoton.Click += new System.EventHandler(this.EliminarBoton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistroArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 212);
            this.Controls.Add(this.EliminarBoton);
            this.Controls.Add(this.GuardarBoton);
            this.Controls.Add(this.NuevoBoton);
            this.Controls.Add(this.BuscarBoton);
            this.Controls.Add(this.InventarioBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PrecioBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GananciaBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CostoBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescripcionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArticuloIDNum);
            this.Controls.Add(this.label1);
            this.Name = "RegistroArticulos";
            this.Text = "RegistroArticulos";
            this.Load += new System.EventHandler(this.RegistroArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloIDNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ArticuloIDNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescripcionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CostoBox;
        private System.Windows.Forms.TextBox GananciaBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrecioBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InventarioBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.Button NuevoBoton;
        private System.Windows.Forms.Button GuardarBoton;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}