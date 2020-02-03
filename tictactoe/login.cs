using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    class login
    {
        public string user;
        public string pass;

        //import class utilizadores
        utilizadores U = new utilizadores();

        public void verifical()
        {
            if (user == U.user1 & pass == U.pass1)
            {
                Form1 jogo = new Form1();
                jogo.Show();
            }
            else
            {
                MessageBox.Show("Falha no login", "Verifique a sua palavra-passe e o seu username");
                Application.Restart();
            }
        }
    }
}
