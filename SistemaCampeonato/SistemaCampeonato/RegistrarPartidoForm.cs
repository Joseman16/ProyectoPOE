using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaCampeonato
{
    public partial class RegistrarPartidoForm : Form
    {
        private List<Partido> partidos;
        private List<Equipo> equipos;

        public RegistrarPartidoForm(List<Equipo> equipos, List<Partido> partidos)
        {
            InitializeComponent();
            this.equipos = equipos;
            this.partidos = partidos;
            CargarEquipos();
        }

        private void CargarEquipos()
        {
            foreach (var equipo in equipos)
            {
                cbEquipoLocal.Items.Add(equipo.Nombre);
                cbEquipoVisitante.Items.Add(equipo.Nombre);
            }
        }

        private void btnGuardarPartido_Click(object sender, EventArgs e)
        {
            if (cbEquipoLocal.SelectedItem == null || cbEquipoVisitante.SelectedItem == null || string.IsNullOrEmpty(txtFecha.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            var partido = new Partido
            {
                EquipoLocal = cbEquipoLocal.SelectedItem.ToString(),
                EquipoVisitante = cbEquipoVisitante.SelectedItem.ToString(),
                Fecha = DateTime.Parse(txtFecha.Text)
            };

            partidos.Add(partido);
            MessageBox.Show("Partido registrado correctamente.");
            this.Close();
        }

        private void RegistrarPartidoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
