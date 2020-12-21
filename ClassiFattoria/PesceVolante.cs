using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiFattoria
{
    public class PesceVolante : Pesce, I_Volante
    {
        public PesceVolante() { }
        public override string Nuota()
        {
            return "Il PesceVolante nuota!";
        }

        public string Vola()
        {
            return "Il PesceVolante vola!";
        }
    }
}
