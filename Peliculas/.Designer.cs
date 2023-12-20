
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
            this.lblGeneros = new System.Windows.Forms.Label();
            this.lblDuración = new System.Windows.Forms.Label();
            this.wbTrailer = new System.Windows.Forms.WebBrowser();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblOpinion = new System.Windows.Forms.Label();
            this.lblPuntuacionUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReparto = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pnStars = new System.Windows.Forms.Panel();
            this.pbStar10 = new System.Windows.Forms.PictureBox();
            this.pbStar9 = new System.Windows.Forms.PictureBox();
            this.pbStar8 = new System.Windows.Forms.PictureBox();
            this.pbStar7 = new System.Windows.Forms.PictureBox();
            this.pbStar6 = new System.Windows.Forms.PictureBox();
            this.pbStar5 = new System.Windows.Forms.PictureBox();
            this.pbStar4 = new System.Windows.Forms.PictureBox();
            this.pbStar3 = new System.Windows.Forms.PictureBox();
            this.pbStar2 = new System.Windows.Forms.PictureBox();
            this.pbStar1 = new System.Windows.Forms.PictureBox();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.pnStars2 = new System.Windows.Forms.Panel();
            this.pbStar20 = new System.Windows.Forms.PictureBox();
            this.pbStar19 = new System.Windows.Forms.PictureBox();
            this.pbStar18 = new System.Windows.Forms.PictureBox();
            this.pbStar17 = new System.Windows.Forms.PictureBox();
            this.pbStar16 = new System.Windows.Forms.PictureBox();
            this.pbStar15 = new System.Windows.Forms.PictureBox();
            this.pbStar14 = new System.Windows.Forms.PictureBox();
            this.pbStar13 = new System.Windows.Forms.PictureBox();
            this.pbStar12 = new System.Windows.Forms.PictureBox();
            this.pbStar11 = new System.Windows.Forms.PictureBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pnStars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            this.pnStars2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar11)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F);
            this.lblTitulo.Location = new System.Drawing.Point(25, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(432, 65);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título Película";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lblPuntuacionIMDB.Visible = false;
            // 
            // lblGeneros
            // 
            this.lblGeneros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneros.Location = new System.Drawing.Point(658, 22);
            this.lblGeneros.Name = "lblGeneros";
            this.lblGeneros.Size = new System.Drawing.Size(306, 20);
            this.lblGeneros.TabIndex = 5;
            this.lblGeneros.Text = "Genero1 Genero2 Genero3 Genero 4";
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
            this.lblPuntuacionUsuario.Visible = false;
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
            // pnStars
            // 
            this.pnStars.Controls.Add(this.pbStar10);
            this.pnStars.Controls.Add(this.pbStar9);
            this.pnStars.Controls.Add(this.pbStar8);
            this.pnStars.Controls.Add(this.pbStar7);
            this.pnStars.Controls.Add(this.pbStar6);
            this.pnStars.Controls.Add(this.pbStar5);
            this.pnStars.Controls.Add(this.pbStar4);
            this.pnStars.Controls.Add(this.pbStar3);
            this.pnStars.Controls.Add(this.pbStar2);
            this.pnStars.Controls.Add(this.pbStar1);
            this.pnStars.Location = new System.Drawing.Point(482, 49);
            this.pnStars.Name = "pnStars";
            this.pnStars.Size = new System.Drawing.Size(297, 36);
            this.pnStars.TabIndex = 14;
            // 
            // pbStar10
            // 
            this.pbStar10.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar10.Location = new System.Drawing.Point(264, 3);
            this.pbStar10.Name = "pbStar10";
            this.pbStar10.Size = new System.Drawing.Size(30, 30);
            this.pbStar10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar10.TabIndex = 9;
            this.pbStar10.TabStop = false;
            this.pbStar10.MouseHover += new System.EventHandler(this.pbStar1_MouseHover);
            // 
            // pbStar9
            // 
            this.pbStar9.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar9.Location = new System.Drawing.Point(235, 3);
            this.pbStar9.Name = "pbStar9";
            this.pbStar9.Size = new System.Drawing.Size(30, 30);
            this.pbStar9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar9.TabIndex = 8;
            this.pbStar9.TabStop = false;
            this.pbStar9.MouseHover += new System.EventHandler(this.pbStar1_MouseHover);
            // 
            // pbStar8
            // 
            this.pbStar8.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar8.Location = new System.Drawing.Point(206, 3);
            this.pbStar8.Name = "pbStar8";
            this.pbStar8.Size = new System.Drawing.Size(30, 30);
            this.pbStar8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar8.TabIndex = 7;
            this.pbStar8.TabStop = false;
            this.pbStar8.MouseHover += new System.EventHandler(this.pbStar1_MouseHover);
            // 
            // pbStar7
            // 
            this.pbStar7.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar7.Location = new System.Drawing.Point(177, 3);
            this.pbStar7.Name = "pbStar7";
            this.pbStar7.Size = new System.Drawing.Size(30, 30);
            this.pbStar7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar7.TabIndex = 6;
            this.pbStar7.TabStop = false;
            this.pbStar7.MouseHover += new System.EventHandler(this.pbStar1_MouseHover);
            // 
            // pbStar6
            // 
            this.pbStar6.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar6.Location = new System.Drawing.Point(148, 3);
            this.pbStar6.Name = "pbStar6";
            this.pbStar6.Size = new System.Drawing.Size(30, 30);
            this.pbStar6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar6.TabIndex = 5;
            this.pbStar6.TabStop = false;
            this.pbStar6.MouseHover += new System.EventHandler(this.pbStar1_MouseHover);
            // 
            // pbStar5
            // 
            this.pbStar5.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar5.Location = new System.Drawing.Point(119, 3);
            this.pbStar5.Name = "pbStar5";
            this.pbStar5.Size = new System.Drawing.Size(30, 30);
            this.pbStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar5.TabIndex = 4;
            this.pbStar5.TabStop = false;
            this.pbStar5.MouseHover += new System.EventHandler(this.pbStar1_MouseHover);
            // 
            // pbStar4
            // 
            this.pbStar4.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar4.Location = new System.Drawing.Point(90, 3);
            this.pbStar4.Name = "pbStar4";
            this.pbStar4.Size = new System.Drawing.Size(30, 30);
            this.pbStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar4.TabIndex = 3;
            this.pbStar4.TabStop = false;
            this.pbStar4.MouseHover += new System.EventHandler(this.pbStar1_MouseHover);
            // 
            // pbStar3
            // 
            this.pbStar3.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar3.Location = new System.Drawing.Point(61, 3);
            this.pbStar3.Name = "pbStar3";
            this.pbStar3.Size = new System.Drawing.Size(30, 30);
            this.pbStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar3.TabIndex = 2;
            this.pbStar3.TabStop = false;
            this.pbStar3.MouseHover += new System.EventHandler(this.pbStar1_MouseHover);
            // 
            // pbStar2
            // 
            this.pbStar2.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar2.Location = new System.Drawing.Point(32, 3);
            this.pbStar2.Name = "pbStar2";
            this.pbStar2.Size = new System.Drawing.Size(30, 30);
            this.pbStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar2.TabIndex = 1;
            this.pbStar2.TabStop = false;
            this.pbStar2.MouseHover += new System.EventHandler(this.pbStar1_MouseHover);
            // 
            // pbStar1
            // 
            this.pbStar1.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar1.Location = new System.Drawing.Point(3, 3);
            this.pbStar1.Name = "pbStar1";
            this.pbStar1.Size = new System.Drawing.Size(30, 30);
            this.pbStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar1.TabIndex = 0;
            this.pbStar1.TabStop = false;
            this.pbStar1.MouseHover += new System.EventHandler(this.pbStar1_MouseHover);
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
            // pnStars2
            // 
            this.pnStars2.Controls.Add(this.pbStar20);
            this.pnStars2.Controls.Add(this.pbStar19);
            this.pnStars2.Controls.Add(this.pbStar18);
            this.pnStars2.Controls.Add(this.pbStar17);
            this.pnStars2.Controls.Add(this.pbStar16);
            this.pnStars2.Controls.Add(this.pbStar15);
            this.pnStars2.Controls.Add(this.pbStar14);
            this.pnStars2.Controls.Add(this.pbStar13);
            this.pnStars2.Controls.Add(this.pbStar12);
            this.pnStars2.Controls.Add(this.pbStar11);
            this.pnStars2.Location = new System.Drawing.Point(482, 637);
            this.pnStars2.Name = "pnStars2";
            this.pnStars2.Size = new System.Drawing.Size(297, 36);
            this.pnStars2.TabIndex = 15;
            // 
            // pbStar20
            // 
            this.pbStar20.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar20.Location = new System.Drawing.Point(264, 3);
            this.pbStar20.Name = "pbStar20";
            this.pbStar20.Size = new System.Drawing.Size(30, 30);
            this.pbStar20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar20.TabIndex = 9;
            this.pbStar20.TabStop = false;
            // 
            // pbStar19
            // 
            this.pbStar19.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar19.Location = new System.Drawing.Point(235, 3);
            this.pbStar19.Name = "pbStar19";
            this.pbStar19.Size = new System.Drawing.Size(30, 30);
            this.pbStar19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar19.TabIndex = 8;
            this.pbStar19.TabStop = false;
            // 
            // pbStar18
            // 
            this.pbStar18.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar18.Location = new System.Drawing.Point(206, 3);
            this.pbStar18.Name = "pbStar18";
            this.pbStar18.Size = new System.Drawing.Size(30, 30);
            this.pbStar18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar18.TabIndex = 7;
            this.pbStar18.TabStop = false;
            // 
            // pbStar17
            // 
            this.pbStar17.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar17.Location = new System.Drawing.Point(177, 3);
            this.pbStar17.Name = "pbStar17";
            this.pbStar17.Size = new System.Drawing.Size(30, 30);
            this.pbStar17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar17.TabIndex = 6;
            this.pbStar17.TabStop = false;
            // 
            // pbStar16
            // 
            this.pbStar16.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar16.Location = new System.Drawing.Point(148, 3);
            this.pbStar16.Name = "pbStar16";
            this.pbStar16.Size = new System.Drawing.Size(30, 30);
            this.pbStar16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar16.TabIndex = 5;
            this.pbStar16.TabStop = false;
            // 
            // pbStar15
            // 
            this.pbStar15.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar15.Location = new System.Drawing.Point(119, 3);
            this.pbStar15.Name = "pbStar15";
            this.pbStar15.Size = new System.Drawing.Size(30, 30);
            this.pbStar15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar15.TabIndex = 4;
            this.pbStar15.TabStop = false;
            // 
            // pbStar14
            // 
            this.pbStar14.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar14.Location = new System.Drawing.Point(90, 3);
            this.pbStar14.Name = "pbStar14";
            this.pbStar14.Size = new System.Drawing.Size(30, 30);
            this.pbStar14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar14.TabIndex = 3;
            this.pbStar14.TabStop = false;
            // 
            // pbStar13
            // 
            this.pbStar13.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar13.Location = new System.Drawing.Point(61, 3);
            this.pbStar13.Name = "pbStar13";
            this.pbStar13.Size = new System.Drawing.Size(30, 30);
            this.pbStar13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar13.TabIndex = 2;
            this.pbStar13.TabStop = false;
            // 
            // pbStar12
            // 
            this.pbStar12.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar12.Location = new System.Drawing.Point(32, 3);
            this.pbStar12.Name = "pbStar12";
            this.pbStar12.Size = new System.Drawing.Size(30, 30);
            this.pbStar12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar12.TabIndex = 1;
            this.pbStar12.TabStop = false;
            // 
            // pbStar11
            // 
            this.pbStar11.Image = global::Peliculas.Properties.Resources.Star0;
            this.pbStar11.Location = new System.Drawing.Point(3, 3);
            this.pbStar11.Name = "pbStar11";
            this.pbStar11.Size = new System.Drawing.Size(30, 30);
            this.pbStar11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar11.TabIndex = 0;
            this.pbStar11.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminar.Location = new System.Drawing.Point(974, 644);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 32);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar Pelicula";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.pnStars2);
            this.Controls.Add(this.pnStars);
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
            this.pnStars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStar10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            this.pnStars2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbStar20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar11)).EndInit();
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
        private System.Windows.Forms.Panel pnStars;
        private System.Windows.Forms.PictureBox pbStar10;
        private System.Windows.Forms.PictureBox pbStar9;
        private System.Windows.Forms.PictureBox pbStar8;
        private System.Windows.Forms.PictureBox pbStar7;
        private System.Windows.Forms.PictureBox pbStar6;
        private System.Windows.Forms.PictureBox pbStar5;
        private System.Windows.Forms.PictureBox pbStar4;
        private System.Windows.Forms.PictureBox pbStar3;
        private System.Windows.Forms.PictureBox pbStar2;
        private System.Windows.Forms.PictureBox pbStar1;
        private System.Windows.Forms.Panel pnStars2;
        private System.Windows.Forms.PictureBox pbStar20;
        private System.Windows.Forms.PictureBox pbStar19;
        private System.Windows.Forms.PictureBox pbStar18;
        private System.Windows.Forms.PictureBox pbStar17;
        private System.Windows.Forms.PictureBox pbStar16;
        private System.Windows.Forms.PictureBox pbStar15;
        private System.Windows.Forms.PictureBox pbStar14;
        private System.Windows.Forms.PictureBox pbStar13;
        private System.Windows.Forms.PictureBox pbStar12;
        private System.Windows.Forms.PictureBox pbStar11;
        private System.Windows.Forms.Button btnEliminar;
    }
}

