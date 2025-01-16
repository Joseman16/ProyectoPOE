namespace SistemaCampeonato
{
    partial class RegistrarJugadorForm
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
            lblEquipo = new Label();
            cbEquipos = new ComboBox();
            lblCedula = new Label();
            txtCedula = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDorsal = new Label();
            txtDorsal = new TextBox();
            lblPosicion = new Label();
            cbPosicion = new ComboBox();
            btnGuardarJugador = new Button();
            SuspendLayout();
            // 
            // lblEquipo
            // 
            lblEquipo.AutoSize = true;
            lblEquipo.Location = new Point(30, 30);
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(47, 15);
            lblEquipo.TabIndex = 0;
            lblEquipo.Text = "Equipo:";
            // 
            // cbEquipos
            // 
            cbEquipos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEquipos.FormattingEnabled = true;
            cbEquipos.Location = new Point(150, 27);
            cbEquipos.Name = "cbEquipos";
            cbEquipos.Size = new Size(200, 23);
            cbEquipos.TabIndex = 1;
            // 
            // lblCedula
            // 
            lblCedula.AutoSize = true;
            lblCedula.Location = new Point(30, 70);
            lblCedula.Name = "lblCedula";
            lblCedula.Size = new Size(47, 15);
            lblCedula.TabIndex = 2;
            lblCedula.Text = "Cédula:";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(150, 67);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(200, 23);
            txtCedula.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(30, 110);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 5;
            // 
            // lblDorsal
            // 
            lblDorsal.AutoSize = true;
            lblDorsal.Location = new Point(30, 150);
            lblDorsal.Name = "lblDorsal";
            lblDorsal.Size = new Size(43, 15);
            lblDorsal.TabIndex = 6;
            lblDorsal.Text = "Dorsal:";
            // 
            // txtDorsal
            // 
            txtDorsal.Location = new Point(150, 147);
            txtDorsal.Name = "txtDorsal";
            txtDorsal.Size = new Size(50, 23);
            txtDorsal.TabIndex = 7;
            // 
            // lblPosicion
            // 
            lblPosicion.AutoSize = true;
            lblPosicion.Location = new Point(30, 190);
            lblPosicion.Name = "lblPosicion";
            lblPosicion.Size = new Size(55, 15);
            lblPosicion.TabIndex = 8;
            lblPosicion.Text = "Posición:";
            // 
            // cbPosicion
            // 
            cbPosicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPosicion.FormattingEnabled = true;
            cbPosicion.Location = new Point(150, 187);
            cbPosicion.Name = "cbPosicion";
            cbPosicion.Size = new Size(200, 23);
            cbPosicion.TabIndex = 9;
            // 
            // btnGuardarJugador
            // 
            btnGuardarJugador.Location = new Point(150, 230);
            btnGuardarJugador.Name = "btnGuardarJugador";
            btnGuardarJugador.Size = new Size(100, 30);
            btnGuardarJugador.TabIndex = 10;
            btnGuardarJugador.Text = "Guardar";
            btnGuardarJugador.UseVisualStyleBackColor = true;
            btnGuardarJugador.Click += btnGuardarJugador_Click;
            // 
            // RegistrarJugadorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 300);
            Controls.Add(lblEquipo);
            Controls.Add(cbEquipos);
            Controls.Add(lblCedula);
            Controls.Add(txtCedula);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblDorsal);
            Controls.Add(txtDorsal);
            Controls.Add(lblPosicion);
            Controls.Add(cbPosicion);
            Controls.Add(btnGuardarJugador);
            Name = "RegistrarJugadorForm";
            Text = "Registrar Jugador";
            Load += RegistrarJugadorForm_Load; // Asocia el evento Load
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblEquipo;
        private ComboBox cbEquipos;
        private Label lblCedula;
        private TextBox txtCedula;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDorsal;
        private TextBox txtDorsal;
        private Label lblPosicion;
        private ComboBox cbPosicion;
        private Button btnGuardarJugador;
    }
}
