using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaCampeonato
{
    public partial class TablaPosicionesForm : Form
    {
        private List<TablaPosicion> tablaPosiciones;

        public TablaPosicionesForm(List<TablaPosicion> tablaPosiciones)
        {
            InitializeComponent();
            this.tablaPosiciones = tablaPosiciones;
            CargarTabla();
        }

        private void CargarTabla()
        {
            dgvTablaPosiciones.DataSource = null;
            dgvTablaPosiciones.DataSource = tablaPosiciones;
        }

        private void TablaPosicionesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
