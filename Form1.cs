﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoPiedra
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int contadorVictorias = 0;
        int juegosJugados = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Jugar_Click(object sender, EventArgs e)
        {
            Juego.Visible = true;
        }

        #region Botones
        private void Piedra_Click(object sender, EventArgs e)
        {
            picturePapel1.Visible = false;
            pictureTijera1.Visible = false;
            picturePiedra1.Visible = true;
            MostrarImagenAleatoria();
            ComprobarVictoria();
        }

        private void Papel_Click(object sender, EventArgs e)
        {
            picturePiedra1.Visible = false;
            pictureTijera1.Visible = false;
            picturePapel1.Visible = true;
            MostrarImagenAleatoria();
            ComprobarVictoria();
        }

        private void Tijeras_Click(object sender, EventArgs e)
        {
            picturePiedra1.Visible = false;
            picturePapel1.Visible = false;
            pictureTijera1.Visible = true;
            MostrarImagenAleatoria();
            ComprobarVictoria();
        }
        #endregion

        #region JugadorAleatorio
        private void MostrarImagenAleatoria()
        {
            // Ocultar todas las imágenes primero
            picturePiedra.Visible = false;
            picturePapel.Visible = false;
            pictureTijera.Visible = false;

            // Generar un número aleatorio entre 0 y 2
            int aleatorio = random.Next(3);

            // Mostrar la imagen correspondiente
            switch (aleatorio)
            {
                case 0:
                    picturePiedra.Visible = true;
                    break;
                case 1:
                    picturePapel.Visible = true;
                    break;
                case 2:
                    pictureTijera.Visible = true;
                    break;
            }
        }
        #endregion JugadorAleatorio

        #region Victorias
        private void ComprobarVictoria()
        {
            // Comprobar si el jugador ha ganado
            if (picturePiedra1.Visible && pictureTijera.Visible ||
                picturePapel1.Visible && picturePiedra.Visible ||
                pictureTijera1.Visible && picturePapel.Visible)
            {
                contadorVictorias++;
                MessageBox.Show("¡Has ganado!");
               
            }
            // Comprobar si el jugador ha perdido
            else if (picturePiedra1.Visible && picturePapel.Visible ||
                     picturePapel1.Visible && pictureTijera.Visible ||
                     pictureTijera1.Visible && picturePiedra.Visible)
            {
                MessageBox.Show("¡Has perdido!");
                
            }
            // Comprobar si hay empate
            else
            {
                MessageBox.Show("¡Empate!");
                
            }

            juegosJugados++;
            MessageBox.Show("Puntuacion : " + contadorVictorias +"/"+juegosJugados);

            // Ocultar todas las imágenes
            picturePiedra1.Visible = false;
            picturePapel1.Visible = false;
            pictureTijera1.Visible = false;
            picturePiedra.Visible = false;
            picturePapel.Visible = false;
            pictureTijera.Visible = false;

            // Comprobar si se han jugado tres juegos
            if (juegosJugados == 3)
            {
                if (contadorVictorias >= 2)
                {
                    MessageBox.Show("¡Has ganado la serie!");
                }
                else
                {
                    MessageBox.Show("¡Has perdido la serie!");
                }

                // Reiniciar contadores
                contadorVictorias = 0;
                juegosJugados = 0;
            }
        }
        #endregion Victorias
    }
}
