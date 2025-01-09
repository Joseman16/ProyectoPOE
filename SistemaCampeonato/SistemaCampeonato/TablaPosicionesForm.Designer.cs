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
            dgvTablaPosiciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTablaPosiciones.Location = new Point(20, 20);
            dgvTablaPosiciones.Name = "dgvTablaPosiciones";
            dgvTablaPosiciones.Size = new Size(500, 400);
            dgvTablaPosiciones.TabIndex = 0;
            // 
            // TablaPosicionesForm
            // 
            ClientSize = new Size(600, 450);
            Controls.Add(dgvTablaPosiciones);
            Name = "TablaPosicionesForm";
            Text = "Tabla de Posiciones";
            Load += TablaPosicionesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTablaPosiciones).EndInit();
            ResumeLayout(false);
        }
    }
}
