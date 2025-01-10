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
            this.lblEquipo = new System.Windows.Forms.Label();
            this.cbEquipos = new System.Windows.Forms.ComboBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblDorsal = new System.Windows.Forms.Label();
            this.txtDorsal = new System.Windows.Forms.TextBox();
            this.lblPosicion = new System.Windows.Forms.Label();
            this.cbPosicion = new System.Windows.Forms.ComboBox();
            this.btnGuardarJugador = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(30, 30);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(47, 15);
            this.lblEquipo.TabIndex = 0;
            this.lblEquipo.Text = "Equipo:";
            // 
            // cbEquipos
            // 
            this.cbEquipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEquipos.FormattingEnabled = true;
            this.cbEquipos.Location = new System.Drawing.Point(150, 27);
            this.cbEquipos.Name = "cbEquipos";
            this.cbEquipos.Size = new System.Drawing.Size(200, 23);
            this.cbEquipos.TabIndex = 1;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(30, 70);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(49, 15);
            this.lblCedula.TabIndex = 2;
            this.lblCedula.Text = "Cédula:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(150, 67);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(200, 23);
            this.txtCedula.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 110);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 107);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            this.txtNombre.TabIndex = 5;
            // 
            // lblDorsal
            // 
            this.lblDorsal.AutoSize = true;
            this.lblDorsal.Location = new System.Drawing.Point(30, 150);
            this.lblDorsal.Name = "lblDorsal";
            this.lblDorsal.Size = new System.Drawing.Size(44, 15);
            this.lblDorsal.TabIndex = 6;
            this.lblDorsal.Text = "Dorsal:";
            // 
            // txtDorsal
            // 
            this.txtDorsal.Location = new System.Drawing.Point(150, 147);
            this.txtDorsal.Name = "txtDorsal";
            this.txtDorsal.Size = new System.Drawing.Size(50, 23);
            this.txtDorsal.TabIndex = 7;
            // 
            // lblPosicion
            // 
            this.lblPosicion.AutoSize = true;
            this.lblPosicion.Location = new System.Drawing.Point(30, 190);
            this.lblPosicion.Name = "lblPosicion";
            this.lblPosicion.Size = new System.Drawing.Size(55, 15);
            this.lblPosicion.TabIndex = 8;
            this.lblPosicion.Text = "Posición:";
            // 
            // cbPosicion
            // 
            this.cbPosicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosicion.FormattingEnabled = true;
            this.cbPosicion.Location = new System.Drawing.Point(150, 187);
            this.cbPosicion.Name = "cbPosicion";
            this.cbPosicion.Size = new System.Drawing.Size(200, 23);
            this.cbPosicion.TabIndex = 9;
            // 
            // btnGuardarJugador
            // 
            this.btnGuardarJugador.Location = new System.Drawing.Point(150, 230);
            this.btnGuardarJugador.Name = "btnGuardarJugador";
            this.btnGuardarJugador.Size = new System.Drawing.Size(100, 30);
            this.btnGuardarJugador.TabIndex = 10;
            this.btnGuardarJugador.Text = "Guardar";
            this.btnGuardarJugador.UseVisualStyleBackColor = true;
            this.btnGuardarJugador.Click += new System.EventHandler(this.btnGuardarJugador_Click);
            // 
            // RegistrarJugadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.cbEquipos);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDorsal);
            this.Controls.Add(this.txtDorsal);
            this.Controls.Add(this.lblPosicion);
            this.Controls.Add(this.cbPosicion);
            this.Controls.Add(this.btnGuardarJugador);
            this.Name = "RegistrarJugadorForm";
            this.Text = "Registrar Jugador";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.ComboBox cbEquipos;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDorsal;
        private System.Windows.Forms.TextBox txtDorsal;
        private System.Windows.Forms.Label lblPosicion;
        private System.Windows.Forms.ComboBox cbPosicion;
        private System.Windows.Forms.Button btnGuardarJugador;
    }
}
