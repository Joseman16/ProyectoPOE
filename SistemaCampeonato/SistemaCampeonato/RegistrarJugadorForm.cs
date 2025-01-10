using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaCampeonato
{
    public partial class RegistrarJugadorForm : Form
    {
        private List<Equipo> equipos;

        public RegistrarJugadorForm(List<Equipo> equipos)
        {
            InitializeComponent();
            this.equipos = equipos;

            CargarEquipos();
            CargarPosiciones();
        }

        private void CargarEquipos()
        {
            cbEquipos.Items.Clear();
            foreach (var equipo in equipos)
            {
                cbEquipos.Items.Add(equipo);
            }
        }

        private void CargarPosiciones()
        {
            cbPosicion.Items.Clear();
            foreach (var posicion in PosicionesPredeterminadas.ListaPosiciones)
            {
                cbPosicion.Items.Add(posicion); // Carga las posiciones predefinidas
            }

            cbPosicion.DisplayMember = "Nombre"; // Mostrar solo el nombre en el ComboBox
        }

        private void btnGuardarJugador_Click(object sender, EventArgs e)
        {
            if (cbEquipos.SelectedItem == null ||
                string.IsNullOrEmpty(txtCedula.Text) ||
                string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtDorsal.Text) ||
                cbPosicion.SelectedItem == null)
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            // Buscar el equipo seleccionado
            var equipo = (Equipo)cbEquipos.SelectedItem;

            // Crear el jugador
            var jugador = new Jugador(
                txtCedula.Text,
                txtNombre.Text,
                int.Parse(txtDorsal.Text),
                (Posicion)cbPosicion.SelectedItem,
                equipo
            );

            // Agregar el jugador al equipo
            equipo.Jugadores.Add(jugador);

            MessageBox.Show("Jugador registrado correctamente.");
            this.Close();
        }

        private void RegistrarJugadorForm_Load(object sender, EventArgs e)
        {
            // Cargar datos adicionales si es necesario
        }
    }
}
