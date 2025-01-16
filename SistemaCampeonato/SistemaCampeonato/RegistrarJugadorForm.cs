using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaCampeonato
{
    public partial class RegistrarJugadorForm : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=DESKTOP-E124J3L;Initial Catalog=SistemaCampeonato;Integrated Security=True");
        private List<Equipo> equipos;

        public RegistrarJugadorForm(List<Equipo> equipos)
        {
            InitializeComponent();
            this.equipos = equipos;
        }

        private void RegistrarJugadorForm_Load(object sender, EventArgs e)
        {
            CargarEquipos();
            CargarPosiciones();
            MessageBox.Show("Formulario cargado correctamente.");
        }

        private void CargarEquipos()
        {
            cbEquipos.Items.Clear();
            foreach (var equipo in equipos)
            {
                cbEquipos.Items.Add(equipo);
            }
            cbEquipos.DisplayMember = "NombreEquipo";
        }

        private void CargarPosiciones()
        {
            cbPosicion.Items.Clear();
            foreach (var posicion in PosicionesPredeterminadas.ListaPosiciones)
            {
                cbPosicion.Items.Add(posicion);
            }
            cbPosicion.DisplayMember = "Nombre";
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

            var equipo = (Equipo)cbEquipos.SelectedItem;
            var jugador = new Jugador(
                txtCedula.Text,
                txtNombre.Text,
                int.Parse(txtDorsal.Text),
                (Posicion)cbPosicion.SelectedItem,
                equipo
            );

            insertarJugador(jugador);
            equipo.Jugadores.Add(jugador);

            MessageBox.Show("Jugador registrado correctamente.");
            this.Close();
        }

        private void insertarJugador(Jugador jugador)
        {
            try
            {
                conn.Open();
                string query = @"
                    INSERT INTO Jugador (Cedula, Nombre, Dorsal, IdPosicion, IdEquipo)
                    VALUES (@Cedula, @Nombre, @Dorsal, @IdPosicion, @IdEquipo)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cedula", jugador.Cedula);
                    cmd.Parameters.AddWithValue("@Nombre", jugador.Nombre);
                    cmd.Parameters.AddWithValue("@Dorsal", jugador.Dorsal);
                    cmd.Parameters.AddWithValue("@IdPosicion", jugador.Posicion.Id);
                    cmd.Parameters.AddWithValue("@IdEquipo", jugador.Equipo.IdEquipo);

                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("Jugador registrado correctamente en la base de datos.");
                    else
                        MessageBox.Show("No se pudo registrar el jugador en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al insertar el jugador: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
