namespace SegundoParcial.UI.Registro
{
    partial class RegistroPersona
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
            this.IDNum = new System.Windows.Forms.NumericUpDown();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaPicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DireccionBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TelefonoBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CedulaBox = new System.Windows.Forms.MaskedTextBox();
            this.NuevoBoton = new System.Windows.Forms.Button();
            this.GuardarBoton = new System.Windows.Forms.Button();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Persona:";
            // 
            // IDNum
            // 
            this.IDNum.Location = new System.Drawing.Point(81, 22);
            this.IDNum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.IDNum.Name = "IDNum";
            this.IDNum.Size = new System.Drawing.Size(57, 20);
            this.IDNum.TabIndex = 1;
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Location = new System.Drawing.Point(186, 22);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(75, 23);
            this.BuscarBoton.TabIndex = 2;
            this.BuscarBoton.Text = "Buscar";
            this.BuscarBoton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // FechaPicker
            // 
            this.FechaPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaPicker.Location = new System.Drawing.Point(81, 64);
            this.FechaPicker.Name = "FechaPicker";
            this.FechaPicker.Size = new System.Drawing.Size(96, 20);
            this.FechaPicker.TabIndex = 4;
            this.FechaPicker.Value = new System.DateTime(2018, 7, 2, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombres:";
            // 
            // NombreBox
            // 
            this.NombreBox.Location = new System.Drawing.Point(81, 102);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(180, 20);
            this.NombreBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccion:";
            // 
            // DireccionBox
            // 
            this.DireccionBox.Location = new System.Drawing.Point(81, 144);
            this.DireccionBox.Name = "DireccionBox";
            this.DireccionBox.Size = new System.Drawing.Size(180, 20);
            this.DireccionBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefono:";
            // 
            // TelefonoBox
            // 
            this.TelefonoBox.Location = new System.Drawing.Point(77, 190);
            this.TelefonoBox.Mask = "000-000-0000";
            this.TelefonoBox.Name = "TelefonoBox";
            this.TelefonoBox.Size = new System.Drawing.Size(74, 20);
            this.TelefonoBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cedula:";
            // 
            // CedulaBox
            // 
            this.CedulaBox.Location = new System.Drawing.Point(235, 193);
            this.CedulaBox.Mask = "000-0000000-0";
            this.CedulaBox.Name = "CedulaBox";
            this.CedulaBox.Size = new System.Drawing.Size(81, 20);
            this.CedulaBox.TabIndex = 12;
            // 
            // NuevoBoton
            // 
            this.NuevoBoton.Location = new System.Drawing.Point(21, 278);
            this.NuevoBoton.Name = "NuevoBoton";
            this.NuevoBoton.Size = new System.Drawing.Size(75, 23);
            this.NuevoBoton.TabIndex = 13;
            this.NuevoBoton.Text = "Nuevo";
            this.NuevoBoton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoBoton.UseVisualStyleBackColor = true;
            this.NuevoBoton.Click += new System.EventHandler(this.NuevoBoton_Click);
            // 
            // GuardarBoton
            // 
            this.GuardarBoton.Location = new System.Drawing.Point(131, 278);
            this.GuardarBoton.Name = "GuardarBoton";
            this.GuardarBoton.Size = new System.Drawing.Size(75, 23);
            this.GuardarBoton.TabIndex = 14;
            this.GuardarBoton.Text = "Guardar";
            this.GuardarBoton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarBoton.UseVisualStyleBackColor = true;
            this.GuardarBoton.Click += new System.EventHandler(this.GuardarBoton_Click);
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Location = new System.Drawing.Point(241, 277);
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
            // RegistroPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 330);
            this.Controls.Add(this.EliminarBoton);
            this.Controls.Add(this.GuardarBoton);
            this.Controls.Add(this.NuevoBoton);
            this.Controls.Add(this.CedulaBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TelefonoBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DireccionBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NombreBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BuscarBoton);
            this.Controls.Add(this.IDNum);
            this.Controls.Add(this.label1);
            this.Name = "RegistroPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistroPersona";
            this.Load += new System.EventHandler(this.RegistroPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IDNum;
        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DireccionBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox TelefonoBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox CedulaBox;
        private System.Windows.Forms.Button NuevoBoton;
        private System.Windows.Forms.Button GuardarBoton;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}