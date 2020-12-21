using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiFattoria
{
    public class Cigno : Volatile, I_Nuotatore
    {
        public Cigno() { }
        public override string Vola()
        {
            return "Il Cigno vola!";
        }

        public string Nuota()
        {
            return "Il cigno sta nuotando!!!";
        }
    }
}
