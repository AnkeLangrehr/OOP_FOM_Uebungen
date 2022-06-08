using System;
namespace Haustiere
{
    public abstract class Fisch:Haustier
    {
        public Fisch(string name):base(name)
        {

            
        }

        public void schwimmen()
        {
            Console.WriteLine($"Mein Fisch {Name} schwimmt");
        }

        private void wasserWechseln()
        {
            Console.WriteLine($"{Name} braucht neues Wasser!");
        }

        public override void pflegen()
        {
            wasserWechseln();
        }
    }
}
