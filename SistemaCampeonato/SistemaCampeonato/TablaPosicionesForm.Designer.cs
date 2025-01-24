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
            this.listBoxTablaPosiciones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxTablaPosiciones
            // 
            this.listBoxTablaPosiciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTablaPosiciones.FormattingEnabled = true;
            this.listBoxTablaPosiciones.ItemHeight = 15;
            this.listBoxTablaPosiciones.Location = new System.Drawing.Point(0, 0);
            this.listBoxTablaPosiciones.Name = "listBoxTablaPosiciones";
            this.listBoxTablaPosiciones.Size = new System.Drawing.Size(800, 450);
            this.listBoxTablaPosiciones.TabIndex = 0;
            // 
            // TablaPosicionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxTablaPosiciones);
            this.Name = "TablaPosicionesForm";
            this.Text = "Tabla de Posiciones";
            this.Load += new System.EventHandler(this.TablaPosicionesForm_Load);
            this.ResumeLayout(false);
        }
    }
}
