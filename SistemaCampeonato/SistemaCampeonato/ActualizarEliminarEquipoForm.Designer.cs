namespace SistemaCampeonato
{
    partial class ActualizarEliminarEquipoForm
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
            this.listBoxEquipos = new System.Windows.Forms.ListBox();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.txtNombreFacultad = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNombreEquipo = new System.Windows.Forms.Label();
            this.lblNombreFacultad = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // listBoxEquipos
            this.listBoxEquipos.FormattingEnabled = true;
            this.listBoxEquipos.Location = new System.Drawing.Point(12, 12);
            this.listBoxEquipos.Name = "listBoxEquipos";
            this.listBoxEquipos.Size = new System.Drawing.Size(250, 290);
            this.listBoxEquipos.TabIndex = 0;
            this.listBoxEquipos.SelectedIndexChanged += new System.EventHandler(this.listBoxEquipos_SelectedIndexChanged);

            // txtNombreEquipo
            this.txtNombreEquipo.Location = new System.Drawing.Point(300, 50);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(200, 20);
            this.txtNombreEquipo.TabIndex = 1;

            // txtNombreFacultad
            this.txtNombreFacultad.Location = new System.Drawing.Point(300, 100);
            this.txtNombreFacultad.Name = "txtNombreFacultad";
            this.txtNombreFacultad.Size = new System.Drawing.Size(200, 20);
            this.txtNombreFacultad.TabIndex = 2;

            // btnActualizar
            this.btnActualizar.Location = new System.Drawing.Point(300, 150);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(90, 30);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // btnEliminar
            this.btnEliminar.Location = new System.Drawing.Point(410, 150);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 30);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // lblNombreEquipo
            this.lblNombreEquipo.AutoSize = true;
            this.lblNombreEquipo.Location = new System.Drawing.Point(300, 30);
            this.lblNombreEquipo.Name = "lblNombreEquipo";
            this.lblNombreEquipo.Size = new System.Drawing.Size(87, 13);
            this.lblNombreEquipo.TabIndex = 5;
            this.lblNombreEquipo.Text = "Nombre del equipo:";

            // lblNombreFacultad
            this.lblNombreFacultad.AutoSize = true;
            this.lblNombreFacultad.Location = new System.Drawing.Point(300, 80);
            this.lblNombreFacultad.Name = "lblNombreFacultad";
            this.lblNombreFacultad.Size = new System.Drawing.Size(97, 13);
            this.lblNombreFacultad.TabIndex = 6;
            this.lblNombreFacultad.Text = "Nombre de facultad:";

            // ActualizarEliminarEquipoForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 320);
            this.Controls.Add(this.lblNombreFacultad);
            this.Controls.Add(this.lblNombreEquipo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtNombreFacultad);
            this.Controls.Add(this.txtNombreEquipo);
            this.Controls.Add(this.listBoxEquipos);
            this.Name = "ActualizarEliminarEquipoForm";
            this.Text = "Actualizar/Eliminar Equipo";
            this.Load += new System.EventHandler(this.ActualizarEliminarEquipoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ListBox listBoxEquipos;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.TextBox txtNombreFacultad;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNombreEquipo;
        private System.Windows.Forms.Label lblNombreFacultad;
    }
}
