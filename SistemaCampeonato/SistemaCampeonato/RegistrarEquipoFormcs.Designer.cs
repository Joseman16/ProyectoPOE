namespace SistemaCampeonato
{
    partial class RegistrarEquipoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtIdEquipo;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.TextBox txtFacultad;
        private System.Windows.Forms.Button btnGuardarEquipo;

        private void InitializeComponent()
        {
            txtIdEquipo = new TextBox();
            txtNombreEquipo = new TextBox();
            txtFacultad = new TextBox();
            btnGuardarEquipo = new Button();
            SuspendLayout();
            // 
            // txtIdEquipo
            // 
            txtIdEquipo.Location = new Point(120, 20);
            txtIdEquipo.Name = "txtIdEquipo";
            txtIdEquipo.Size = new Size(100, 23);
            txtIdEquipo.TabIndex = 0;
            // 
            // txtNombreEquipo
            // 
            txtNombreEquipo.Location = new Point(120, 50);
            txtNombreEquipo.Name = "txtNombreEquipo";
            txtNombreEquipo.Size = new Size(200, 23);
            txtNombreEquipo.TabIndex = 1;
            // 
            // txtFacultad
            // 
            txtFacultad.Location = new Point(120, 80);
            txtFacultad.Name = "txtFacultad";
            txtFacultad.Size = new Size(200, 23);
            txtFacultad.TabIndex = 2;
            // 
            // btnGuardarEquipo
            // 
            btnGuardarEquipo.Location = new Point(120, 120);
            btnGuardarEquipo.Name = "btnGuardarEquipo";
            btnGuardarEquipo.Size = new Size(120, 30);
            btnGuardarEquipo.TabIndex = 3;
            btnGuardarEquipo.Text = "Guardar Equipo";
            btnGuardarEquipo.Click += btnGuardarEquipo_Click;
            // 
            // RegistrarEquipoForm
            // 
            ClientSize = new Size(400, 200);
            Controls.Add(txtIdEquipo);
            Controls.Add(txtNombreEquipo);
            Controls.Add(txtFacultad);
            Controls.Add(btnGuardarEquipo);
            Name = "RegistrarEquipoForm";
            Text = "Registrar Equipo";
            Load += RegistrarEquipoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
