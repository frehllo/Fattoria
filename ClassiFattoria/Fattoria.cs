using System;

namespace ClassiFattoria
{
    public class Fattoria
    {
        public List<Animale> Animali { get; private set; }

        public Fattoria() { }
        public void Adotta(Animale a)
        {
            Animali.Add(a);
        }
    }
}
