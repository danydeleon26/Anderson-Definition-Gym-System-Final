﻿namespace Anderson_Definition_Gym_System_Final
{
    partial class formularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buscarNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.Size = new System.Drawing.Size(927, 152);
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "Form1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(175, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(740, 395);
            this.dataGridView1.TabIndex = 1;
            // 
            // buscarNombre
            // 
            this.buscarNombre.Location = new System.Drawing.Point(175, 168);
            this.buscarNombre.Name = "buscarNombre";
            this.buscarNombre.Size = new System.Drawing.Size(314, 22);
            this.buscarNombre.TabIndex = 2;
            this.buscarNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // formularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(927, 603);
            this.Controls.Add(this.buscarNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radRibbonBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formularioPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formularioPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox buscarNombre;
    }
}

