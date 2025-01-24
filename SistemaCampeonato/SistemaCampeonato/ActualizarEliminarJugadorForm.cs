using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaCampeonato
{
    public partial class ActualizarEliminarJugadorForm : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-E124J3L;Initial Catalog=SistemaCampeonato;Integrated Security=True";

        public ActualizarEliminarJugadorForm()
        {
            InitializeComponent();
        }

        private void ActualizarEliminarJugadorForm_Load(object sender, EventArgs e)
        {
            // Cargar los jugadores al iniciar el formulario
            CargarJugadores();
        }

        private void CargarJugadores()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT Cedula, Nombre, Dorsal, IdPosicion, IdEquipo FROM Jugador";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        listBoxJugadores.Items.Clear();

                        while (reader.Read())
                        {
                            var jugador = new Jugador
                            {
                                Cedula = reader.GetString(0),
                                Nombre = reader.GetString(1),
                                Dorsal = reader.GetInt32(2),
                                Posicion = new Posicion(reader.GetInt32(3), "Desconocida"), // Asigna el ID de posición
                                Equipo = new Equipo { IdEquipo = reader.GetInt32(4), NombreEquipo = "Desconocido" } // Asigna el ID de equipo
                            };

                            listBoxJugadores.Items.Add(jugador);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar jugadores: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (listBoxJugadores.SelectedItem is not Jugador jugadorSeleccionado)
            {
                MessageBox.Show("Seleccione un jugador para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            jugadorSeleccionado.Nombre = txtNombre.Text;
            jugadorSeleccionado.Dorsal = int.Parse(txtDorsal.Text);
            jugadorSeleccionado.Posicion = new Posicion(int.Parse(txtIdPosicion.Text), "Desconocida");
            jugadorSeleccionado.Equipo = new Equipo { IdEquipo = int.Parse(txtIdEquipo.Text) };

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        UPDATE Jugador
                        SET Nombre = @Nombre, Dorsal = @Dorsal, IdPosicion = @IdPosicion, IdEquipo = @IdEquipo
                        WHERE Cedula = @Cedula";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", jugadorSeleccionado.Nombre);
                        cmd.Parameters.AddWithValue("@Dorsal", jugadorSeleccionado.Dorsal);
                        cmd.Parameters.AddWithValue("@IdPosicion", jugadorSeleccionado.Posicion.Id);
                        cmd.Parameters.AddWithValue("@IdEquipo", jugadorSeleccionado.Equipo.IdEquipo);
                        cmd.Parameters.AddWithValue("@Cedula", jugadorSeleccionado.Cedula);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Jugador actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarJugadores();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar jugador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxJugadores.SelectedItem is not Jugador jugadorSeleccionado)
            {
                MessageBox.Show("Seleccione un jugador para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM Jugador WHERE Cedula = @Cedula";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cedula", jugadorSeleccionado.Cedula);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Jugador eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarJugadores();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar jugador: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxJugadores.SelectedItem is Jugador jugadorSeleccionado)
            {
                txtNombre.Text = jugadorSeleccionado.Nombre;
                txtDorsal.Text = jugadorSeleccionado.Dorsal.ToString();
                txtIdPosicion.Text = jugadorSeleccionado.Posicion.Id.ToString();
                txtIdEquipo.Text = jugadorSeleccionado.Equipo.IdEquipo.ToString();
            }
        }
    }
}
