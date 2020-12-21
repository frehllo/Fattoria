using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiFattoria
{
    public class Squalo : Pesce
    {
        public Squalo() : base() { }
        public override string Nuota()
        {
            return "Lo squalo sta nuotando!!!";
        }
    }
}
