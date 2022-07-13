using System;
namespace Haustiere
{
    public class Goldfisch:Fisch, IStreichelbar
    {

        public Goldfisch(string name, string besitzer):base(name, besitzer)
        {
        }

        public new void schwimmen()
        {
            Console.WriteLine($"Der Goldfisch {Name} schwimmt im Kreis.");
        }

        public void streicheln()
        {
            Console.WriteLine($"{Name} wird gestreichelt.");
        }
    }
}
