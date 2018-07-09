namespace SegundoParcial1.UI
{
    partial class RegistroVehiculos
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
            this.VehiculoIDNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.DescripcionBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MantenimientoBox = new System.Windows.Forms.TextBox();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.NuevoBoton = new System.Windows.Forms.Button();
            this.GuardarBoton = new System.Windows.Forms.Button();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.VehiculoIDNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehiculo ID:";
            // 
            // VehiculoIDNum
            // 
            this.VehiculoIDNum.Location = new System.Drawing.Point(83, 9);
            this.VehiculoIDNum.Name = "VehiculoIDNum";
            this.VehiculoIDNum.Size = new System.Drawing.Size(61, 20);
            this.VehiculoIDNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripccion:";
            // 
            // DescripcionBox
            // 
            this.DescripcionBox.AcceptsTab = true;
            this.DescripcionBox.Location = new System.Drawing.Point(78, 55);
            this.DescripcionBox.Name = "DescripcionBox";
            this.DescripcionBox.Size = new System.Drawing.Size(199, 20);
            this.DescripcionBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Toltal Mantenimiento:";
            // 
            // MantenimientoBox
            // 
            this.MantenimientoBox.Location = new System.Drawing.Point(119, 90);
            this.MantenimientoBox.Name = "MantenimientoBox";
            this.MantenimientoBox.ReadOnly = true;
            this.MantenimientoBox.Size = new System.Drawing.Size(63, 20);
            this.MantenimientoBox.TabIndex = 5;
            this.MantenimientoBox.TextChanged += new System.EventHandler(this.MantenimientoBox_TextChanged);
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Location = new System.Drawing.Point(163, 9);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(75, 23);
            this.BuscarBoton.TabIndex = 6;
            this.BuscarBoton.Text = "Buscar";
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // NuevoBoton
            // 
            this.NuevoBoton.Location = new System.Drawing.Point(15, 140);
            this.NuevoBoton.Name = "NuevoBoton";
            this.NuevoBoton.Size = new System.Drawing.Size(75, 23);
            this.NuevoBoton.TabIndex = 7;
            this.NuevoBoton.Text = "Nuevo";
            this.NuevoBoton.UseVisualStyleBackColor = true;
            this.NuevoBoton.Click += new System.EventHandler(this.NuevoBoton_Click);
            // 
            // GuardarBoton
            // 
            this.GuardarBoton.Location = new System.Drawing.Point(107, 140);
            this.GuardarBoton.Name = "GuardarBoton";
            this.GuardarBoton.Size = new System.Drawing.Size(75, 23);
            this.GuardarBoton.TabIndex = 8;
            this.GuardarBoton.Text = "Guardar";
            this.GuardarBoton.UseVisualStyleBackColor = true;
            this.GuardarBoton.Click += new System.EventHandler(this.GuardarBoton_Click);
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Location = new System.Drawing.Point(202, 140);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(75, 23);
            this.EliminarBoton.TabIndex = 9;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.UseVisualStyleBackColor = true;
            this.EliminarBoton.Click += new System.EventHandler(this.EliminarBoton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistroVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 175);
            this.Controls.Add(this.EliminarBoton);
            this.Controls.Add(this.GuardarBoton);
            this.Controls.Add(this.NuevoBoton);
            this.Controls.Add(this.BuscarBoton);
            this.Controls.Add(this.MantenimientoBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescripcionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VehiculoIDNum);
            this.Controls.Add(this.label1);
            this.Name = "RegistroVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Vehiculos";
            this.Load += new System.EventHandler(this.RegistroVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VehiculoIDNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown VehiculoIDNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescripcionBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MantenimientoBox;
        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.Button NuevoBoton;
        private System.Windows.Forms.Button GuardarBoton;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}