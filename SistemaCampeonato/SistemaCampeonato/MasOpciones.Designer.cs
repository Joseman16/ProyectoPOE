namespace SistemaCampeonato
{
    partial class MasOpciones
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
            gif2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)gif2).BeginInit();
            SuspendLayout();
            // 
            // gif2
            // 
            gif2.Location = new Point(0, -3);
            gif2.Name = "gif2";
            gif2.Size = new Size(461, 340);
            gif2.TabIndex = 0;
            gif2.TabStop = false;
            gif2.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(481, 12);
            button1.Name = "button1";
            button1.Size = new Size(164, 54);
            button1.TabIndex = 1;
            button1.Text = "Actualizar eliminar Jugador";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(481, 83);
            button2.Name = "button2";
            button2.Size = new Size(164, 54);
            button2.TabIndex = 2;
            button2.Text = "Actualizar eliminar Equipo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MasOpciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 331);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(gif2);
            Name = "MasOpciones";
            Text = "MasOpciones";
            Load += MasOpciones_Load;
            ((System.ComponentModel.ISupportInitialize)gif2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox gif2;
        private Button button1;
        private Button button2;
    }
}