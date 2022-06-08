using System;
namespace Haustiere
{
    public abstract class Saeuger:Haustier, IStreichelbar
    {
        public Saeuger(string name):base(name)
        {
        }

        public abstract void fortbewegen();

        public void streicheln()
        {
            Console.WriteLine($"{Name} wird gestreichelt.");
        }
    }
}
