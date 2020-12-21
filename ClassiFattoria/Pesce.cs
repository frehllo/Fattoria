using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiFattoria
{
    public abstract class Pesce : Animale, I_Nuotatore
    {
        public abstract string Nuota();
    }
}
