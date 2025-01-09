using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaCampeonato
{
    public partial class RegistrarEquipoForm : Form
    {
        private List<Equipo> equipos;

        public RegistrarEquipoForm(List<Equipo> equipos)
        {
            InitializeComponent();
            this.equipos = equipos;
        }

        private void btnGuardarEquipo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdEquipo.Text) || string.IsNullOrEmpty(txtNombreEquipo.Text) || string.IsNullOrEmpty(txtFacultad.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            var equipo = new Equipo
            {
                IdEquipo = int.Parse(txtIdEquipo.Text),
                Nombre = txtNombreEquipo.Text,
                Facultad = txtFacultad.Text
            };

            equipos.Add(equipo);
            MessageBox.Show("Equipo registrado correctamente.");
            this.Close();
        }

        private void RegistrarEquipoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
