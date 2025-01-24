using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaCampeonato
{
    public partial class TablaPosicionesForm : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-E124J3L;Initial Catalog=SistemaCampeonato;Integrated Security=True";
        private List<TablaPosicion> tablaPosiciones;

        public TablaPosicionesForm()
        {
            InitializeComponent();
            tablaPosiciones = new List<TablaPosicion>();
        }

        private void TablaPosicionesForm_Load(object sender, EventArgs e)
        {
            // Cargar las posiciones al iniciar el formulario
            CargarTablaPosicionesDesdeBDD();
        }

        private void CargarTablaPosicionesDesdeBDD()
        {
            tablaPosiciones.Clear();

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            e.IdEquipo, e.NombreEquipo,
                            ISNULL(SUM(CASE WHEN r.IdEquipoGanador = e.IdEquipo THEN 3 WHEN r.EsEmpate = 1 THEN 1 ELSE 0 END), 0) AS Puntos,
                            ISNULL(SUM(r.GolesEquipoLocal), 0) + ISNULL(SUM(r.GolesEquipoVisitante), 0) AS GolesFavor,
                            ISNULL(SUM(CASE WHEN p.IdEquipoLocal = e.IdEquipo THEN r.GolesEquipoVisitante ELSE r.GolesEquipoLocal END), 0) AS GolesEnContra
                        FROM Equipo e
                        LEFT JOIN Partidos p ON p.IdEquipoLocal = e.IdEquipo OR p.IdEquipoVisitante = e.IdEquipo
                        LEFT JOIN Resultados r ON r.IdPartido = p.IdPartido
                        GROUP BY e.IdEquipo, e.NombreEquipo
                        ORDER BY Puntos DESC, (ISNULL(SUM(r.GolesEquipoLocal), 0) - ISNULL(SUM(CASE WHEN p.IdEquipoLocal = e.IdEquipo THEN r.GolesEquipoVisitante ELSE r.GolesEquipoLocal END), 0)) DESC";

                    using (var cmd = new SqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var equipo = new Equipo
                            {
                                IdEquipo = reader.GetInt32(0),
                                NombreEquipo = reader.GetString(1)
                            };

                            var posicion = new TablaPosicion(equipo)
                            {
                                Puntos = reader.GetInt32(2),
                                GolesFavor = reader.GetInt32(3),
                                GolesEnContra = reader.GetInt32(4)
                            };

                            tablaPosiciones.Add(posicion);
                        }
                    }
                }

                MostrarTablaPosiciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la tabla de posiciones: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarTablaPosiciones()
        {
            listBoxTablaPosiciones.Items.Clear();
            int posicion = 1;

            foreach (var equipoPosicion in tablaPosiciones)
            {
                listBoxTablaPosiciones.Items.Add($"{posicion}. {equipoPosicion}");
                posicion++;
            }
        }
    }
}
