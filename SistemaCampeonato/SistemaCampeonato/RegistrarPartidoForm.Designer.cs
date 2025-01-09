namespace SistemaCampeonato
{
    partial class RegistrarPartidoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbEquipoLocal;
        private System.Windows.Forms.ComboBox cbEquipoVisitante;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Button btnGuardarPartido;

        private void InitializeComponent()
        {
            cbEquipoLocal = new ComboBox();
            cbEquipoVisitante = new ComboBox();
            txtFecha = new TextBox();
            txtHora = new TextBox();
            btnGuardarPartido = new Button();
            SuspendLayout();
            // 
            // cbEquipoLocal
            // 
            cbEquipoLocal.Items.AddRange(new object[] { "Seleccione el equipo local" });
            cbEquipoLocal.Location = new Point(12, 12);
            cbEquipoLocal.Name = "cbEquipoLocal";
            cbEquipoLocal.Size = new Size(260, 23);
            cbEquipoLocal.TabIndex = 0;
            // 
            // cbEquipoVisitante
            // 
            cbEquipoVisitante.Items.AddRange(new object[] { "Seleccione el equipo visitante" });
            cbEquipoVisitante.Location = new Point(12, 41);
            cbEquipoVisitante.Name = "cbEquipoVisitante";
            cbEquipoVisitante.Size = new Size(260, 23);
            cbEquipoVisitante.TabIndex = 1;
            // 
            // txtFecha
            // 
            txtFecha.ForeColor = Color.Gray;
            txtFecha.Location = new Point(12, 70);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(260, 23);
            txtFecha.TabIndex = 2;
            txtFecha.Text = "Fecha (YYYY-MM-DD)";
            txtFecha.Enter += TxtFecha_Enter;
            txtFecha.Leave += TxtFecha_Leave;
            // 
            // txtHora
            // 
            txtHora.ForeColor = Color.Gray;
            txtHora.Location = new Point(12, 99);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(260, 23);
            txtHora.TabIndex = 3;
            txtHora.Text = "Hora (HH:MM)";
            txtHora.Enter += TxtHora_Enter;
            txtHora.Leave += TxtHora_Leave;
            // 
            // btnGuardarPartido
            // 
            btnGuardarPartido.Location = new Point(12, 128);
            btnGuardarPartido.Name = "btnGuardarPartido";
            btnGuardarPartido.Size = new Size(260, 23);
            btnGuardarPartido.TabIndex = 4;
            btnGuardarPartido.Text = "Guardar Partido";
            btnGuardarPartido.Click += btnGuardarPartido_Click;
            // 
            // RegistrarPartidoForm
            // 
            ClientSize = new Size(284, 161);
            Controls.Add(cbEquipoLocal);
            Controls.Add(cbEquipoVisitante);
            Controls.Add(txtFecha);
            Controls.Add(txtHora);
            Controls.Add(btnGuardarPartido);
            Name = "RegistrarPartidoForm";
            Text = "Registrar Partido";
            Load += RegistrarPartidoForm_Load;
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
