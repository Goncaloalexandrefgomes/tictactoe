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
    public partial class gameform : Form
    {
        public static string nome1, nome2;
        public gameform()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " " && textBox2.Text != " ")
            {
                nome1 = textBox1.Text;
                nome2 = textBox2.Text;
                this.Hide();
                Form1 jogo = new Form1();
                jogo.Show();
            }
        }
    }
}
