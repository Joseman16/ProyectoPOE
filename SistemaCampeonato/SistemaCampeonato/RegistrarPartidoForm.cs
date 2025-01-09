using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaCampeonato
{
    public partial class RegistrarPartidoForm : Form
    {
        private List<Partidos> partidos;
        private List<Equipo> equipos;

        public RegistrarPartidoForm(List<Equipo> equipos, List<Partidos> partidos)
        {
            InitializeComponent();
            this.equipos = equipos;
            this.partidos = partidos;
            CargarEquipos();
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

            cbEquipoLocal.SelectedIndex = 0;
            cbEquipoVisitante.SelectedIndex = 0;
        }

        private void btnGuardarPartido_Click(object sender, EventArgs e)
        {
            if (cbEquipoLocal.SelectedItem == null || cbEquipoVisitante.SelectedItem == null ||
                txtFecha.Text == "Fecha (YYYY-MM-DD)" || txtHora.Text == "Hora (HH:MM)")
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return;
            }

            var partido = new Partidos
            {
                EquipoLocal = equipos.Find(e => e.NombreEquipo == cbEquipoLocal.SelectedItem.ToString()),
                EquipoVisitante = equipos.Find(e => e.NombreEquipo == cbEquipoVisitante.SelectedItem.ToString()),
                Fecha = DateTime.Parse(txtFecha.Text),
                Hora = TimeSpan.Parse(txtHora.Text)
            };

            partidos.Add(partido);
            MessageBox.Show("Partido registrado correctamente.");
            this.Close();
        }

        private void TxtFecha_Enter(object sender, EventArgs e)
        {
            if (txtFecha.Text == "Fecha (YYYY-MM-DD)")
            {
                txtFecha.Text = "";
                txtFecha.ForeColor = Color.Black;
            }
        }

        private void TxtFecha_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFecha.Text))
            {
                txtFecha.Text = "Fecha (YYYY-MM-DD)";
                txtFecha.ForeColor = Color.Gray;
            }
        }

        private void TxtHora_Enter(object sender, EventArgs e)
        {
            if (txtHora.Text == "Hora (HH:MM)")
            {
                txtHora.Text = "";
                txtHora.ForeColor = Color.Black;
            }
        }

        private void TxtHora_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHora.Text))
            {
                txtHora.Text = "Hora (HH:MM)";
                txtHora.ForeColor = Color.Gray;
            }
        }

        private void RegistrarPartidoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
