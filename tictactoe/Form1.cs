using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        int[,] arr = new int[3, 3];
        bool x = true;
        int q = 0;
        public static int status = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            q++;

            if (x==true)
            {
                arr[0, 0] = 1;
            }
            else
            {
                arr[0, 0] = -1;
            }

            mudarimg(pictureBox1);
            if (q > 4)
            {
                verificar();
            }
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            q++;

            if (x == true)
            {
                arr[0, 1] = 1;
            }
            else
            {
                arr[0, 1] = -1;
            }

            mudarimg(pictureBox2);
            if (q > 4)
            {
                verificar();
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            q++;

            if (x == true)
            {
                arr[0, 2] = 1;
            }
            else
            {
                arr[0, 2] = -1;
            }

            mudarimg(pictureBox3);
            if (q > 4)
            {
                verificar();
            }
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            q++;

            if (x == true)
            {
                arr[1, 0] = 1;
            }
            else
            {
                arr[1, 0] = -1;
            }

            mudarimg(pictureBox4);
            if (q > 4)
            {
                verificar();
            }
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            q++;

            if (x == true)
            {
                arr[1, 1] = 1;
            }
            else
            {
                arr[1, 1] = -1;
            }


            mudarimg(pictureBox5);

            if (q > 4)
            {
                verificar();
            }
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            q++;

            if (x == true)
            {
                arr[1, 2] = 1;
            }
            else
            {
                arr[1, 2] = -1;
            }



            mudarimg(pictureBox6);
            if (q > 4)
            {
                verificar();
            }
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            q++;

            if (x == true)
            {
                arr[2, 0] = 1;
            }
            else
            {
                arr[2, 0] = -1;
            }



            mudarimg(pictureBox7);
            if (q > 4)
            {
                verificar();
            }
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            q++;

            if (x == true)
            {
                arr[2, 1] = 1;
            }
            else
            {
                arr[2, 1] = -1;
            }

            mudarimg(pictureBox8);
            if (q > 4)
            {
                verificar();
            }
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            q++;

            if (x == true)
            {
                arr[2, 2] = 1;
            }
            else
            {
                arr[2, 2] = -1;
            }

            mudarimg(pictureBox9);
            if (q > 4)
            {
                verificar();     
            }
            
           
        }




        private void mudarimg(PictureBox pb)
        {
            if (x==true)
            {
                pb.Image = Image.FromFile(@"..\..\Resources\x.png");
                x = false;

            }
            else
            {
                pb.Image = Image.FromFile(@"..\..\Resources\certo.png");
                x = true;

            }
            pb.Enabled = false;

        }



        private void verificar()
        {
            int[] row = new int[3];
            int[] col = new int[3];
            int d1=0, d2=0;

            for (int i = 0; i < 3; i++)
            {
                row[i] = 0;
                col[i] = 0;
                for (int j = 0; j < 3; j++)
                {
                    row[i] = row[i] + arr[i, j];
                    col[i] = col[i] +arr[j, i];
                    if (i==j)
                    {
                        d1 = d1 + arr[i, j];
                    }

                    if (i+j==2)
                    {
                        d2 = d2 + arr[i, j];
                    }

                }
            
            } 
            if (d1==3 ||  d2==3)
            {
                //  MessageBox.Show("O jogador A Ganhou........ ");
                status = 1;
                this.Hide();
                Form2 ganhou = new Form2();
                ganhou.Show();

                return;

            }
            else if (d1 == -3 || d2 == -3)
            {
                //  MessageBox.Show("O jogador B Ganhou........ ");
                status = 2;
                this.Hide();
                Form2 ganhou = new Form2();
                ganhou.Show();
                return;

            }
            else
            {

                for (int i = 0; i < 3; i++)
                {
                    if (row[i]==3 || col[i]==3)
                    {
                        // MessageBox.Show("O jogador A Ganhou........ ");
                        status = 1;
                        this.Hide();
                        Form2 ganhou = new Form2();
                        ganhou.Show();
                         return;
                    }
                    else if (row[i] == -3 || col[i] == -3)
                    {
                       // MessageBox.Show("O jogador B Ganhou........ ");
                        status = 2;
                        this.Hide();
                        Form2 ganhou = new Form2();
                        ganhou.Show();
                        return; 
                    }
                }


            }

            if (q == 9)
            {
                this.Hide();
                Form2 fim = new Form2();
                fim.Show();
                
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Application.StartupPath + "\\Resources\\Help.chm");
        }
    }
}
