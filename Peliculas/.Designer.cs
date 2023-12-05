
namespace Peliculas
{
    partial class FormPelicula
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblClasificacion = new System.Windows.Forms.Label();
            this.lblPuntuacionIMDB = new System.Windows.Forms.Label();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.lblGeneros = new System.Windows.Forms.Label();
            this.lblDuración = new System.Windows.Forms.Label();
            this.wbTrailer = new System.Windows.Forms.WebBrowser();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblOpinion = new System.Windows.Forms.Label();
            this.lblPuntuacionUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReparto = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(445, 76);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título Película";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(478, 22);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(45, 20);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "9999";
            // 
            // lblClasificacion
            // 
            this.lblClasificacion.AutoSize = true;
            this.lblClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasificacion.Location = new System.Drawing.Point(597, 22);
            this.lblClasificacion.Name = "lblClasificacion";
            this.lblClasificacion.Size = new System.Drawing.Size(55, 20);
            this.lblClasificacion.TabIndex = 2;
            this.lblClasificacion.Text = "PG-13";
            // 
            // lblPuntuacionIMDB
            // 
            this.lblPuntuacionIMDB.AutoSize = true;
            this.lblPuntuacionIMDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntuacionIMDB.Location = new System.Drawing.Point(478, 55);
            this.lblPuntuacionIMDB.Name = "lblPuntuacionIMDB";
            this.lblPuntuacionIMDB.Size = new System.Drawing.Size(27, 20);
            this.lblPuntuacionIMDB.TabIndex = 3;
            this.lblPuntuacionIMDB.Text = "10";
            // 
            // pbPoster
            // 
            this.pbPoster.Location = new System.Drawing.Point(25, 88);
            this.pbPoster.MaximumSize = new System.Drawing.Size(432, 581);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(432, 581);
            this.pbPoster.TabIndex = 4;
            this.pbPoster.TabStop = false;
            // 
            // lblGeneros
            // 
            this.lblGeneros.AutoSize = true;
            this.lblGeneros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneros.Location = new System.Drawing.Point(658, 22);
            this.lblGeneros.Name = "lblGeneros";
            this.lblGeneros.Size = new System.Drawing.Size(206, 20);
            this.lblGeneros.TabIndex = 5;
            this.lblGeneros.Text = "Genero1 Genero2 Genero3";
            // 
            // lblDuración
            // 
            this.lblDuración.AutoSize = true;
            this.lblDuración.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuración.Location = new System.Drawing.Point(529, 22);
            this.lblDuración.Name = "lblDuración";
            this.lblDuración.Size = new System.Drawing.Size(62, 20);
            this.lblDuración.TabIndex = 6;
            this.lblDuración.Text = "3h 59m";
            // 
            // wbTrailer
            // 
            this.wbTrailer.Location = new System.Drawing.Point(482, 223);
            this.wbTrailer.Name = "wbTrailer";
            this.wbTrailer.ScrollBarsEnabled = false;
            this.wbTrailer.Size = new System.Drawing.Size(480, 270);
            this.wbTrailer.TabIndex = 7;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(478, 88);
            this.lblDescripcion.MaximumSize = new System.Drawing.Size(480, 120);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(78, 20);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Resumen";
            // 
            // lblOpinion
            // 
            this.lblOpinion.AutoSize = true;
            this.lblOpinion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpinion.Location = new System.Drawing.Point(478, 518);
            this.lblOpinion.MaximumSize = new System.Drawing.Size(480, 120);
            this.lblOpinion.Name = "lblOpinion";
            this.lblOpinion.Size = new System.Drawing.Size(122, 20);
            this.lblOpinion.TabIndex = 9;
            this.lblOpinion.Text = "Opinion Usuario";
            // 
            // lblPuntuacionUsuario
            // 
            this.lblPuntuacionUsuario.AutoSize = true;
            this.lblPuntuacionUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntuacionUsuario.Location = new System.Drawing.Point(478, 649);
            this.lblPuntuacionUsuario.Name = "lblPuntuacionUsuario";
            this.lblPuntuacionUsuario.Size = new System.Drawing.Size(27, 20);
            this.lblPuntuacionUsuario.TabIndex = 10;
            this.lblPuntuacionUsuario.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(968, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reparto:";
            // 
            // lblReparto
            // 
            this.lblReparto.AutoSize = true;
            this.lblReparto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReparto.Location = new System.Drawing.Point(970, 65);
            this.lblReparto.Name = "lblReparto";
            this.lblReparto.Size = new System.Drawing.Size(92, 20);
            this.lblReparto.TabIndex = 12;
            this.lblReparto.Text = "Personajes:";
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditar.Location = new System.Drawing.Point(1149, 644);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 32);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar Pelicula";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FormPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblReparto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPuntuacionUsuario);
            this.Controls.Add(this.lblOpinion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.wbTrailer);
            this.Controls.Add(this.lblDuración);
            this.Controls.Add(this.lblGeneros);
            this.Controls.Add(this.pbPoster);
            this.Controls.Add(this.lblPuntuacionIMDB);
            this.Controls.Add(this.lblClasificacion);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FormPelicula";
            this.Load += new System.EventHandler(this.FormPelicula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblClasificacion;
        private System.Windows.Forms.Label lblPuntuacionIMDB;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Label lblGeneros;
        private System.Windows.Forms.Label lblDuración;
        private System.Windows.Forms.WebBrowser wbTrailer;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblOpinion;
        private System.Windows.Forms.Label lblPuntuacionUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReparto;
        private System.Windows.Forms.Button btnEditar;
    }
}

