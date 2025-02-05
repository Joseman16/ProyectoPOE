﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaCampeonato
{
    public partial class MainForm : Form
    {
        private List<Equipo> equipos = new List<Equipo>();
        private List<Partidos> partidos = new List<Partidos>();
        private List<TablaPosicion> tablaPosiciones = new List<TablaPosicion>();

        public MainForm()
        {
            this.Hide();
            this.BackColor = Color.LightBlue;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Carga inicial: crea posiciones para todos los equipos
            foreach (var equipo in equipos)
            {
                tablaPosiciones.Add(new TablaPosicion(equipo));
            }

            gif1.Image = Image.FromFile("C:\\Users\\Josman\\Desktop\\Tareas UG\\ProyectoPOE\\futbol.gif");
            gif1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnRegistrarEquipo_Click(object sender, EventArgs e)
        {
            // Abre el formulario para registrar un equipo
            RegistrarEquipoForm formRegistrarEquipo = new RegistrarEquipoForm(equipos);
            formRegistrarEquipo.ShowDialog();

            // Actualizar la tabla de posiciones con los nuevos equipos
            foreach (var equipo in equipos)
            {
                // Verificar si el equipo ya existe en la tabla de posiciones
                if (!tablaPosiciones.Exists(tp => tp.Equipo.NombreEquipo == equipo.NombreEquipo))
                {
                    // Si no existe, agregarlo
                    tablaPosiciones.Add(new TablaPosicion(equipo));
                }
            }
        }


        private void btnRegistrarPartido_Click(object sender, EventArgs e)
        {
            // Abre el formulario para registrar un partido
            RegistrarPartidoForm formRegistrarPartido = new RegistrarPartidoForm(equipos, partidos);
            formRegistrarPartido.ShowDialog();
        }

        private void btnRegistrarJugador_Click(object sender, EventArgs e)
        {
            // Abre el formulario para registrar un jugador
            RegistrarJugadorForm formRegistrarJugador = new RegistrarJugadorForm(equipos);
            formRegistrarJugador.ShowDialog();
        }

        private void btnRegistrarResultado_Click(object sender, EventArgs e)
        {
            RegistrarResultadoForm formRegistrarResultado = new RegistrarResultadoForm(partidos, tablaPosiciones);
            formRegistrarResultado.ShowDialog();
        }

        private void btnTablaPosiciones_Click(object sender, EventArgs e)
        {
            // Mostrar la tabla de posiciones
            TablaPosicionesForm tablaPosicionesForm = new TablaPosicionesForm();
            tablaPosicionesForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario principal

            using (MasOpciones maOP = new MasOpciones())
            {
                maOP.ShowDialog(); // Abre el formulario secundario de manera modal
            }

            this.Show(); // Muestra el formulario principal una vez que el secundario se cierra

        }

        private void gif1_Click(object sender, EventArgs e)
        {

        }
    }
}
