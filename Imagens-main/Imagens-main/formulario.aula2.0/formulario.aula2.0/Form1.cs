using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario.aula2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Mostrar1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void button_Mostrar2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void button_Apagar1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible=false;
        }

        private void button_Apagar2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible=false;
        }

        private void button_ApagarTudo_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible=false;
            pictureBox2.Visible=false;
        }

        private void button_MostrarTudo_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible=true;
            pictureBox2.Visible=true;  
        }

        private void button_Stretch_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
        }

        private void button_Zoom1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode =PictureBoxSizeMode.Zoom;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
