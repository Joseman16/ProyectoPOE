using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaCampeonato
{
    public partial class RegistrarResultadoForm : Form
    {
        private List<Partidos> _partidos;
        private List<TablaPosicion> _tablaPosiciones;

        public RegistrarResultadoForm(List<Partidos> partidos, List<TablaPosicion> tablaPosiciones)
        {
            InitializeComponent();
            _partidos = partidos;
            _tablaPosiciones = tablaPosiciones;
        }

        private void RegistrarResultadoForm_Load(object sender, EventArgs e)
        {
            comboBoxPartidos.Items.Clear();
            foreach (var partido in _partidos)
            {
                comboBoxPartidos.Items.Add($"{partido.IdPartido}: {partido.EquipoLocal.NombreEquipo} vs {partido.EquipoVisitante.NombreEquipo}");
            }
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (comboBoxPartidos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un partido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var partidoSeleccionado = _partidos[comboBoxPartidos.SelectedIndex];
            int golesLocal = (int)numericGolesLocal.Value;
            int golesVisitante = (int)numericGolesVisitante.Value;

            // Crear resultado
            var resultado = new Resultados(0, partidoSeleccionado, golesLocal, golesVisitante);

            // Actualizar tabla de posiciones
            foreach (var equipoPosicion in _tablaPosiciones)
            {
                equipoPosicion.ActualizarTabla(resultado);
            }

            // Actualizar ListBox
            listBoxTablaPosiciones.Items.Clear();
            foreach (var posicion in _tablaPosiciones)
            {
                listBoxTablaPosiciones.Items.Add(posicion.ToString());
            }

            MessageBox.Show($"Resultado registrado:\n{resultado}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
