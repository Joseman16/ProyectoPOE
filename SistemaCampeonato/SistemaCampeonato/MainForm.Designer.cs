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
            btnRegistrarEquipo = new Button();
            btnRegistrarPartido = new Button();
            btnRegistrarJugador = new Button();
            btnRegistrarResultado = new Button();
            btnTablaPosiciones = new Button();
            gif1 = new PictureBox();
            btnOpciones = new Button();
            ((System.ComponentModel.ISupportInitialize)gif1).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrarEquipo
            // 
            btnRegistrarEquipo.Cursor = Cursors.Hand;
            btnRegistrarEquipo.Location = new Point(21, 12);
            btnRegistrarEquipo.Name = "btnRegistrarEquipo";
            btnRegistrarEquipo.Size = new Size(200, 40);
            btnRegistrarEquipo.TabIndex = 0;
            btnRegistrarEquipo.Text = "Registrar Equipo";
            btnRegistrarEquipo.UseVisualStyleBackColor = true;
            btnRegistrarEquipo.Click += btnRegistrarEquipo_Click;
            // 
            // btnRegistrarPartido
            // 
            btnRegistrarPartido.Cursor = Cursors.Hand;
            btnRegistrarPartido.Location = new Point(21, 104);
            btnRegistrarPartido.Name = "btnRegistrarPartido";
            btnRegistrarPartido.Size = new Size(200, 40);
            btnRegistrarPartido.TabIndex = 1;
            btnRegistrarPartido.Text = "Registrar Partido";
            btnRegistrarPartido.UseVisualStyleBackColor = true;
            btnRegistrarPartido.Click += btnRegistrarPartido_Click;
            // 
            // btnRegistrarJugador
            // 
            btnRegistrarJugador.Cursor = Cursors.Hand;
            btnRegistrarJugador.Location = new Point(21, 58);
            btnRegistrarJugador.Name = "btnRegistrarJugador";
            btnRegistrarJugador.Size = new Size(200, 40);
            btnRegistrarJugador.TabIndex = 2;
            btnRegistrarJugador.Text = "Registrar Jugador";
            btnRegistrarJugador.UseVisualStyleBackColor = true;
            btnRegistrarJugador.Click += btnRegistrarJugador_Click;
            // 
            // btnRegistrarResultado
            // 
            btnRegistrarResultado.Cursor = Cursors.Hand;
            btnRegistrarResultado.Location = new Point(21, 150);
            btnRegistrarResultado.Name = "btnRegistrarResultado";
            btnRegistrarResultado.Size = new Size(200, 40);
            btnRegistrarResultado.TabIndex = 3;
            btnRegistrarResultado.Text = "Registrar Resultado";
            btnRegistrarResultado.UseVisualStyleBackColor = true;
            btnRegistrarResultado.Click += btnRegistrarResultado_Click;
            // 
            // btnTablaPosiciones
            // 
            btnTablaPosiciones.Cursor = Cursors.Hand;
            btnTablaPosiciones.Location = new Point(21, 196);
            btnTablaPosiciones.Name = "btnTablaPosiciones";
            btnTablaPosiciones.Size = new Size(200, 40);
            btnTablaPosiciones.TabIndex = 4;
            btnTablaPosiciones.Text = "Tabla de Posiciones";
            btnTablaPosiciones.UseVisualStyleBackColor = true;
            btnTablaPosiciones.Click += btnTablaPosiciones_Click;
            // 
            // gif1
            // 
            gif1.Location = new Point(236, -1);
            gif1.Name = "gif1";
            gif1.Size = new Size(448, 377);
            gif1.TabIndex = 5;
            gif1.TabStop = false;
            gif1.Click += gif1_Click;
            // 
            // btnOpciones
            // 
            btnOpciones.Cursor = Cursors.Hand;
            btnOpciones.Location = new Point(21, 318);
            btnOpciones.Name = "btnOpciones";
            btnOpciones.Size = new Size(200, 40);
            btnOpciones.TabIndex = 6;
            btnOpciones.Text = "Más opciones";
            btnOpciones.UseVisualStyleBackColor = true;
            btnOpciones.Click += button1_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(682, 370);
            Controls.Add(btnOpciones);
            Controls.Add(gif1);
            Controls.Add(btnRegistrarEquipo);
            Controls.Add(btnRegistrarPartido);
            Controls.Add(btnRegistrarJugador);
            Controls.Add(btnRegistrarResultado);
            Controls.Add(btnTablaPosiciones);
            Name = "MainForm";
            Text = "Sistema Campeonato";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)gif1).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnRegistrarEquipo;
        private System.Windows.Forms.Button btnRegistrarPartido;
        private System.Windows.Forms.Button btnRegistrarJugador;
        private System.Windows.Forms.Button btnRegistrarResultado;
        private System.Windows.Forms.Button btnTablaPosiciones;
        private PictureBox gif1;
        private Button btnOpciones;
    }
}
