namespace SistemaCampeonato
{
    partial class RegistrarPartidoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbEquipoLocal;
        private System.Windows.Forms.ComboBox cbEquipoVisitante;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnGuardarPartido;

        private void InitializeComponent()
        {
            cbEquipoLocal = new ComboBox();
            cbEquipoVisitante = new ComboBox();
            txtFecha = new TextBox();
            btnGuardarPartido = new Button();
            SuspendLayout();
            // 
            // cbEquipoLocal
            // 
            cbEquipoLocal.Location = new Point(120, 20);
            cbEquipoLocal.Name = "cbEquipoLocal";
            cbEquipoLocal.Size = new Size(200, 23);
            cbEquipoLocal.TabIndex = 0;
            // 
            // cbEquipoVisitante
            // 
            cbEquipoVisitante.Location = new Point(120, 50);
            cbEquipoVisitante.Name = "cbEquipoVisitante";
            cbEquipoVisitante.Size = new Size(200, 23);
            cbEquipoVisitante.TabIndex = 1;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(120, 80);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(200, 23);
            txtFecha.TabIndex = 2;
            // 
            // btnGuardarPartido
            // 
            btnGuardarPartido.Location = new Point(120, 120);
            btnGuardarPartido.Name = "btnGuardarPartido";
            btnGuardarPartido.Size = new Size(120, 30);
            btnGuardarPartido.TabIndex = 3;
            btnGuardarPartido.Text = "Guardar Partido";
            btnGuardarPartido.Click += btnGuardarPartido_Click;
            // 
            // RegistrarPartidoForm
            // 
            ClientSize = new Size(400, 200);
            Controls.Add(cbEquipoLocal);
            Controls.Add(cbEquipoVisitante);
            Controls.Add(txtFecha);
            Controls.Add(btnGuardarPartido);
            Name = "RegistrarPartidoForm";
            Text = "Registrar Partido";
            Load += RegistrarPartidoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
