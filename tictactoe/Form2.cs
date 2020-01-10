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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ob = new Form1();
            ob.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.status==0)
            {
                label1.Text = "Jogo Empatado!";
            }
            else if (Form1.status==1)
            {
                label1.Text = "O Jogador " + gameform.nome2 + " ganhou";
            }
            else
            {
                label1.Text = "O Jogador " + gameform.nome1 + " ganhou";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
