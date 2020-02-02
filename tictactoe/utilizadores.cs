using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    class utilizadores
    {
        public bool login = false;
        public string user1 = "goncalogomes";
        public string pass1 = "gg";

        public string analisa
        {
            set
            {
                user1 = "goncalogomes";
                pass1 = "gg";
            }
        }
        public string resultado
        {
            get
            {
                return user1 + pass1;
            }
        }
    }
}
