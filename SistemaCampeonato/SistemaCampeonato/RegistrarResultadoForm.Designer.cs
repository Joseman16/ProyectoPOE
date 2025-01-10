namespace SistemaCampeonato
{
    partial class RegistrarResultadoForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            comboBoxPartidos = new System.Windows.Forms.ComboBox();
            labelPartido = new System.Windows.Forms.Label();
            numericGolesLocal = new System.Windows.Forms.NumericUpDown();
            numericGolesVisitante = new System.Windows.Forms.NumericUpDown();
            labelGolesLocal = new System.Windows.Forms.Label();
            labelGolesVisitante = new System.Windows.Forms.Label();
            buttonRegistrar = new System.Windows.Forms.Button();
            listBoxTablaPosiciones = new System.Windows.Forms.ListBox();
            labelTablaPosiciones = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(numericGolesLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(numericGolesVisitante)).BeginInit();
            this.SuspendLayout();

            // ComboBox - Partidos
            comboBoxPartidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxPartidos.FormattingEnabled = true;
            comboBoxPartidos.Location = new System.Drawing.Point(150, 30);
            comboBoxPartidos.Name = "comboBoxPartidos";
            comboBoxPartidos.Size = new System.Drawing.Size(300, 23);
            comboBoxPartidos.TabIndex = 0;

            // Label - Seleccionar Partido
            labelPartido.AutoSize = true;
            labelPartido.Location = new System.Drawing.Point(30, 33);
            labelPartido.Name = "labelPartido";
            labelPartido.Size = new System.Drawing.Size(108, 15);
            labelPartido.TabIndex = 1;
            labelPartido.Text = "Seleccionar Partido";

            // Numeric - Goles Local
            numericGolesLocal.Location = new System.Drawing.Point(150, 80);
            numericGolesLocal.Name = "numericGolesLocal";
            numericGolesLocal.Size = new System.Drawing.Size(50, 23);
            numericGolesLocal.TabIndex = 2;

            // Numeric - Goles Visitante
            numericGolesVisitante.Location = new System.Drawing.Point(150, 130);
            numericGolesVisitante.Name = "numericGolesVisitante";
            numericGolesVisitante.Size = new System.Drawing.Size(50, 23);
            numericGolesVisitante.TabIndex = 3;

            // Label - Goles Local
            labelGolesLocal.AutoSize = true;
            labelGolesLocal.Location = new System.Drawing.Point(30, 82);
            labelGolesLocal.Name = "labelGolesLocal";
            labelGolesLocal.Size = new System.Drawing.Size(67, 15);
            labelGolesLocal.TabIndex = 4;
            labelGolesLocal.Text = "Goles Local";

            // Label - Goles Visitante
            labelGolesVisitante.AutoSize = true;
            labelGolesVisitante.Location = new System.Drawing.Point(30, 132);
            labelGolesVisitante.Name = "labelGolesVisitante";
            labelGolesVisitante.Size = new System.Drawing.Size(84, 15);
            labelGolesVisitante.TabIndex = 5;
            labelGolesVisitante.Text = "Goles Visitante";

            // Button - Registrar
            buttonRegistrar.Location = new System.Drawing.Point(150, 180);
            buttonRegistrar.Name = "buttonRegistrar";
            buttonRegistrar.Size = new System.Drawing.Size(100, 30);
            buttonRegistrar.TabIndex = 6;
            buttonRegistrar.Text = "Registrar";
            buttonRegistrar.UseVisualStyleBackColor = true;

            // ListBox - Tabla de Posiciones
            listBoxTablaPosiciones.FormattingEnabled = true;
            listBoxTablaPosiciones.ItemHeight = 15;
            listBoxTablaPosiciones.Location = new System.Drawing.Point(30, 250);
            listBoxTablaPosiciones.Name = "listBoxTablaPosiciones";
            listBoxTablaPosiciones.Size = new System.Drawing.Size(420, 150);
            listBoxTablaPosiciones.TabIndex = 7;

            // Label - Tabla de Posiciones
            labelTablaPosiciones.AutoSize = true;
            labelTablaPosiciones.Location = new System.Drawing.Point(30, 230);
            labelTablaPosiciones.Name = "labelTablaPosiciones";
            labelTablaPosiciones.Size = new System.Drawing.Size(108, 15);
            labelTablaPosiciones.TabIndex = 8;
            labelTablaPosiciones.Text = "Tabla de Posiciones";

            // RegistrarResultadoForm
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(comboBoxPartidos);
            this.Controls.Add(labelPartido);
            this.Controls.Add(numericGolesLocal);
            this.Controls.Add(numericGolesVisitante);
            this.Controls.Add(labelGolesLocal);
            this.Controls.Add(labelGolesVisitante);
            this.Controls.Add(buttonRegistrar);
            this.Controls.Add(listBoxTablaPosiciones);
            this.Controls.Add(labelTablaPosiciones);
            this.Name = "RegistrarResultadoForm";
            this.Text = "Registrar Resultado";
            this.Load += new System.EventHandler(this.RegistrarResultadoForm_Load);
            buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);

            ((System.ComponentModel.ISupportInitialize)(numericGolesLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(numericGolesVisitante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxPartidos;
        private System.Windows.Forms.Label labelPartido;
        private System.Windows.Forms.NumericUpDown numericGolesLocal;
        private System.Windows.Forms.NumericUpDown numericGolesVisitante;
        private System.Windows.Forms.Label labelGolesLocal;
        private System.Windows.Forms.Label labelGolesVisitante;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.ListBox listBoxTablaPosiciones;
        private System.Windows.Forms.Label labelTablaPosiciones;
    }
}
