using System;
using System.Collections.Generic;
using System.Text;

namespace ClassiFattoria
{
    public abstract class Animale : I_Salutatore
    {
        public string Nome { get; set; }

        string I_Salutatore.Saluta()
        {
            Console.WriteLine("CIAO!!!");
        }
    }
}
