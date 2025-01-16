using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCampeonato
{
    public partial class MasOpciones : Form
    {
        public MasOpciones()
        {
            this.BackColor = Color.LightBlue;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MasOpciones_Load(object sender, EventArgs e)
        {
            gif2.Image = Image.FromFile("C:\\Users\\Josman\\Desktop\\Tareas UG\\ProyectoPOE\\equipo2.gif");
            gif2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
