using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLoteriaDeDoñaMaryCS
{
    public partial class Form2 : Form
    {
        Image[] ol = new Image[54];
        PictureBox[,] imagen2 = new PictureBox[6, 9];
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Image[] x)
        {
            InitializeComponent();
            ol = x;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 9; j++)
                {

                    imagen2[i, j] = new PictureBox();
                    imagen2[i, j].Location = new Point(5 + (j * 60), 5 + (i * 90));
                    imagen2[i, j].Size = new Size(50, 80);
                    imagen2[i, j].SizeMode = PictureBoxSizeMode.Zoom;
                    //imagen2[i, j].Click += new System.EventHandler(this.imagen_Click);
                    imagen2[i, j].Image = ol[(i * 9) + j];
                    this.Controls.Add(imagen2[i, j]);
                }
            }
        }
    }
}
