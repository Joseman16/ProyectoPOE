using System;
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
                if (!tablaPosiciones.Exists(tp => tp.NombreEquipo == equipo))
                {
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
            // Abre el formulario para registrar resultados
            if (partidos.Count == 0)
            {
                MessageBox.Show("No hay partidos registrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RegistrarResultadoForm formRegistrarResultado = new RegistrarResultadoForm(partidos, tablaPosiciones);
            formRegistrarResultado.ShowDialog();
        }

        private void btnTablaPosiciones_Click(object sender, EventArgs e)
        {
            // Mostrar la tabla de posiciones
            TablaPosicionesForm tablaPosicionesForm = new TablaPosicionesForm(tablaPosiciones);
            tablaPosicionesForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MasOpciones maOP = new MasOpciones();
            maOP.ShowDialog();
        }
    }
}
