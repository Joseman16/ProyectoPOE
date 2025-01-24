namespace SistemaCampeonato
{
    partial class TablaPosicionesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxTablaPosiciones;

        /// <summary>
        /// Limpia los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Método requerido para admitir el Diseñador de Windows Forms.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxTablaPosiciones = new ListBox();
            SuspendLayout();
            // 
            // listBoxTablaPosiciones
            // 
            listBoxTablaPosiciones.Dock = DockStyle.Fill;
            listBoxTablaPosiciones.FormattingEnabled = true;
            listBoxTablaPosiciones.ItemHeight = 15;
            listBoxTablaPosiciones.Location = new Point(0, 0);
            listBoxTablaPosiciones.Name = "listBoxTablaPosiciones";
            listBoxTablaPosiciones.Size = new Size(800, 450);
            listBoxTablaPosiciones.TabIndex = 0;
            listBoxTablaPosiciones.SelectedIndexChanged += listBoxTablaPosiciones_SelectedIndexChanged;
            // 
            // TablaPosicionesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxTablaPosiciones);
            Name = "TablaPosicionesForm";
            Text = "Tabla de Posiciones";
            Load += TablaPosicionesForm_Load;
            ResumeLayout(false);
        }
    }
}
