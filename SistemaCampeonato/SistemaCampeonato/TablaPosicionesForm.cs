using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaCampeonato
{
    public partial class RegistrarResultadoForm : Form
    {
        private List<Partidos> partidos;
        private List<TablaPosicion> tablaPosiciones;
        private readonly string connectionString = "Data Source=DESKTOP-E124J3L;Initial Catalog=SistemaCampeonato;Integrated Security=True";

        public RegistrarResultadoForm(List<Partidos> partidos, List<TablaPosicion> tablaPosiciones)
        {
            InitializeComponent();
            this.partidos = partidos ?? new List<Partidos>();
            this.tablaPosiciones = tablaPosiciones ?? new List<TablaPosicion>();
        }

        private void ObtenerPartidosDesdeBDD()
        {
            partidos.Clear();

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT 
                                        p.IdPartido, 
                                        e1.IdEquipo AS IdLocal, e1.NombreEquipo AS NombreLocal, 
                                        e2.IdEquipo AS IdVisitante, e2.NombreEquipo AS NombreVisitante, 
                                        p.Fecha, p.Hora 
                                     FROM Partidos p
                                     JOIN Equipo e1 ON p.IdEquipoLocal = e1.IdEquipo
                                     JOIN Equipo e2 ON p.IdEquipoVisitante = e2.IdEquipo
                                     LEFT JOIN Resultados r ON p.IdPartido = r.IdPartido
                                     WHERE r.IdPartido IS NULL"; // Only fetch matches without results

                    using (var cmd = new SqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var equipoLocal = new Equipo
                            {
                                IdEquipo = reader.GetInt32(1),
                                NombreEquipo = reader.GetString(2)
                            };

                            var equipoVisitante = new Equipo
                            {
                                IdEquipo = reader.GetInt32(3),
                                NombreEquipo = reader.GetString(4)
                            };

                            partidos.Add(new Partidos
                            {
                                IdPartido = reader.GetInt32(0),
                                EquipoLocal = equipoLocal,
                                EquipoVisitante = equipoVisitante,
                                Fecha = reader.GetDateTime(5),
                                Hora = reader.GetTimeSpan(6)
                            });
                        }
                    }
                }

                CargarPartidosEnComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar partidos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPartidosEnComboBox()
        {
            comboBoxPartidos.Items.Clear();
            foreach (var partido in partidos)
            {
                comboBoxPartidos.Items.Add($"{partido.IdPartido}: {partido.EquipoLocal.NombreEquipo} vs {partido.EquipoVisitante.NombreEquipo}");
            }
        }

        private void RegistrarResultadoEnBDD(Resultados resultado)
        {
            if (resultado == null || resultado.Partido == null)
            {
                MessageBox.Show("Datos de resultado inválidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if result already exists
                    string checkQuery = "SELECT COUNT(*) FROM Resultados WHERE IdPartido = @IdPartido";
                    using (var checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@IdPartido", resultado.Partido.IdPartido);
                        int existingResultCount = (int)checkCmd.ExecuteScalar();

                        if (existingResultCount > 0)
                        {
                            MessageBox.Show("Ya existe un resultado para este partido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Insert result
                    string insertQuery = @"
                        INSERT INTO Resultados 
                        (IdPartido, GolesEquipoLocal, GolesEquipoVisitante, EsEmpate, IdEquipoGanador) 
                        VALUES 
                        (@IdPartido, @GolesLocal, @GolesVisitante, @EsEmpate, @IdEquipoGanador)";

                    using (var cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdPartido", resultado.Partido.IdPartido);
                        cmd.Parameters.AddWithValue("@GolesLocal", resultado.GolesEquipoLocal);
                        cmd.Parameters.AddWithValue("@GolesVisitante", resultado.GolesEquipoVisitante);
                        cmd.Parameters.AddWithValue("@EsEmpate", resultado.EsEmpate);

                        // Handle potential null for winner
                        object idEquipoGanador = resultado.EquipoGanador != null
                            ? (object)resultado.EquipoGanador.IdEquipo
                            : DBNull.Value;
                        cmd.Parameters.AddWithValue("@IdEquipoGanador", idEquipoGanador);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No se pudo insertar el resultado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Resultado registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de base de datos: {ex.Number} - {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            // Validate matches exist
            if (partidos.Count == 0)
            {
                MessageBox.Show("No hay partidos registrados en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate match selection
            if (comboBoxPartidos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un partido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var partidoSeleccionado = partidos[comboBoxPartidos.SelectedIndex];
            int golesLocal = (int)numericGolesLocal.Value;
            int golesVisitante = (int)numericGolesVisitante.Value;

            // Create Resultados object
            var resultado = new Resultados(0, partidoSeleccionado, golesLocal, golesVisitante);

            // Register result
            RegistrarResultadoEnBDD(resultado);

            // Update standings
            foreach (var equipoPosicion in tablaPosiciones)
            {
                equipoPosicion.ActualizarTabla(resultado);
            }

            // Refresh standings display
            listBoxTablaPosiciones.Items.Clear();
            foreach (var posicion in tablaPosiciones)
            {
                listBoxTablaPosiciones.Items.Add(posicion.ToString());
            }

            // Refresh matches list to remove registered match
            ObtenerPartidosDesdeBDD();
        }

        private void RegistrarResultadoForm_Load(object sender, EventArgs e)
        {
            ObtenerPartidosDesdeBDD();
        }
    }
}
