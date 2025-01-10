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
            if (string.IsNullOrEmpty(txtNombreEquipo.Text) ||
                string.IsNullOrEmpty(txtFacultad.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            var equipo = new Equipo(

                txtNombreEquipo.Text,
                txtFacultad.Text
            );

            equipos.Add(equipo);
            MessageBox.Show("Equipo registrado correctamente.");
            this.Close();
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            using (var form = new RegistrarJugadorForm(equipos))
            {
                form.ShowDialog();
            }
        }

        private void RegistrarEquipoForm_Load(object sender, EventArgs e)
        {

        }

        private void txtFacultad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
