using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaCampeonato
{
    public partial class ActualizarEliminarEquipoForm : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-E124J3L;Initial Catalog=SistemaCampeonato;Integrated Security=True";

        public ActualizarEliminarEquipoForm()
        {
            InitializeComponent();
        }

        private void ActualizarEliminarEquipoForm_Load(object sender, EventArgs e)
        {
            // Cargar equipos al iniciar el formulario
            CargarEquipos();
        }

        private void CargarEquipos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT IdEquipo, NombreEquipo, NombreFacultad FROM Equipo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        listBoxEquipos.Items.Clear();

                        while (reader.Read())
                        {
                            var equipo = new Equipo
                            {
                                IdEquipo = reader.GetInt32(0),
                                NombreEquipo = reader.GetString(1),
                                NombreFacultad = reader.GetString(2)
                            };

                            listBoxEquipos.Items.Add(equipo);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar equipos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (listBoxEquipos.SelectedItem is not Equipo equipoSeleccionado)
            {
                MessageBox.Show("Seleccione un equipo para actualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            equipoSeleccionado.NombreEquipo = txtNombreEquipo.Text;
            equipoSeleccionado.NombreFacultad = txtNombreFacultad.Text;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        UPDATE Equipo
                        SET NombreEquipo = @NombreEquipo, NombreFacultad = @NombreFacultad
                        WHERE IdEquipo = @IdEquipo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NombreEquipo", equipoSeleccionado.NombreEquipo);
                        cmd.Parameters.AddWithValue("@NombreFacultad", equipoSeleccionado.NombreFacultad);
                        cmd.Parameters.AddWithValue("@IdEquipo", equipoSeleccionado.IdEquipo);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Equipo actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEquipos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar equipo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (listBoxEquipos.SelectedItem is not Equipo equipoSeleccionado)
            {
                MessageBox.Show("Seleccione un equipo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Eliminar IdPartido de registros relacionados antes de eliminar el equipo
                EliminarPartidosAsociados(equipoSeleccionado.IdEquipo);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "DELETE FROM Equipo WHERE IdEquipo = @IdEquipo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEquipo", equipoSeleccionado.IdEquipo);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Equipo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEquipos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar equipo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarPartidosAsociados(int idEquipo)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "UPDATE Partido SET IdPartido = NULL WHERE IdEquipoLocal = @IdEquipo OR IdEquipoVisitante = @IdEquipo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEquipo", idEquipo);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al desvincular partidos del equipo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEquipos.SelectedItem is Equipo equipoSeleccionado)
            {
                txtNombreEquipo.Text = equipoSeleccionado.NombreEquipo;
                txtNombreFacultad.Text = equipoSeleccionado.NombreFacultad;
            }
        }
    }
}
