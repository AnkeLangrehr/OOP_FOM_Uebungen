using System;
namespace Haustiere
{
    public class Guppy:Fisch
    {
        public Guppy(string name):base(name)
        {
        }

        public new void schwimmen()
        {
            Console.WriteLine($"Der Guppy {Name} schwimmt hin und her.");
        }
    }
}
