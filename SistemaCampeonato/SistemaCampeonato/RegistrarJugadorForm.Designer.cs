namespace SistemaCampeonato
{
    partial class RegistrarJugadorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDorsal;
        private System.Windows.Forms.ComboBox cbPosicion;
        private System.Windows.Forms.ComboBox cbEquipos;
        private System.Windows.Forms.Button btnGuardarJugador;

        private void InitializeComponent()
        {
            txtCedula = new TextBox();
            txtNombre = new TextBox();
            txtDorsal = new TextBox();
            cbPosicion = new ComboBox();
            cbEquipos = new ComboBox();
            btnGuardarJugador = new Button();
            SuspendLayout();
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(12, 12);
            txtCedula.Name = "txtCedula";
            txtCedula.PlaceholderText = "Cédula";
            txtCedula.Size = new Size(260, 23);
            txtCedula.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 41);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre";
            txtNombre.Size = new Size(260, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtDorsal
            // 
            txtDorsal.Location = new Point(12, 70);
            txtDorsal.Name = "txtDorsal";
            txtDorsal.PlaceholderText = "Dorsal";
            txtDorsal.Size = new Size(260, 23);
            txtDorsal.TabIndex = 2;
            // 
            // cbPosicion
            // 
            cbPosicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPosicion.FormattingEnabled = true;
            cbPosicion.Location = new Point(12, 99);
            cbPosicion.Name = "cbPosicion";
            cbPosicion.Size = new Size(260, 23);
            cbPosicion.TabIndex = 3;
            // 
            // cbEquipos
            // 
            cbEquipos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEquipos.FormattingEnabled = true;
            cbEquipos.Location = new Point(12, 128);
            cbEquipos.Name = "cbEquipos";
            cbEquipos.Size = new Size(260, 23);
            cbEquipos.TabIndex = 4;
            // 
            // btnGuardarJugador
            // 
            btnGuardarJugador.Location = new Point(12, 157);
            btnGuardarJugador.Name = "btnGuardarJugador";
            btnGuardarJugador.Size = new Size(260, 23);
            btnGuardarJugador.TabIndex = 5;
            btnGuardarJugador.Text = "Guardar Jugador";
            btnGuardarJugador.Click += btnGuardarJugador_Click;
            // 
            // RegistrarJugadorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 191);
            Controls.Add(txtCedula);
            Controls.Add(txtNombre);
            Controls.Add(txtDorsal);
            Controls.Add(cbPosicion);
            Controls.Add(cbEquipos);
            Controls.Add(btnGuardarJugador);
            Name = "RegistrarJugadorForm";
            Text = "Registrar Jugador";
            Load += RegistrarJugadorForm_Load;
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
