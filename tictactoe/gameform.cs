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
        public gameform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login L = new login();

            L.user = textBox1.Text;
            L.pass = textBox2.Text;
            L.verifical();
            this.Hide();        
        }
    }
}
