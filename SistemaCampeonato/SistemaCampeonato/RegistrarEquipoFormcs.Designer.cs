namespace SistemaCampeonato
{
    partial class RegistrarEquipoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtIdEquipo;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.TextBox txtFacultad;
        private System.Windows.Forms.Button btnGuardarEquipo;
        private System.Windows.Forms.Button btnAgregarJugador;

        private void InitializeComponent()
        {
            txtIdEquipo = new TextBox();
            txtNombreEquipo = new TextBox();
            txtFacultad = new TextBox();
            btnGuardarEquipo = new Button();
            btnAgregarJugador = new Button();
            SuspendLayout();
            // 
            // txtIdEquipo
            // 
            txtIdEquipo.Location = new Point(12, 12);
            txtIdEquipo.Name = "txtIdEquipo";
            txtIdEquipo.PlaceholderText = "ID del Equipo";
            txtIdEquipo.Size = new Size(260, 23);
            txtIdEquipo.TabIndex = 0;
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(12, 41);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.PlaceholderText = "Nombre del Equipo";
            txtNombreEquipo.Size = new Size(260, 23);
            txtNombreEquipo.TabIndex = 1;
            // 
            // txtFacultad
            // 
            txtFacultad.Location = new Point(12, 70);
            txtFacultad.Name = "txtFacultad";
            txtFacultad.PlaceholderText = "Nombre de la Facultad";
            txtFacultad.Size = new Size(260, 23);
            txtFacultad.TabIndex = 2;
            txtFacultad.TextChanged += txtFacultad_TextChanged;
            // 
            // btnGuardarEquipo
            // 
            btnGuardarEquipo.Location = new Point(12, 99);
            btnGuardarEquipo.Name = "btnGuardarEquipo";
            btnGuardarEquipo.Size = new Size(126, 23);
            btnGuardarEquipo.TabIndex = 3;
            btnGuardarEquipo.Text = "Guardar Equipo";
            btnGuardarEquipo.Click += btnGuardarEquipo_Click;
            // 
            // btnAgregarJugador
            // 
            btnAgregarJugador.Location = new Point(144, 99);
            btnAgregarJugador.Name = "btnAgregarJugador";
            btnAgregarJugador.Size = new Size(128, 23);
            btnAgregarJugador.TabIndex = 4;
            btnAgregarJugador.Text = "Agregar Jugador";
            btnAgregarJugador.Click += btnAgregarJugador_Click;
            // 
            // RegistrarEquipoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 131);
            Controls.Add(txtIdEquipo);
            Controls.Add(txtNombreEquipo);
            Controls.Add(txtFacultad);
            Controls.Add(btnGuardarEquipo);
            Controls.Add(btnAgregarJugador);
            Name = "RegistrarEquipoForm";
            Text = "Registrar Equipo";
            Load += RegistrarEquipoForm_Load;
            ResumeLayout(false);
            PerformLayout();
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
