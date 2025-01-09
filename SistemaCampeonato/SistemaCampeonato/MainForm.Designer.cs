namespace SistemaCampeonato
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRegistrarEquipo = new System.Windows.Forms.Button();
            this.btnRegistrarPartido = new System.Windows.Forms.Button();
            this.btnTablaPosiciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarEquipo
            // 
            this.btnRegistrarEquipo.Location = new System.Drawing.Point(100, 50);
            this.btnRegistrarEquipo.Name = "btnRegistrarEquipo";
            this.btnRegistrarEquipo.Size = new System.Drawing.Size(200, 40);
            this.btnRegistrarEquipo.TabIndex = 0;
            this.btnRegistrarEquipo.Text = "Registrar Equipo";
            this.btnRegistrarEquipo.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarPartido
            // 
            this.btnRegistrarPartido.Location = new System.Drawing.Point(100, 110);
            this.btnRegistrarPartido.Name = "btnRegistrarPartido";
            this.btnRegistrarPartido.Size = new System.Drawing.Size(200, 40);
            this.btnRegistrarPartido.TabIndex = 1;
            this.btnRegistrarPartido.Text = "Registrar Partido";
            this.btnRegistrarPartido.UseVisualStyleBackColor = true;
            // 
            // btnTablaPosiciones
            // 
            this.btnTablaPosiciones.Location = new System.Drawing.Point(100, 170);
            this.btnTablaPosiciones.Name = "btnTablaPosiciones";
            this.btnTablaPosiciones.Size = new System.Drawing.Size(200, 40);
            this.btnTablaPosiciones.TabIndex = 2;
            this.btnTablaPosiciones.Text = "Tabla de Posiciones";
            this.btnTablaPosiciones.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.btnRegistrarEquipo);
            this.Controls.Add(this.btnRegistrarPartido);
            this.Controls.Add(this.btnTablaPosiciones);
            this.Name = "MainForm";
            this.Text = "Sistema de Campeonato";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarEquipo;
        private System.Windows.Forms.Button btnRegistrarPartido;
        private System.Windows.Forms.Button btnTablaPosiciones;
    }
}