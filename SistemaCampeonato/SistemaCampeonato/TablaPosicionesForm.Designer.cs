namespace SistemaCampeonato
{
    partial class TablaPosicionesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvTablaPosiciones;

        private void InitializeComponent()
        {
            dgvTablaPosiciones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTablaPosiciones).BeginInit();
            SuspendLayout();
            // 
            // dgvTablaPosiciones
            // 
            dgvTablaPosiciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaPosiciones.Location = new Point(12, 12);
            dgvTablaPosiciones.Name = "dgvTablaPosiciones";
            dgvTablaPosiciones.Size = new Size(360, 237);
            dgvTablaPosiciones.TabIndex = 0;
            dgvTablaPosiciones.CellContentClick += dgvTablaPosiciones_CellContentClick;
            // 
            // TablaPosicionesForm
            // 
            ClientSize = new Size(384, 261);
            Controls.Add(dgvTablaPosiciones);
            Name = "TablaPosicionesForm";
            Text = "Tabla de Posiciones";
            Load += TablaPosicionesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTablaPosiciones).EndInit();
            ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
