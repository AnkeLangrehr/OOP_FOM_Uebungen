using System;
namespace Haustiere
{
    public class Kaninchen:Saeuger
    {
        public Kaninchen(string name):base(name)
        {
        }


        public override void pflegen()
        {
            stallAusmisten();
        }

        private void stallAusmisten()
        {
            Console.WriteLine($"{Name} hat einen dreckigen Stall.");
        }
        public override void fortbewegen()
        {
            hoppeln();
        }
        private void hoppeln()
        {
            Console.WriteLine($"{Name} hoppelt zur Möhre.");
        }

    }
}
