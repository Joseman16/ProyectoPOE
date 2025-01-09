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
        }


        private void CargarEquipos()
        {
            cbEquipos.Items.Clear(); // Limpiar elementos previos del ComboBox
            foreach (var equipo in equipos)
            {
                cbEquipos.Items.Add(equipo);  // Agregar el objeto equipo (no solo su nombre)
            }
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

            // Buscar el equipo seleccionado por su nombre
            var equipo = equipos.Find(e => e.NombreEquipo == cbEquipos.SelectedItem.ToString());

            // Crear el jugador con los datos proporcionados
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

        }
    }
}
