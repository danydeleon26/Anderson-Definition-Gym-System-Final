namespace Anderson_Definition_Gym_System_Final.forms
{
    partial class formularioAgregar_ActualizarClientes
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fecha = new Telerik.WinControls.UI.RadDateTimePicker();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.edad = new System.Windows.Forms.TextBox();
            this.direccion2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sexo = new Telerik.WinControls.UI.RadDropDownList();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(21, 311);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 45);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.telefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.fecha);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.apellido);
            this.groupBox1.Controls.Add(this.edad);
            this.groupBox1.Controls.Add(this.direccion2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Direccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.sexo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 282);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar cliente";
            // 
            // telefono
            // 
            this.telefono.Location = new System.Drawing.Point(95, 203);
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(283, 22);
            this.telefono.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Telefono";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(164, 160);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(214, 24);
            this.fecha.TabIndex = 14;
            this.fecha.TabStop = false;
            this.fecha.Text = "Friday, March 30, 2018";
            this.fecha.Value = new System.DateTime(2018, 3, 30, 1, 13, 43, 508);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(93, 34);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(285, 22);
            this.nombre.TabIndex = 2;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(93, 65);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(285, 22);
            this.apellido.TabIndex = 3;
            // 
            // edad
            // 
            this.edad.Location = new System.Drawing.Point(95, 246);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(41, 22);
            this.edad.TabIndex = 4;
            // 
            // direccion2
            // 
            this.direccion2.Location = new System.Drawing.Point(93, 93);
            this.direccion2.Name = "direccion2";
            this.direccion2.Size = new System.Drawing.Size(285, 22);
            this.direccion2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha de inscripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido";
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(20, 96);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(67, 17);
            this.Direccion.TabIndex = 11;
            this.Direccion.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Edad";
            // 
            // sexo
            // 
            this.sexo.Location = new System.Drawing.Point(93, 121);
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Size = new System.Drawing.Size(285, 24);
            this.sexo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sexo";
            // 
            // btnCerrar
            // 
            this.btnCerrar.ForeColor = System.Drawing.Color.Red;
            this.btnCerrar.Location = new System.Drawing.Point(333, 311);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(97, 45);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // formularioAgregar_ActualizarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(900, 372);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCerrar);
            this.Name = "formularioAgregar_ActualizarClientes";
            this.Text = "formularioAgregar_ActualizarClientes";
            this.Load += new System.EventHandler(this.formularioAgregar_ActualizarClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label6;
        public Telerik.WinControls.UI.RadDateTimePicker fecha;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.TextBox direccion2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label label3;
        private Telerik.WinControls.UI.RadDropDownList sexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCerrar;
    }
}