using System;
namespace Haustiere
{
    public class Kaninchen:Saeuger, IPflanzenfresser
    {
        public Kaninchen(string name, string besitzer):base(name, besitzer)
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

        public string fressen(string nahrung)
        {
            return "Frisst gerne Möhren";
        }
    }
}
