using System;
namespace Haustiere
{
    public class Goldfisch:Fisch, IStreichelbar
    {

        public Goldfisch(string name):base(name)
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
