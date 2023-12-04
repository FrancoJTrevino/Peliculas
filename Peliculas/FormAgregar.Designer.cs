
namespace Peliculas
{
    partial class FormAgregar
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
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(12, 12);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(146, 37);
            this.btnAuto.TabIndex = 2;
            this.btnAuto.Text = "Añadir Automáticamente";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            this.btnAuto.MouseEnter += new System.EventHandler(this.btnManual_MouseEnter);
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(164, 12);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(146, 37);
            this.btnManual.TabIndex = 3;
            this.btnManual.Text = "Añadir Manualmente";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            this.btnManual.MouseEnter += new System.EventHandler(this.btnManual_MouseEnter);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(9, 76);
            this.lblDescripcion.MaximumSize = new System.Drawing.Size(300, 100);
            this.lblDescripcion.MinimumSize = new System.Drawing.Size(300, 100);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(300, 100);
            this.lblDescripcion.TabIndex = 4;
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 160);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnAuto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgregar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Añadir Pelicula";
            this.Load += new System.EventHandler(this.FormAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Label lblDescripcion;
    }
}