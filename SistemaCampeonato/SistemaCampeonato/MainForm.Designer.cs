namespace SistemaCampeonato
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpia los recursos que se están utilizando.
        /// </summary>
        /// <param name="disposing">True si los recursos administrados deben ser eliminados; de lo contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método requerido para la compatibilidad con el Diseñador.
        /// No se puede modificar el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegistrarEquipo = new Button();
            btnRegistrarPartido = new Button();
            btnTablaPosiciones = new Button();
            btnRegistrarJugador = new Button();
            SuspendLayout();
            // 
            // btnRegistrarEquipo
            // 
            btnRegistrarEquipo.Location = new Point(12, 12);
            btnRegistrarEquipo.Name = "btnRegistrarEquipo";
            btnRegistrarEquipo.Size = new Size(150, 40);
            btnRegistrarEquipo.TabIndex = 0;
            btnRegistrarEquipo.Text = "Registrar Equipo";
            btnRegistrarEquipo.UseVisualStyleBackColor = true;
            btnRegistrarEquipo.Click += btnRegistrarEquipo_Click;
            // 
            // btnRegistrarPartido
            // 
            btnRegistrarPartido.Location = new Point(12, 58);
            btnRegistrarPartido.Name = "btnRegistrarPartido";
            btnRegistrarPartido.Size = new Size(150, 40);
            btnRegistrarPartido.TabIndex = 1;
            btnRegistrarPartido.Text = "Registrar Partido";
            btnRegistrarPartido.UseVisualStyleBackColor = true;
            btnRegistrarPartido.Click += btnRegistrarPartido_Click;
            // 
            // btnTablaPosiciones
            // 
            btnTablaPosiciones.Location = new Point(12, 104);
            btnTablaPosiciones.Name = "btnTablaPosiciones";
            btnTablaPosiciones.Size = new Size(150, 40);
            btnTablaPosiciones.TabIndex = 2;
            btnTablaPosiciones.Text = "Ver Tabla de Posiciones";
            btnTablaPosiciones.UseVisualStyleBackColor = true;
            btnTablaPosiciones.Click += btnTablaPosiciones_Click;
            // 
            // btnRegistrarJugador
            // 
            btnRegistrarJugador.Location = new Point(12, 150);
            btnRegistrarJugador.Name = "btnRegistrarJugador";
            btnRegistrarJugador.Size = new Size(150, 40);
            btnRegistrarJugador.TabIndex = 3;
            btnRegistrarJugador.Text = "Registrar Jugador";
            btnRegistrarJugador.UseVisualStyleBackColor = true;
            btnRegistrarJugador.Click += btnRegistrarJugador_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(400, 600);
            Controls.Add(btnRegistrarJugador);
            Controls.Add(btnTablaPosiciones);
            Controls.Add(btnRegistrarPartido);
            Controls.Add(btnRegistrarEquipo);
            Name = "MainForm";
            Text = "Sistema Campeonato";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarEquipo;
        private System.Windows.Forms.Button btnRegistrarPartido;
        private System.Windows.Forms.Button btnTablaPosiciones;
        private System.Windows.Forms.Button btnRegistrarJugador;
    }
}
