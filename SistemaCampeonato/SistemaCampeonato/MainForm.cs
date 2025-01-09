using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SistemaCampeonato
{
    public partial class MainForm : Form
    {
        private List<Equipo> equipos = new List<Equipo>();
        private List<Partidos> partidos = new List<Partidos>();
        private List<Resultados> resultados = new List<Resultados>();
        private List<TablaPosicion> tablaPosiciones = new List<TablaPosicion>();

        public MainForm()
        {
            InitializeComponent();
            ConfigurarBotones();
        }

        private void ConfigurarBotones()
        {
            // Configurar el botón Registrar Equipo
            btnRegistrarEquipo.Click += (s, e) => 
            {
                using (var form = new RegistrarEquipoForm(equipos))
                {
                    form.ShowDialog();
                }
            };

            // Configurar el botón Registrar Partido
            btnRegistrarPartido.Click += (s, e) =>
            {
                using (var form = new RegistrarPartidoForm(equipos, partidos, resultados, tablaPosiciones))
                {
                    form.ShowDialog();
                }
            };

            // Configurar el botón Tabla Posiciones
            btnTablaPosiciones.Click += (s, e) =>
            {
                using (var form = new TablaPosicionesForm(tablaPosiciones))
                {
                    form.ShowDialog();
                }
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Código que se ejecutará cuando el formulario se cargue
        }
    }
}