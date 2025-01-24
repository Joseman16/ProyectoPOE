namespace SistemaCampeonato
{
    partial class ActualizarEliminarJugadorForm
    {
        private System.ComponentModel.IContainer components = null;

        // Disposes of resources
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
            this.listBoxJugadores = new System.Windows.Forms.ListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDorsal = new System.Windows.Forms.TextBox();
            this.txtIdPosicion = new System.Windows.Forms.TextBox();
            this.txtIdEquipo = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDorsal = new System.Windows.Forms.Label();
            this.lblIdPosicion = new System.Windows.Forms.Label();
            this.lblIdEquipo = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // listBoxJugadores
            this.listBoxJugadores.FormattingEnabled = true;
            this.listBoxJugadores.Location = new System.Drawing.Point(12, 12);
            this.listBoxJugadores.Name = "listBoxJugadores";
            this.listBoxJugadores.Size = new System.Drawing.Size(250, 290);
            this.listBoxJugadores.TabIndex = 0;
            this.listBoxJugadores.SelectedIndexChanged += new System.EventHandler(this.listBoxJugadores_SelectedIndexChanged);

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(300, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 1;

            // txtDorsal
            this.txtDorsal.Location = new System.Drawing.Point(300, 80);
            this.txtDorsal.Name = "txtDorsal";
            this.txtDorsal.Size = new System.Drawing.Size(200, 20);
            this.txtDorsal.TabIndex = 2;

            // txtIdPosicion
            this.txtIdPosicion.Location = new System.Drawing.Point(300, 130);
            this.txtIdPosicion.Name = "txtIdPosicion";
            this.txtIdPosicion.Size = new System.Drawing.Size(200, 20);
            this.txtIdPosicion.TabIndex = 3;

            // txtIdEquipo
            this.txtIdEquipo.Location = new System.Drawing.Point(300, 180);
            this.txtIdEquipo.Name = "txtIdEquipo";
            this.txtIdEquipo.Size = new System.Drawing.Size(200, 20);
            this.txtIdEquipo.TabIndex = 4;

            // btnActualizar
            this.btnActualizar.Location = new System.Drawing.Point(300, 230);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(90, 30);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // btnEliminar
            this.btnEliminar.Location = new System.Drawing.Point(410, 230);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 30);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(300, 10);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";

            // lblDorsal
            this.lblDorsal.AutoSize = true;
            this.lblDorsal.Location = new System.Drawing.Point(300, 60);
            this.lblDorsal.Name = "lblDorsal";
            this.lblDorsal.Size = new System.Drawing.Size(39, 13);
            this.lblDorsal.TabIndex = 8;
            this.lblDorsal.Text = "Dorsal:";

            // lblIdPosicion
            this.lblIdPosicion.AutoSize = true;
            this.lblIdPosicion.Location = new System.Drawing.Point(300, 110);
            this.lblIdPosicion.Name = "lblIdPosicion";
            this.lblIdPosicion.Size = new System.Drawing.Size(62, 13);
            this.lblIdPosicion.TabIndex = 9;
            this.lblIdPosicion.Text = "ID Posición:";

            // lblIdEquipo
            this.lblIdEquipo.AutoSize = true;
            this.lblIdEquipo.Location = new System.Drawing.Point(300, 160);
            this.lblIdEquipo.Name = "lblIdEquipo";
            this.lblIdEquipo.Size = new System.Drawing.Size(57, 13);
            this.lblIdEquipo.TabIndex = 10;
            this.lblIdEquipo.Text = "ID Equipo:";

            // ActualizarEliminarJugadorForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 320);
            this.Controls.Add(this.lblIdEquipo);
            this.Controls.Add(this.lblIdPosicion);
            this.Controls.Add(this.lblDorsal);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtIdEquipo);
            this.Controls.Add(this.txtIdPosicion);
            this.Controls.Add(this.txtDorsal);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.listBoxJugadores);
            this.Name = "ActualizarEliminarJugadorForm";
            this.Text = "Actualizar/Eliminar Jugador";
            this.Load += new System.EventHandler(this.ActualizarEliminarJugadorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox listBoxJugadores;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDorsal;
        private System.Windows.Forms.TextBox txtIdPosicion;
        private System.Windows.Forms.TextBox txtIdEquipo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDorsal;
        private System.Windows.Forms.Label lblIdPosicion;
        private System.Windows.Forms.Label lblIdEquipo;
    }
}
