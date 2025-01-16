using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaCampeonato
{
    public partial class RegistrarEquipoForm : Form
    {
        // Conexión a la base de datos
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-E124J3L;Initial Catalog=SistemaCampeonato;Integrated Security=True");

        // Lista de equipos para mantener la información en memoria
        private List<Equipo> equipos;

        // Constructor
        public RegistrarEquipoForm(List<Equipo> equipos)
        {
            InitializeComponent();
            this.equipos = equipos;
        }

        // Evento del botón para guardar un equipo
        private void btnGuardarEquipo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreEquipo.Text) || string.IsNullOrEmpty(txtFacultad.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            // Crear un nuevo objeto Equipo
            var equipo = new Equipo(txtNombreEquipo.Text, txtFacultad.Text);

            // Insertar equipo en la base de datos
            insertarEquipo(equipo);

            // Agregar el equipo a la lista local
            equipos.Add(equipo);

            MessageBox.Show("Equipo registrado correctamente.");
            this.Close();
        }

        // Evento del botón para agregar jugadores
        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            using (var form = new RegistrarJugadorForm(equipos))
            {
                form.ShowDialog();
            }
        }

        // Método para insertar un equipo en la base de datos
        private void insertarEquipo(Equipo equipo)
        {
            try
            {
                // Abrir conexión a la base de datos
                conn.Open();

                // Consulta SQL para insertar un equipo
                string query = @"
                    INSERT INTO Equipo (NombreEquipo, NombreFacultad)
                    OUTPUT INSERTED.IdEquipo
                    VALUES (@NombreEquipo, @NombreFacultad)";

                // Crear el comando SQL
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Agregar parámetros
                    cmd.Parameters.AddWithValue("@NombreEquipo", equipo.NombreEquipo);
                    cmd.Parameters.AddWithValue("@NombreFacultad", equipo.NombreFacultad);

                    // Ejecutar la consulta y obtener el Id del equipo insertado
                    equipo.IdEquipo = (int)cmd.ExecuteScalar();

                    MessageBox.Show($"Equipo registrado correctamente con ID: {equipo.IdEquipo}");
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show($"Error al registrar el equipo: {ex.Message}");
            }
            finally
            {
                // Cerrar la conexión a la base de datos
                conn.Close();
            }
        }

        // Eventos adicionales
        private void RegistrarEquipoForm_Load(object sender, EventArgs e)
        {
            // Código para cargar datos iniciales o configurar el formulario
        }

        private void txtFacultad_TextChanged(object sender, EventArgs e)
        {
            // Manejo de eventos para cambios en el texto de la facultad (si es necesario)
        }
    }
}
