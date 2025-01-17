using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaCampeonato
{
    public partial class RegistrarPartidoForm : Form
    {
        private List<Partidos> partidos;
        private List<Equipo> equipos;

        private readonly string connectionString = "Data Source=DESKTOP-E124J3L;Initial Catalog=SistemaCampeonato;Integrated Security=True";

        public RegistrarPartidoForm(List<Equipo> equipos, List<Partidos> partidos)
        {
            InitializeComponent();
            this.equipos = equipos ?? new List<Equipo>();
            this.partidos = partidos ?? new List<Partidos>();
            ObtenerEquiposDesdeBD(); // Cargar equipos al inicializar el formulario
        }

        private void CargarEquipos()
        {
            cbEquipoLocal.Items.Clear();
            cbEquipoVisitante.Items.Clear();

            foreach (var equipo in equipos)
            {
                cbEquipoLocal.Items.Add(equipo.NombreEquipo);
                cbEquipoVisitante.Items.Add(equipo.NombreEquipo);
            }

            if (cbEquipoLocal.Items.Count > 0) cbEquipoLocal.SelectedIndex = 0;
            if (cbEquipoVisitante.Items.Count > 0) cbEquipoVisitante.SelectedIndex = 0;
        }

        private void ObtenerEquiposDesdeBD()
        {
            equipos.Clear(); // Limpiar la lista antes de cargar nuevos datos

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT IdEquipo, NombreEquipo FROM Equipo";

                    using (var cmd = new SqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            equipos.Add(new Equipo
                            {
                                IdEquipo = reader.GetInt32(0),
                                NombreEquipo = reader.GetString(1)
                            });
                        }
                    }
                }

                // Actualizar los ComboBox con los equipos cargados
                CargarEquipos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar equipos desde la base de datos: {ex.Message}");
            }
        }

        private void btnGuardarPartido_Click(object sender, EventArgs e)
        {
            if (cbEquipoLocal.SelectedItem == null || cbEquipoVisitante.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtFecha.Text) || string.IsNullOrWhiteSpace(txtHora.Text) ||
                txtFecha.Text == "Fecha (YYYY-MM-DD)" || txtHora.Text == "Hora (HH:MM)")
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            if (cbEquipoLocal.SelectedItem.ToString() == cbEquipoVisitante.SelectedItem.ToString())
            {
                MessageBox.Show("El equipo local y visitante no pueden ser el mismo.");
                return;
            }

            try
            {
                var partido = new Partidos
                {
                    EquipoLocal = equipos.Find(e => e.NombreEquipo == cbEquipoLocal.SelectedItem.ToString()),
                    EquipoVisitante = equipos.Find(e => e.NombreEquipo == cbEquipoVisitante.SelectedItem.ToString()),
                    Fecha = DateTime.Parse(txtFecha.Text),
                    Hora = TimeSpan.Parse(txtHora.Text)
                };

                partidos.Add(partido);
                GuardarPartidoEnBD(partido);

                MessageBox.Show("Partido registrado correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar el partido: {ex.Message}");
            }
        }

        private void GuardarPartidoEnBD(Partidos partido)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO Partidos (IdEquipoLocal, IdEquipoVisitante, Fecha, Hora)
                        VALUES (@IdEquipoLocal, @IdEquipoVisitante, @Fecha, @Hora)";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEquipoLocal", partido.EquipoLocal.IdEquipo);
                        cmd.Parameters.AddWithValue("@IdEquipoVisitante", partido.EquipoVisitante.IdEquipo);
                        cmd.Parameters.AddWithValue("@Fecha", partido.Fecha);
                        cmd.Parameters.AddWithValue("@Hora", partido.Hora);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el partido en la base de datos: {ex.Message}");
            }
        }

        private void TxtFecha_Enter(object sender, EventArgs e)
        {
            if (txtFecha.Text == "Fecha (YYYY-MM-DD)")
            {
                txtFecha.Text = ""; // Limpiar el texto
                txtFecha.ForeColor = Color.Black; // Cambiar el color del texto a negro
            }
        }

        private void TxtFecha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFecha.Text))
            {
                txtFecha.Text = "Fecha (YYYY-MM-DD)"; // Restaurar el texto de marcador
                txtFecha.ForeColor = Color.Gray; // Cambiar el color del texto a gris
            }
        }

        private void TxtHora_Enter(object sender, EventArgs e)
        {
            if (txtHora.Text == "Hora (HH:MM)")
            {
                txtHora.Text = ""; // Limpiar el texto
                txtHora.ForeColor = Color.Black; // Cambiar el color del texto a negro
            }
        }

        private void TxtHora_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHora.Text))
            {
                txtHora.Text = "Hora (HH:MM)"; // Restaurar el texto de marcador
                txtHora.ForeColor = Color.Gray; // Cambiar el color del texto a gris
            }
        }

        private void RegistrarPartidoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
