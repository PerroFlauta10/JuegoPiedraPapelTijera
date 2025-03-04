namespace JuegoPiedra
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Jugar = new System.Windows.Forms.Button();
            this.Piedra = new System.Windows.Forms.Button();
            this.Papel = new System.Windows.Forms.Button();
            this.Tijeras = new System.Windows.Forms.Button();
            this.Juego = new System.Windows.Forms.Panel();
            this.Ramdon = new System.Windows.Forms.Label();
            this.Jugador = new System.Windows.Forms.Label();
            this.picturePapel1 = new System.Windows.Forms.PictureBox();
            this.pictureTijera1 = new System.Windows.Forms.PictureBox();
            this.picturePiedra1 = new System.Windows.Forms.PictureBox();
            this.pictureTijera = new System.Windows.Forms.PictureBox();
            this.picturePiedra = new System.Windows.Forms.PictureBox();
            this.picturePapel = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Juego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePapel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTijera1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePiedra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTijera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePiedra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Jugar
            // 
            this.Jugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jugar.Location = new System.Drawing.Point(317, 467);
            this.Jugar.Name = "Jugar";
            this.Jugar.Size = new System.Drawing.Size(328, 203);
            this.Jugar.TabIndex = 1;
            this.Jugar.Text = "Jugar";
            this.Jugar.UseVisualStyleBackColor = true;
            this.Jugar.Click += new System.EventHandler(this.Jugar_Click);
            // 
            // Piedra
            // 
            this.Piedra.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Piedra.Location = new System.Drawing.Point(33, 590);
            this.Piedra.Name = "Piedra";
            this.Piedra.Size = new System.Drawing.Size(243, 80);
            this.Piedra.TabIndex = 0;
            this.Piedra.Text = "Piedra";
            this.Piedra.UseVisualStyleBackColor = true;
            this.Piedra.Click += new System.EventHandler(this.Piedra_Click);
            // 
            // Papel
            // 
            this.Papel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Papel.Location = new System.Drawing.Point(370, 590);
            this.Papel.Name = "Papel";
            this.Papel.Size = new System.Drawing.Size(243, 80);
            this.Papel.TabIndex = 1;
            this.Papel.Text = "Papel";
            this.Papel.UseVisualStyleBackColor = true;
            this.Papel.Click += new System.EventHandler(this.Papel_Click);
            // 
            // Tijeras
            // 
            this.Tijeras.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tijeras.Location = new System.Drawing.Point(701, 590);
            this.Tijeras.Name = "Tijeras";
            this.Tijeras.Size = new System.Drawing.Size(243, 80);
            this.Tijeras.TabIndex = 2;
            this.Tijeras.Text = "Tijeras";
            this.Tijeras.UseVisualStyleBackColor = true;
            this.Tijeras.Click += new System.EventHandler(this.Tijeras_Click);
            // 
            // Juego
            // 
            this.Juego.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Juego.Controls.Add(this.Ramdon);
            this.Juego.Controls.Add(this.Jugador);
            this.Juego.Controls.Add(this.picturePapel1);
            this.Juego.Controls.Add(this.pictureTijera1);
            this.Juego.Controls.Add(this.picturePiedra1);
            this.Juego.Controls.Add(this.pictureTijera);
            this.Juego.Controls.Add(this.picturePiedra);
            this.Juego.Controls.Add(this.picturePapel);
            this.Juego.Controls.Add(this.Tijeras);
            this.Juego.Controls.Add(this.Papel);
            this.Juego.Controls.Add(this.Piedra);
            this.Juego.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Juego.Location = new System.Drawing.Point(0, 0);
            this.Juego.Name = "Juego";
            this.Juego.Size = new System.Drawing.Size(976, 696);
            this.Juego.TabIndex = 2;
            this.Juego.Visible = false;
            // 
            // Ramdon
            // 
            this.Ramdon.AutoSize = true;
            this.Ramdon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ramdon.ForeColor = System.Drawing.Color.White;
            this.Ramdon.Location = new System.Drawing.Point(80, 12);
            this.Ramdon.Name = "Ramdon";
            this.Ramdon.Size = new System.Drawing.Size(326, 46);
            this.Ramdon.TabIndex = 10;
            this.Ramdon.Text = "Jugador Ramdon";
            this.Ramdon.Visible = false;
            // 
            // Jugador
            // 
            this.Jugador.AutoSize = true;
            this.Jugador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Jugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jugador.ForeColor = System.Drawing.Color.White;
            this.Jugador.Location = new System.Drawing.Point(585, 528);
            this.Jugador.Name = "Jugador";
            this.Jugador.Size = new System.Drawing.Size(267, 48);
            this.Jugador.TabIndex = 9;
            this.Jugador.Text = "Este eres tu!! ";
            this.Jugador.Visible = false;
            // 
            // picturePapel1
            // 
            this.picturePapel1.Image = global::JuegoPiedra.Properties.Resources.Papel12;
            this.picturePapel1.Location = new System.Drawing.Point(555, 162);
            this.picturePapel1.Name = "picturePapel1";
            this.picturePapel1.Size = new System.Drawing.Size(324, 363);
            this.picturePapel1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePapel1.TabIndex = 8;
            this.picturePapel1.TabStop = false;
            this.picturePapel1.Visible = false;
            // 
            // pictureTijera1
            // 
            this.pictureTijera1.Image = global::JuegoPiedra.Properties.Resources.Tijera1;
            this.pictureTijera1.Location = new System.Drawing.Point(555, 162);
            this.pictureTijera1.Name = "pictureTijera1";
            this.pictureTijera1.Size = new System.Drawing.Size(324, 363);
            this.pictureTijera1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTijera1.TabIndex = 7;
            this.pictureTijera1.TabStop = false;
            this.pictureTijera1.Visible = false;
            // 
            // picturePiedra1
            // 
            this.picturePiedra1.Image = global::JuegoPiedra.Properties.Resources.Piedra1;
            this.picturePiedra1.Location = new System.Drawing.Point(555, 162);
            this.picturePiedra1.Name = "picturePiedra1";
            this.picturePiedra1.Size = new System.Drawing.Size(324, 363);
            this.picturePiedra1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePiedra1.TabIndex = 6;
            this.picturePiedra1.TabStop = false;
            this.picturePiedra1.Visible = false;
            // 
            // pictureTijera
            // 
            this.pictureTijera.Image = global::JuegoPiedra.Properties.Resources.Tijera;
            this.pictureTijera.Location = new System.Drawing.Point(82, 61);
            this.pictureTijera.Name = "pictureTijera";
            this.pictureTijera.Size = new System.Drawing.Size(324, 363);
            this.pictureTijera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTijera.TabIndex = 5;
            this.pictureTijera.TabStop = false;
            this.pictureTijera.Visible = false;
            // 
            // picturePiedra
            // 
            this.picturePiedra.Image = global::JuegoPiedra.Properties.Resources.Piedra;
            this.picturePiedra.Location = new System.Drawing.Point(82, 61);
            this.picturePiedra.Name = "picturePiedra";
            this.picturePiedra.Size = new System.Drawing.Size(324, 363);
            this.picturePiedra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePiedra.TabIndex = 4;
            this.picturePiedra.TabStop = false;
            this.picturePiedra.Visible = false;
            // 
            // picturePapel
            // 
            this.picturePapel.Image = global::JuegoPiedra.Properties.Resources.Papel;
            this.picturePapel.Location = new System.Drawing.Point(82, 61);
            this.picturePapel.Name = "picturePapel";
            this.picturePapel.Size = new System.Drawing.Size(324, 363);
            this.picturePapel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePapel.TabIndex = 3;
            this.picturePapel.TabStop = false;
            this.picturePapel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::JuegoPiedra.Properties.Resources.Tapete;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(976, 696);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 696);
            this.Controls.Add(this.Juego);
            this.Controls.Add(this.Jugar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piedra Papel Tijera";
            this.Juego.ResumeLayout(false);
            this.Juego.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePapel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTijera1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePiedra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTijera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePiedra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Jugar;
        private System.Windows.Forms.Button Piedra;
        private System.Windows.Forms.Button Papel;
        private System.Windows.Forms.Button Tijeras;
        private System.Windows.Forms.PictureBox picturePapel;
        private System.Windows.Forms.PictureBox picturePiedra;
        private System.Windows.Forms.PictureBox pictureTijera;
        private System.Windows.Forms.PictureBox picturePiedra1;
        private System.Windows.Forms.PictureBox pictureTijera1;
        private System.Windows.Forms.PictureBox picturePapel1;
        private System.Windows.Forms.Panel Juego;
        private System.Windows.Forms.Label Jugador;
        private System.Windows.Forms.Label Ramdon;
    }
}

