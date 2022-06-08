using System;
namespace Haustiere
{
    public class Katzen:Saeuger
    {
        public Katzen(string name):base(name)
        {
        }
        public override void pflegen()
        {
            fellBuersten();
        }

        private void fellBuersten()
        {
            Console.WriteLine($"{Name} wird gerne gebürstet.");
        }
        public override void fortbewegen()
        {
            schleichen();
        }
        private void schleichen()
        {
            Console.WriteLine($"{Name} schleicht durch das Gras.");
        }
    }
}
