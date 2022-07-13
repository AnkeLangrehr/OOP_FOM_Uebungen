using System;
namespace Haustiere
{
    public class Guppy:Fisch
    {
        public Guppy(string name, string besitzer):base(name, besitzer)
        {
        }

        public new void schwimmen()
        {
            Console.WriteLine($"Der Guppy {Name} schwimmt hin und her.");
        }
    }
}
