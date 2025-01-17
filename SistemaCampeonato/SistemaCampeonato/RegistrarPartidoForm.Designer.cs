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
            cbEquipoLocal = new ComboBox();
            cbEquipoVisitante = new ComboBox();
            txtFecha = new TextBox();
            txtHora = new TextBox();
            btnGuardarPartido = new Button();
            SuspendLayout();
            // 
            // cbEquipoLocal
            // 
            cbEquipoLocal.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEquipoLocal.FormattingEnabled = true;
            cbEquipoLocal.Location = new Point(44, 28);
            cbEquipoLocal.Name = "cbEquipoLocal";
            cbEquipoLocal.Size = new Size(176, 23);
            cbEquipoLocal.TabIndex = 0;
            // 
            // cbEquipoVisitante
            // 
            cbEquipoVisitante.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEquipoVisitante.FormattingEnabled = true;
            cbEquipoVisitante.Location = new Point(44, 75);
            cbEquipoVisitante.Name = "cbEquipoVisitante";
            cbEquipoVisitante.Size = new Size(176, 23);
            cbEquipoVisitante.TabIndex = 1;
            // 
            // txtFecha
            // 
            txtFecha.ForeColor = Color.Gray;
            txtFecha.Location = new Point(44, 122);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(176, 23);
            txtFecha.TabIndex = 2;
            txtFecha.Text = "Fecha (YYYY-MM-DD)";
            txtFecha.Enter += TxtFecha_Enter;
            txtFecha.Leave += TxtFecha_Leave;
            // 
            // txtHora
            // 
            txtHora.ForeColor = Color.Gray;
            txtHora.Location = new Point(44, 169);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(176, 23);
            txtHora.TabIndex = 3;
            txtHora.Text = "Hora (HH:MM)";
            txtHora.Enter += TxtHora_Enter;
            txtHora.Leave += TxtHora_Leave;
            // 
            // btnGuardarPartido
            // 
            btnGuardarPartido.Location = new Point(44, 216);
            btnGuardarPartido.Name = "btnGuardarPartido";
            btnGuardarPartido.Size = new Size(175, 28);
            btnGuardarPartido.TabIndex = 4;
            btnGuardarPartido.Text = "Guardar Partido";
            btnGuardarPartido.UseVisualStyleBackColor = true;
            btnGuardarPartido.Click += btnGuardarPartido_Click;
            // 
            // RegistrarPartidoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 281);
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
    }
}
