using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaCampeonato
{
    public partial class MainForm : Form
    {
        // Inicializa las listas de equipos y partidos
        private List<Equipo> equipos = new List<Equipo>();
        private List<Partidos> partidos = new List<Partidos>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Cualquier configuración inicial que desees al cargar el formulario
        }

        private void btnRegistrarEquipo_Click(object sender, EventArgs e)
        {
            // Al presionar el botón, se abre el formulario para registrar un equipo
            RegistrarEquipoForm formRegistrarEquipo = new RegistrarEquipoForm(equipos);
            formRegistrarEquipo.ShowDialog(); // Abre el formulario de manera modal
        }

        private void btnRegistrarPartido_Click(object sender, EventArgs e)
        {
            // Al presionar el botón, se abre el formulario para registrar un partido
            RegistrarPartidoForm formRegistrarPartido = new RegistrarPartidoForm(equipos, partidos);
            formRegistrarPartido.ShowDialog(); // Abre el formulario de manera modal
        }

        private void btnTablaPosiciones_Click(object sender, EventArgs e)
        {
            // Lógica para mostrar la tabla de posiciones
            // Asegúrate de tener la lógica para llenar la lista de tablaPosiciones
            List<TablaPosicion> tablaPosiciones = new List<TablaPosicion>();

            // Aquí podrías llenar la tablaPosiciones con los datos necesarios
            TablaPosicionesForm tablaPosicionesForm = new TablaPosicionesForm(tablaPosiciones);
            tablaPosicionesForm.ShowDialog(); // Abre el formulario de manera modal
        }

        private void btnRegistrarJugador_Click(object sender, EventArgs e)
        {
            // Al presionar el botón, se abre el formulario para registrar un jugador
            RegistrarJugadorForm formRegistrarJugador = new RegistrarJugadorForm(equipos);
            formRegistrarJugador.ShowDialog(); // Abre el formulario de manera modal
        }
    }
}
