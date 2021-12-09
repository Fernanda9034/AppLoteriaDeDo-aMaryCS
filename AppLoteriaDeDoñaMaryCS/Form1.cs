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
    public partial class Form1 : Form
    {
        PictureBox[,] imagenes = new PictureBox[5, 5];
        PictureBox[,] imag2 = new PictureBox[5, 5];
        PictureBox pil;
        PictureBox[,] imag3 = new PictureBox[5, 5];
        PictureBox[,] imag4 = new PictureBox[5, 5];
        PictureBox[,] imagusuario = new PictureBox[5, 5];
        PictureBox[,] cartas = new PictureBox[6, 9];
        PictureBox[,] imagen = new PictureBox[5, 5];
        PictureBox[,] imagen2 = new PictureBox[6, 9];
        PictureBox[] picBox = new PictureBox[54];

        Image[] grupo = new Image[54];
        Image[] conjunto = new Image[54];
        Image[] wi = new Image[54];
        Image[] wi2 = new Image[5];
        int b, e, f, g, h, o, k, m, n, q, p, w;

        int[] numeros = new int[54];
        int[] rt = new int[4];
        Random aleatorio = new Random();
        Label ganador = new Label();
        public Form1()
        {
            pil = new PictureBox();
            InitializeComponent();
            f = 0;
            m = 0;
            k = 4;
            w = 0;
            n = 0;
            q = 1;
            p = 0;
            ganador.Location = new System.Drawing.Point(8, 58);
            ganador.Size = new System.Drawing.Size(408, 25);
            ganador.Text = "Aparecer";
        }
        private void imagePictureBox_Click(object sender, System.EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (pic.BackColor == Color.Green)
            {
                pic.BackColor = Color.Transparent;
                m -= 1;
            }
            else
            {
                pic.BackColor = Color.Green;
                m += 1;
            }

        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked == false) && (checkBox2.Checked == false) && (checkBox3.Checked == false) && (checkBox4.Checked == false) && (checkBox5.Checked == false))
            {
                MessageBox.Show("Marca Una Casilla");
            }
            else
            {
                //Zero Tablas NPC´s
                if (nUDTablas.Value == 0)
                {
                    Tablas(imagusuario);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            imagusuario[i, j].Image = conjunto[numeros[((i * 5) + j)]];
                            imagusuario[i, j].Click += new System.EventHandler(this.imagePictureBox_Click);
                        }
                    }
                }
                //Una Tabla NPC
                if (nUDTablas.Value == 1)
                {
                    Tablas(imagenes);
                    Tablas(imagusuario);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            imagenes[i, j].Location = new Point(5 + (i * 55), 125 + (j * 85));
                            imagenes[i, j].Size = new Size(50, 80);
                            imagenes[i, j].Image = conjunto[numeros[((i * 5) + j)]];
                            //Tabla Usuario
                            imagusuario[i, j].Location = new Point(20 + ((i + 5) * 55), 125 + (j * 85));
                            imagusuario[i, j].Size = new Size(50, 80);
                            imagusuario[i, j].Image = conjunto[numeros[((i * 5) + j) + 25]];
                            imagusuario[i, j].Click += new System.EventHandler(this.imagePictureBox_Click);
                        }
                    }
                    NumDoblesxT(imagenes);
                    NumDoblesxT(imagusuario);
                }
                //Dos Tablas NPC´s
                if (nUDTablas.Value == 2)
                {
                    Tablas(imagenes);
                    Tablas(imag2);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            imagenes[i, j].Location = new Point(5 + (i * 42), 5 + (j * 65));
                            imagenes[i, j].Size = new Size(37, 60);
                            imagenes[i, j].Image = conjunto[numeros[((i * 5) + j)]];
                            imag2[i, j].Location = new Point(5 + ((i) * 42), 20 + ((j + 5) * 65));
                            imag2[i, j].Size = new Size(37, 60);
                            imag2[i, j].Image = conjunto[numeros[((i * 5) + j) + 25]];
                        }
                    }
                    Revolver();
                    Tablas(imagusuario);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            imagusuario[i, j].Location = new Point(240 + ((i) * 55), 125 + (j * 85));
                            imagusuario[i, j].Size = new Size(50, 80);
                            imagusuario[i, j].Image = conjunto[numeros[((i * 5) + j)]];
                            imagusuario[i, j].Click += new System.EventHandler(this.imagePictureBox_Click);
                        }
                    }
                    NumDoblesxT(imagenes);
                    NumDoblesxT(imag2);
                    NumDoblesxT(imagusuario);
                }

                //Tres Tablas NPC´s
                if (nUDTablas.Value == 3)
                {
                    Tablas(imagenes);
                    Tablas(imag2);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            imagenes[i, j].Location = new Point(5 + (i * 42), 5 + (j * 65));
                            imagenes[i, j].Size = new Size(37, 60);
                            imagenes[i, j].Image = conjunto[numeros[((i * 5) + j)]];
                            imag2[i, j].Location = new Point(20 + ((i + 5) * 42), 170 + ((j) * 65));
                            imag2[i, j].Size = new Size(37, 60);
                            imag2[i, j].Image = conjunto[numeros[((i * 5) + j) + 25]];
                        }
                    }
                    Revolver();
                    Tablas(imag3);
                    Tablas(imagusuario);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            imag3[i, j].Location = new Point(5 + ((i) * 42), 20 + ((j + 5) * 65));
                            imag3[i, j].Size = new Size(37, 60);
                            imag3[i, j].Image = conjunto[numeros[((i * 5) + j)]];
                            //Tabla Usuario
                            imagusuario[i, j].Location = new Point(180 + ((i + 5) * 55), 125 + (j * 85));
                            imagusuario[i, j].Size = new Size(50, 80);
                            imagusuario[i, j].Image = conjunto[numeros[((i * 5) + j) + 25]];
                            imagusuario[i, j].Click += new System.EventHandler(this.imagePictureBox_Click);
                        }
                    }
                    NumDoblesxT(imagenes);
                    NumDoblesxT(imag2);
                    NumDoblesxT(imag3);
                    NumDoblesxT(imagusuario);
                }

                //Cuatro Tablas NPC´s
                if (nUDTablas.Value == 4)
                {
                    Tablas(imagenes);
                    Tablas(imag2);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            imagenes[i, j].Location = new Point(5 + (i * 42), 5 + (j * 65));
                            imagenes[i, j].Size = new Size(37, 60);
                            imagenes[i, j].Image = conjunto[numeros[((i * 5) + j)]];
                            imag2[i, j].Location = new Point(20 + ((i + 5) * 42), 5 + ((j) * 65));
                            imag2[i, j].Size = new Size(37, 60);
                            imag2[i, j].Image = conjunto[numeros[((i * 5) + j) + 25]];
                        }
                    }
                    Revolver();
                    Tablas(imag3);
                    Tablas(imag4);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            imag3[i, j].Location = new Point(5 + ((i) * 42), 20 + ((j + 5) * 65));
                            imag3[i, j].Size = new Size(37, 60);
                            imag3[i, j].Image = conjunto[numeros[((i * 5) + j)]];
                            imag4[i, j].Location = new Point(20 + ((i + 5) * 42), 20 + ((j + 5) * 65));
                            imag4[i, j].Size = new Size(37, 60);
                            imag4[i, j].Image = conjunto[numeros[((i * 5) + j) + 25]];
                        }
                    }
                    Revolver();
                    Tablas(imagusuario);
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            imagusuario[i, j].Location = new Point(180 + ((i + 5) * 55), 125 + (j * 85));
                            imagusuario[i, j].Size = new Size(50, 80);
                            imagusuario[i, j].Image = conjunto[numeros[((i * 5) + j)]];
                            imagusuario[i, j].Click += new System.EventHandler(this.imagePictureBox_Click);
                        }
                    }
                    NumDoblesxT(imagenes);
                    NumDoblesxT(imag2);
                    NumDoblesxT(imag3);
                    NumDoblesxT(imag4);
                    NumDoblesxT(imagusuario);
                }
                label1.Visible = false;
                btnCrear.Visible = false;
                nUDTablas.Visible = false;
                numericUpDown1.Visible = false;
                btnAumentar.Visible = true;
                btnDisminuir.Visible = true;


                //Mazo
                for (int i = 0; i < 54; i++)
                {
                    picBox[i] = new PictureBox();
                    picBox[i].Location = new Point(1040 + (i * 2), 5 + (i * 2));
                    picBox[i].Size = new Size(170, 280);
                    picBox[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    picBox[i].Image = (AppLoteriaDeDoñaMaryCS.Properties.Recursos.captura);
                    this.Controls.Add(picBox[i]);
                }
                Revolver();
                btnAlto.Visible = true;
                timer2.Interval = 2000;
                timer2.Start();

                btnCrar.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                checkBox5.Visible = false;
                //pictureBox4.Visible = false;
                //pictureBox5.Visible = false;
                //pictureBox6.Visible = false;
                //pictureBox7.Visible = false;
                //pictureBox8.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Revolver();
            for (int i = 1; i < 55; i++)
                conjunto[i - 1] = new System.Drawing.Bitmap(Application.StartupPath + @"\jpg\" + (i) + ".jpg");
        }
        private void btnBuenas_Click(object sender, EventArgs e)
        {
            Buenas();
        }

        private void btnSigCarta_Click(object sender, EventArgs e)
        {
            picBox[f].Location = new Point(770 + (f * 2), 5 + (f * 2));
            picBox[f].Size = new Size(170, 280);
            picBox[f].BackColor = Color.White;
            picBox[f].BorderStyle = BorderStyle.FixedSingle;
            picBox[f].SizeMode = PictureBoxSizeMode.Zoom;
            picBox[f].Image = (conjunto[numeros[f]]);
            grupo[f] = picBox[f].Image;
            picBox[f].BringToFront();
            label2.Visible = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(773 + (f * 2), 8 + (f * 2));
            label2.Text = "";
            label2.BringToFront();
            label1.Visible = true;
            label1.BackColor = Color.White;
            label1.AutoSize = true;
            label1.Location = new Point(915 + (f * 2), 260 + (f * 2));
            label1.Text = "";
            label1.BringToFront();

            if (f == 52)
            {
                btnSiguienteCarta.Visible = false;
                timer2.Stop();
                btnCartaUltima.Visible = true;
                MessageBox.Show("Solo Queda Una Carta " + tbxNombre.Text);
            }
            //Checar Tabla de NPC´s
            if (nUDTablas.Value == 1)
            {
                Checar(imagenes);
                g = 1;
                Ganar(imagenes);
            }
            if (nUDTablas.Value == 2)
            {
                Checar(imagenes);
                Checar(imag2);
                g = 1;
                Ganar(imagenes);
                g = 2;
                Ganar(imag2);
            }
            if (nUDTablas.Value == 3)
            {
                Checar(imagenes);
                Checar(imag2);
                Checar(imag3);
                g = 1;
                Ganar(imagenes);
                g = 2;
                Ganar(imag2);
                g = 3;
                Ganar(imag3);
            }
            if (nUDTablas.Value == 4)
            {
                Checar(imagenes);
                Checar(imag2);
                Checar(imag3);
                Checar(imag4);
                g = 1;
                Ganar(imagenes);
                g = 2;
                Ganar(imag2);
                g = 3;
                Ganar(imag3);
                g = 4;
                Ganar(imag4);
            }
            if (nUDTablas.Value == 0)
            {
                Checar(imagen);
                Ganar(imagen);
            }
            f += 1;
        }

        //Metodo Checar
        private void Checar(PictureBox[,] Arreglo)
        {
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    if (Arreglo[i, j].Image == picBox[f].Image)
                        Arreglo[i, j].BackColor = Color.Green;
        }
        //Revolver Arreglo
        private void Revolver()
        {
            for (int i = 0; i < 54; i++)
            {
                numeros[i] = (i);
            }

            for (int i = 0; i < 54; i++)
            {
                b = aleatorio.Next(0, 53);
                e = numeros[b];
                numeros[b] = numeros[i];
                numeros[i] = e;
            }

            for (int i = 0; i < 4; i++)
            {
                rt[i] = i;
            }

            for (int i = 0; i < 4; i++)
            {
                b = aleatorio.Next(0, 3);
                e = rt[b];
                rt[b] = rt[i];
                rt[i] = e;
            }

        }
        //Metodo Ganar NPC´s
        private void Ganar(PictureBox[,] Arreglo)
        {


            for (int i = 0; i < 5; i++)
            {

                if (checkBox3.Checked == true)
                {
                    if ((Arreglo[i, 0].BackColor == Color.Green) && (Arreglo[i, 1].BackColor == Color.Green) && (Arreglo[i, 2].BackColor == Color.Green) && (Arreglo[i, 3].BackColor == Color.Green) && (Arreglo[i, 4].BackColor == Color.Green))
                    {
                        MessageBox.Show("perdedor");
                        timer2.Stop();
                        for (int j = 0; j < 5; j++)
                        {
                            Arreglo[i, j].BackColor = Color.Red;

                        }

                        if (nUDTablas.Value == 0)
                        {
                            ExcelU();
                        }
                        else
                        {
                            ExcelNPCs();
                        }

                    }

                }

                if (checkBox2.Checked == true)
                {
                    if ((Arreglo[0, i].BackColor == Color.Green) && (Arreglo[1, i].BackColor == Color.Green) && (Arreglo[2, i].BackColor == Color.Green) && (Arreglo[3, i].BackColor == Color.Green) && (Arreglo[4, i].BackColor == Color.Green))
                    {
                        MessageBox.Show("perdedor");
                        timer2.Stop();

                        for (int j = 0; j < 5; j++)
                        {
                            Arreglo[j, i].BackColor = Color.Red;

                        }
                        if (nUDTablas.Value == 0)
                        {
                            ExcelU();
                        }
                        else
                        {
                            ExcelNPCs();
                        }
                    }

                }

            }
            //Ganar Diagonal "\"

            if (checkBox1.Checked == true)
            {
                if ((Arreglo[0, 0].BackColor == Color.Green) && (Arreglo[1, 1].BackColor == Color.Green) && (Arreglo[2, 2].BackColor == Color.Green) && (Arreglo[3, 3].BackColor == Color.Green) && (Arreglo[4, 4].BackColor == Color.Green))
                {
                    MessageBox.Show("perdedor");
                    timer2.Stop();

                    for (int j = 0; j < 5; j++)
                    {
                        Arreglo[j, j].BackColor = Color.Red;

                    }

                    if (nUDTablas.Value == 0)
                    {
                        ExcelU();
                    }
                    else
                    {
                        ExcelNPCs();
                    }


                }
                //Ganar Diagonal "/"
                if ((Arreglo[0, 4].BackColor == Color.Green) && (Arreglo[1, 3].BackColor == Color.Green) && (Arreglo[2, 2].BackColor == Color.Green) && (Arreglo[3, 1].BackColor == Color.Green) && (Arreglo[4, 0].BackColor == Color.Green))
                {
                    MessageBox.Show("perdedor");
                    timer2.Stop();

                    for (int j = 0; j < 5; j++)
                    {
                        Arreglo[j, k].BackColor = Color.Red;
                        k -= 1;

                    }

                    if (nUDTablas.Value == 0)
                    {
                        ExcelU();
                    }
                    else
                    {
                        ExcelNPCs();
                    }

                }

            }

            if (checkBox4.Checked == true)
            {
                if ((Arreglo[0, 0].BackColor == Color.Green) && (Arreglo[0, 4].BackColor == Color.Green) && (Arreglo[2, 2].BackColor == Color.Green) && (Arreglo[4, 0].BackColor == Color.Green) && (Arreglo[4, 4].BackColor == Color.Green))
                {
                    timer2.Stop();
                    MessageBox.Show("perdedor");

                    Arreglo[0, 0].BackColor = Color.Red;
                    Arreglo[0, 4].BackColor = Color.Red;
                    Arreglo[2, 2].BackColor = Color.Red;
                    Arreglo[4, 0].BackColor = Color.Red;
                    Arreglo[4, 4].BackColor = Color.Red;


                    if (nUDTablas.Value == 0)
                    {
                        ExcelU();
                    }
                    else
                    {
                        ExcelNPCs();
                    }

                }

            }

            if (checkBox5.Checked == true)
            {
                if ((Arreglo[1, 1].BackColor == Color.Green) && (Arreglo[1, 3].BackColor == Color.Green) && (Arreglo[2, 2].BackColor == Color.Green) && (Arreglo[3, 1].BackColor == Color.Green) && (Arreglo[3, 3].BackColor == Color.Green))
                {
                    timer2.Stop();

                    MessageBox.Show("perdedor");

                    Arreglo[1, 1].BackColor = Color.Red;
                    Arreglo[1, 3].BackColor = Color.Red;
                    Arreglo[2, 2].BackColor = Color.Red;
                    Arreglo[3, 1].BackColor = Color.Red;
                    Arreglo[3, 3].BackColor = Color.Red;



                    if (nUDTablas.Value == 0)
                    {

                        ExcelU();

                    }
                    else
                    {
                        ExcelNPCs();
                    }

                }

            }

        }

        //Metodo Crear Tablas 
        private void Tablas(PictureBox[,] Arreglo)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Arreglo[i, j] = new PictureBox();
                    Arreglo[i, j].Location = new Point(5 + (i * 80), 20 + (j * 135));
                    Arreglo[i, j].Size = new Size(75, 130);
                    Arreglo[i, j].SizeMode = PictureBoxSizeMode.Zoom;
                    Arreglo[i, j].BorderStyle = BorderStyle.Fixed3D;
                    this.Controls.Add(Arreglo[i, j]);
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            btnSigCarta_Click(null, null);
        }

        private void tbxName_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                nUDTablas.Visible = true;
                numericUpDown1.Visible = true;
                btnBuenas.Visible = true;
                btnCrear.Visible = true;
                label1.Visible = true;
                label2.Visible = false;
                tbxNombre.Visible = false;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
                checkBox5.Visible = true;
                //pictureBox4.Visible = true;
                //pictureBox5.Visible = true;
                //pictureBox6.Visible = true;
                //pictureBox7.Visible = true;
                //pictureBox8.Visible = true;
            }
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            h += 2;
            timer2.Interval = (50000 * h);
            o = h;
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            o += 2;
            timer2.Interval = (50000 / o);
            h = o;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 50000;
            timer1.Start();

        }
        private void ExcelNPCs()
        {
            /*Excel.Application xl = new Excel.Application();
            /*Excel.Workbook xlx = xl.Workbooks.Open(Application.StartupPath + @"\png\x1.xlsx");
            xl.Visible = true;
            xl.Cells[1, 1] = "Usuario";
            xl.Cells[1, 2] = "Fecha y Hora";
            xl.Cells[1, 3] = "Num de Cartas Usadas";
            xl.Rows[2].Insert();
            xl.Cells[2, 1] = "NPC´s " + n;
            xl.Cells[2, 2] = "" + DateTime.Now;
            xl.Cells[2, 3] = "" + (l+1);
            xl.Columns[1].AutoFit();
            xl.Columns[2].AutoFit();
            xl.Columns[3].AutoFit();
            xl.ActiveSheet.ChartObjects("2 Gráfico").Activate();
            xl.ActiveChart.SetSourceData(xl.get_Range("A1:C6"));
            btnRestart.Visible = true;*/
        }
        private void ExcelU()
        {
            /*Excel.Application xl = new Excel.Application();
            Excel.Workbook xlx = xl.Workbooks.Open(Application.StartupPath + @"\png\x1.xlsx");
            xl.Visible = true;
            xl.Cells[1, 1] = "Usuario";
            xl.Cells[1, 2] = "Fecha y Hora";
            xl.Cells[1, 3] = "Num de Cartas Usadas";
            xl.Rows[2].Insert();
            xl.Cells[2, 1] = tbxName.Text;
            xl.Cells[2, 2] = "" + DateTime.Now;
            xl.Cells[2, 3] = "" + (l+1);
            xl.Columns[1].AutoFit();
            xl.Columns[2].AutoFit();
            xl.Columns[3].AutoFit();
            xl.ActiveSheet.ChartObjects("2 Gráfico").Activate();
            xl.ActiveChart.SetSourceData(xl.get_Range("A1:C6"));  
            btnRestart.Visible = true;*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (pictureBox1.Visible == true)
            //{
            //    pictureBox1.Visible = false;
            //    pictureBox2.Visible = true;
            //}
            //else if (pictureBox2.Visible == true)
            //{
            //    pictureBox2.Visible = false;
            //    pictureBox3.Visible = true;
            //}
            //else
            //{
            //    pictureBox3.Visible = false;
            //    pictureBox1.Visible = true;
            //}
        }

        private void btnUltimaCarta_Click(object sender, EventArgs e)
        {
            f = 53;
            picBox[f].Location = new Point(770 + (f * 2), 5 + (f * 2));
            picBox[f].Size = new Size(170, 280);
            picBox[f].BackColor = Color.White;
            picBox[f].BorderStyle = BorderStyle.FixedSingle;
            picBox[f].SizeMode = PictureBoxSizeMode.Zoom;
            picBox[f].Image = (conjunto[numeros[f]]);
            grupo[f] = picBox[f].Image;
            picBox[f].BringToFront();
        }
        private void Buenas()
        {
            //Ganar Vertical 
            if (checkBox3.Checked == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    if ((imagusuario[i, 0].BackColor == Color.Green) && (imagusuario[i, 1].BackColor == Color.Green) && (imagusuario[i, 2].BackColor == Color.Green) && (imagusuario[i, 3].BackColor == Color.Green) && (imagusuario[i, 4].BackColor == Color.Green))
                    {
                        for (int j = 0; j < 54; j++)
                        {
                            if ((grupo[j] == imagusuario[i, 0].Image))
                            {
                                for (int v = 0; v < 54; v++)
                                {
                                    if ((grupo[v] == imagusuario[i, 1].Image))
                                    {
                                        for (int p = 0; p < 54; p++)
                                        {
                                            if ((grupo[p] == imagusuario[i, 2].Image))
                                            {
                                                for (int ñ = 0; ñ < 54; ñ++)
                                                {
                                                    if ((grupo[ñ] == imagusuario[i, 3].Image))
                                                    {
                                                        for (int t = 0; t < 54; t++)
                                                        {
                                                            if ((grupo[t] == imagusuario[i, 4].Image))
                                                            {
                                                                timer2.Stop();
                                                                for (int w = 0; w < 5; w++)
                                                                {
                                                                    imagusuario[i, w].BackColor = Color.Red;
                                                                    MessageBox.Show("felicidades:" + tbxNombre.Text);
                                                                }

                                                                ExcelU();
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }


            //Ganar Horiontal

            if (checkBox2.Checked == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    if ((imagusuario[0, i].BackColor == Color.Green) && (imagusuario[1, i].BackColor == Color.Green) && (imagusuario[2, i].BackColor == Color.Green) && (imagusuario[3, i].BackColor == Color.Green) && (imagusuario[4, i].BackColor == Color.Green))
                    {
                        for (int j = 0; j < 54; j++)
                        {
                            if ((grupo[j] == imagusuario[0, i].Image))
                            {
                                for (int t = 0; t < 54; t++)
                                {
                                    if ((grupo[t] == imagusuario[1, i].Image))
                                    {
                                        for (int p = 0; p < 54; p++)
                                        {
                                            if ((grupo[p] == imagusuario[2, i].Image))
                                            {
                                                for (int ñ = 0; ñ < 54; ñ++)
                                                {
                                                    if ((grupo[ñ] == imagusuario[3, i].Image))
                                                    {
                                                        for (int v = 0; v < 54; v++)
                                                        {
                                                            if ((grupo[v] == imagusuario[4, i].Image))
                                                            {
                                                                timer2.Stop();

                                                                for (int w = 0; w < 5; w++)
                                                                {
                                                                    imagusuario[w, i].BackColor = Color.Red;
                                                                    MessageBox.Show("felicidades:" + tbxNombre.Text);

                                                                }

                                                                ExcelU();
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //Ganar Diagonal "\"

            if (checkBox1.Checked == true)
            {
                if ((imagusuario[0, 0].BackColor == Color.Green) && (imagusuario[1, 1].BackColor == Color.Green) && (imagusuario[2, 2].BackColor == Color.Green) && (imagusuario[3, 3].BackColor == Color.Green) && (imagusuario[4, 4].BackColor == Color.Green))
                {
                    for (int j = 0; j < 54; j++)
                    {
                        if ((grupo[j] == imagusuario[0, 0].Image))
                        {
                            for (int t = 0; t < 54; t++)
                            {
                                if ((grupo[t] == imagusuario[1, 1].Image))
                                {
                                    for (int p = 0; p < 54; p++)
                                    {
                                        if ((grupo[p] == imagusuario[2, 2].Image))
                                        {
                                            for (int ñ = 0; ñ < 54; ñ++)
                                            {
                                                if ((grupo[ñ] == imagusuario[3, 3].Image))
                                                {
                                                    for (int v = 0; v < 54; v++)
                                                    {
                                                        if ((grupo[v] == imagusuario[4, 4].Image))
                                                        {
                                                            timer2.Stop();
                                                            for (int w = 0; w < 5; w++)
                                                            {
                                                                imagusuario[w, w].BackColor = Color.Red;
                                                                MessageBox.Show("felicidades:" + tbxNombre.Text);
                                                            }

                                                            ExcelU();

                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                //Ganar Diagonal "/"
                if ((imagusuario[0, 4].BackColor == Color.Green) && (imagusuario[1, 3].BackColor == Color.Green) && (imagusuario[2, 2].BackColor == Color.Green) && (imagusuario[3, 1].BackColor == Color.Green) && (imagusuario[4, 0].BackColor == Color.Green))
                {
                    for (int j = 0; j < 54; j++)
                    {
                        if ((grupo[j] == imagusuario[0, 4].Image))
                        {
                            for (int t = 0; t < 54; t++)
                            {
                                if ((grupo[t] == imagusuario[1, 2].Image))
                                {
                                    for (int p = 0; p < 54; p++)
                                    {
                                        if ((grupo[p] == imagusuario[2, 2].Image))
                                        {
                                            for (int ñ = 0; ñ < 54; ñ++)
                                            {
                                                if ((grupo[ñ] == imagusuario[3, 1].Image))
                                                {
                                                    for (int v = 0; v < 54; v++)
                                                    {
                                                        if ((grupo[v] == imagusuario[4, 0].Image))
                                                        {
                                                            timer2.Stop();
                                                            for (int w = 0; w < 5; w++)
                                                            {
                                                                imagusuario[w, k].BackColor = Color.Red;
                                                                MessageBox.Show("felicidades:" + tbxNombre.Text);
                                                                k -= 1;
                                                            }

                                                            ExcelU();
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }

            if (checkBox4.Checked == true)
            {
                if ((imagusuario[0, 0].BackColor == Color.Green) && (imagusuario[0, 4].BackColor == Color.Green) && (imagusuario[2, 2].BackColor == Color.Green) && (imagusuario[4, 0].BackColor == Color.Green) && (imagusuario[4, 4].BackColor == Color.Green))
                {
                    for (int j = 0; j < 54; j++)
                    {
                        if ((grupo[j] == imagusuario[0, 0].Image))
                        {
                            for (int v = 0; v < 54; v++)
                            {
                                if ((grupo[v] == imagusuario[0, 4].Image))
                                {
                                    for (int p = 0; p < 54; p++)
                                    {
                                        if ((grupo[p] == imagusuario[2, 2].Image))
                                        {
                                            for (int ñ = 0; ñ < 54; ñ++)
                                            {
                                                if ((grupo[ñ] == imagusuario[4, 0].Image))
                                                {
                                                    for (int t = 0; t < 54; t++)
                                                    {
                                                        if ((grupo[t] == imagusuario[4, 4].Image))
                                                        {
                                                            timer2.Stop();
                                                            imagusuario[0, 0].BackColor = Color.Red;
                                                            imagusuario[0, 4].BackColor = Color.Red;
                                                            imagusuario[2, 2].BackColor = Color.Red;
                                                            imagusuario[4, 0].BackColor = Color.Red;
                                                            imagusuario[4, 4].BackColor = Color.Red;
                                                            MessageBox.Show("felicidades:" + tbxNombre.Text);
                                                            ExcelU();
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }
                    }

                    if (checkBox5.Checked == true)
                    {
                        if ((imagusuario[1, 1].BackColor == Color.Green) && (imagusuario[1, 3].BackColor == Color.Green) && (imagusuario[2, 2].BackColor == Color.Green) && (imagusuario[3, 1].BackColor == Color.Green) && (imagusuario[3, 3].BackColor == Color.Green))
                        {
                            for (int j = 0; j < 54; j++)
                            {
                                if ((grupo[j] == imagusuario[1, 1].Image))
                                {
                                    for (int v = 0; v < 54; v++)
                                    {
                                        if ((grupo[v] == imagusuario[1, 3].Image))
                                        {
                                            for (int p = 0; p < 54; p++)
                                            {
                                                if ((grupo[p] == imagusuario[2, 2].Image))
                                                {
                                                    for (int ñ = 0; ñ < 54; ñ++)
                                                    {
                                                        if ((grupo[ñ] == imagusuario[3, 1].Image))
                                                        {
                                                            for (int t = 0; t < 54; t++)
                                                            {
                                                                if ((grupo[t] == imagusuario[3, 3].Image))
                                                                {
                                                                    timer2.Stop();

                                                                    imagusuario[1, 1].BackColor = Color.Red;
                                                                    imagusuario[1, 3].BackColor = Color.Red;
                                                                    imagusuario[2, 2].BackColor = Color.Red;
                                                                    imagusuario[3, 1].BackColor = Color.Red;
                                                                    imagusuario[3, 3].BackColor = Color.Red;
                                                                    MessageBox.Show("felicidades:" + tbxNombre.Text);
                                                                    ExcelU();
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }

        private void btnStopI_Click(object sender, EventArgs e)
        {
            if (btnAlto.Text == "Stop")
            {
                timer2.Stop();
                btnAlto.Text = "Start";
            }
            else
            {
                timer2.Start();
                btnAlto.Text = "Stop";
            }
        }

        private void btnCartasAnt_Click(object sender, EventArgs e)
        {
            new Form2(grupo).ShowDialog();
        }

        private void btnCrarTabla_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked == false) && (checkBox2.Checked == false) && (checkBox3.Checked == false) && (checkBox4.Checked == false) && (checkBox5.Checked == false))
            {
                MessageBox.Show("Marca Una Casilla");
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        imagen[i, j] = new PictureBox();
                        imagen[i, j].Location = new Point(5 + (i * 80), 5 + (j * 135));
                        imagen[i, j].Size = new Size(75, 130);
                        imagen[i, j].SizeMode = PictureBoxSizeMode.Zoom;
                        imagen[i, j].BorderStyle = BorderStyle.FixedSingle;
                        //this.picBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.picBox_DragDrop);
                        imagen[i, j].DragDrop += new System.Windows.Forms.DragEventHandler(this.imagen_DragDrop);
                        //this.picBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.picBox_DragEnter);
                        imagen[i, j].DragEnter += new System.Windows.Forms.DragEventHandler(this.imagen_DragEnter);
                        //
                        //imagen[i, j].Click += new System.EventHandler(this.imagen_Click);
                        imagen[i, j].AllowDrop = true;
                        this.Controls.Add(imagen[0, 0]);
                    }
                }
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        imagen2[i, j] = new PictureBox();
                        imagen2[i, j].Location = new Point(500 + (j * 60), 5 + (i * 90));
                        imagen2[i, j].Size = new Size(50, 80);
                        imagen2[i, j].SizeMode = PictureBoxSizeMode.Zoom;
                        imagen2[i, j].BorderStyle = BorderStyle.FixedSingle;
                        //imagen2[i, j].Click += new System.EventHandler(this.imagen_Click);
                        imagen2[i, j].Image = conjunto[(i * 9) + j];
                        imagen2[i, j].MouseDown += new System.Windows.Forms.MouseEventHandler(this.imagen2_MouseDown);
                        this.Controls.Add(imagen2[i, j]);
                    }
                }
                nUDTablas.Visible = false;
                numericUpDown1.Visible = false;
                btnCrear.Visible = false;
                label1.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                checkBox5.Visible = false;
                //pictureBox4.Visible = false;
                //pictureBox5.Visible = false;
                //pictureBox6.Visible = false;
                //pictureBox7.Visible = false;
                //pictureBox8.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void imagen_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox picbox = (PictureBox)sender;
            Graphics g = picbox.CreateGraphics();
            //picbox.SizeMode = PictureBoxSizeMode.Zoom;
            g.DrawImage((Image)e.Data.GetData(DataFormats.Bitmap), 0, 27, picbox.Width, picbox.Width);
            n += 1;
            if (n == 25)
            {
                btnGuardarTabla.Visible = true;
            }
            this.Controls.Add(imagen[q, p]);
            q++;
            picbox.AllowDrop = false;
            //this.picBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.picBox_DragDrop);
            picbox.DragDrop -= new System.Windows.Forms.DragEventHandler(this.imagen_DragDrop);
            //this.picBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.picBox_DragEnter);
            picbox.DragEnter -= new System.Windows.Forms.DragEventHandler(this.imagen_DragEnter);
            if (q == 5)
            {
                q = 0;
                p++;
                if (p == 5)
                {
                    p = 0;
                }
            }
        }

        private void btnCartaUltima_Click(object sender, EventArgs e)
        {

        }

        private void btnBuenas_Click_1(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Buenas.wav");
            player.Play();
        }

        private void imagen_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void imagen2_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.DoDragDrop(pic.Image, DragDropEffects.Move);
            wi[k] = pic.Image;
            k += 1;
            pic.Visible = false;
        }
        private void imagen_Click(object sender, System.EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnGuardarTabla_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    this.Controls.Remove(imagen[i, j]);
                    imagen[j, i].Image = wi[(i * 5) + j];
                    this.Controls.Add(imagen[i, j]);
                }
            }
            for (int i = 0; i < 54; i++)
            {
                picBox[i] = new PictureBox();
                picBox[i].Location = new Point(1040 + (i * 2), 5 + (i * 2));
                picBox[i].Size = new Size(170, 280);
                picBox[i].SizeMode = PictureBoxSizeMode.StretchImage;
                picBox[i].Image = (AppLoteriaDeDoñaMaryCS.Properties.Resources.Captura) + (".jpg");
                this.Controls.Add(picBox[i]);
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    this.Controls.Remove(imagen2[i, j]);
                }
            }
            Revolver();
            btnAlto.Visible = true;
            timer2.Interval = 1000;
            timer2.Start();
            //pictureBox1.Visible = true;
            //label3.Visible = true;
            btnCrar.Visible = true;
            btnCrar.Visible = false;
            btnGuardarTabla.Visible = false;
            btnAumentar.Visible = true;
            btnDisminuir.Visible = true;
        }

        private void nUDTablas_ValueChanged(object sender, EventArgs e)
        {
            if (nUDTablas.Value == 0)
            {
                btnCrar.Visible = true;
                label1.Text = "Crear Tabla Y Jugar Solo";
                btnCrear.Visible = false;
            }
            if (nUDTablas.Value > 0)
            {
                btnCrar.Visible = false;
                label1.Text = "Numero De NPC´s";
                btnCrear.Visible = true;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void DoblesxTabla(PictureBox[,] Dobles)
        {
            if (w < 4)
            {
                Dobles[rt[w], rt[w] + 1].Image = Dobles[rt[w] + 1, rt[w]].Image;
            }
            else
            {
                w = 1;
                Dobles[rt[w], rt[w] + 1].Image = Dobles[rt[w] + 1, rt[w]].Image;
            }

            w += 1;
        }
        private void Doble(PictureBox[,] Dobles2)
        {
            if (w < 4)
            {
                Dobles2[rt[w] + 1, rt[w]].Image = Dobles2[rt[w], rt[w] + 1].Image;
            }
            else
            {
                w = 1;
                Dobles2[rt[w] + 1, rt[w]].Image = Dobles2[rt[w], rt[w] + 1].Image;
            }
            w += 1;
        }

        private void NumDoblesxT(PictureBox[,] arreglo)
        {
            if (numericUpDown1.Value == 1)
            {
                DoblesxTabla(arreglo);
            }
            if (numericUpDown1.Value == 2)
            {
                DoblesxTabla(arreglo);
                Doble(arreglo);
            }
            if (numericUpDown1.Value == 3)
            {
                DoblesxTabla(arreglo);
                Doble(arreglo);
                DoblesxTabla(arreglo);
            }
        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {

        }

        //profe, hice lo que pude pero la verdad no logre hacer que funcionara:( lo100to
    }

}





