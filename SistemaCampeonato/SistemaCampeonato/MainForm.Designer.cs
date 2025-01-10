namespace SistemaCampeonato
{
    partial class MainForm
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
            this.btnRegistrarEquipo = new System.Windows.Forms.Button();
            this.btnRegistrarPartido = new System.Windows.Forms.Button();
            this.btnRegistrarJugador = new System.Windows.Forms.Button();
            this.btnRegistrarResultado = new System.Windows.Forms.Button();
            this.btnTablaPosiciones = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // btnRegistrarEquipo
            this.btnRegistrarEquipo.Location = new System.Drawing.Point(30, 30);
            this.btnRegistrarEquipo.Name = "btnRegistrarEquipo";
            this.btnRegistrarEquipo.Size = new System.Drawing.Size(200, 40);
            this.btnRegistrarEquipo.TabIndex = 0;
            this.btnRegistrarEquipo.Text = "Registrar Equipo";
            this.btnRegistrarEquipo.UseVisualStyleBackColor = true;
            this.btnRegistrarEquipo.Click += new System.EventHandler(this.btnRegistrarEquipo_Click);

            // btnRegistrarPartido
            this.btnRegistrarPartido.Location = new System.Drawing.Point(30, 80);
            this.btnRegistrarPartido.Name = "btnRegistrarPartido";
            this.btnRegistrarPartido.Size = new System.Drawing.Size(200, 40);
            this.btnRegistrarPartido.TabIndex = 1;
            this.btnRegistrarPartido.Text = "Registrar Partido";
            this.btnRegistrarPartido.UseVisualStyleBackColor = true;
            this.btnRegistrarPartido.Click += new System.EventHandler(this.btnRegistrarPartido_Click);

            // btnRegistrarJugador
            this.btnRegistrarJugador.Location = new System.Drawing.Point(30, 130);
            this.btnRegistrarJugador.Name = "btnRegistrarJugador";
            this.btnRegistrarJugador.Size = new System.Drawing.Size(200, 40);
            this.btnRegistrarJugador.TabIndex = 2;
            this.btnRegistrarJugador.Text = "Registrar Jugador";
            this.btnRegistrarJugador.UseVisualStyleBackColor = true;
            this.btnRegistrarJugador.Click += new System.EventHandler(this.btnRegistrarJugador_Click);

            // btnRegistrarResultado
            this.btnRegistrarResultado.Location = new System.Drawing.Point(30, 180);
            this.btnRegistrarResultado.Name = "btnRegistrarResultado";
            this.btnRegistrarResultado.Size = new System.Drawing.Size(200, 40);
            this.btnRegistrarResultado.TabIndex = 3;
            this.btnRegistrarResultado.Text = "Registrar Resultado";
            this.btnRegistrarResultado.UseVisualStyleBackColor = true;
            this.btnRegistrarResultado.Click += new System.EventHandler(this.btnRegistrarResultado_Click);

            // btnTablaPosiciones
            this.btnTablaPosiciones.Location = new System.Drawing.Point(30, 230);
            this.btnTablaPosiciones.Name = "btnTablaPosiciones";
            this.btnTablaPosiciones.Size = new System.Drawing.Size(200, 40);
            this.btnTablaPosiciones.TabIndex = 4;
            this.btnTablaPosiciones.Text = "Tabla de Posiciones";
            this.btnTablaPosiciones.UseVisualStyleBackColor = true;
            this.btnTablaPosiciones.Click += new System.EventHandler(this.btnTablaPosiciones_Click);

            // MainForm
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.btnRegistrarEquipo);
            this.Controls.Add(this.btnRegistrarPartido);
            this.Controls.Add(this.btnRegistrarJugador);
            this.Controls.Add(this.btnRegistrarResultado);
            this.Controls.Add(this.btnTablaPosiciones);
            this.Name = "MainForm";
            this.Text = "Sistema Campeonato";
            this.Load += new System.EventHandler(this.MainForm_Load);

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnRegistrarEquipo;
        private System.Windows.Forms.Button btnRegistrarPartido;
        private System.Windows.Forms.Button btnRegistrarJugador;
        private System.Windows.Forms.Button btnRegistrarResultado;
        private System.Windows.Forms.Button btnTablaPosiciones;
    }
}
