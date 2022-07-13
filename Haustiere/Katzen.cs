using System;
namespace Haustiere
{
    public class Katzen:Saeuger, IStreichelbar, IFleischfresser
    {
        public Katzen(string name, string besitzer):base(name, besitzer)
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

        new public void streicheln()
        {
            Console.WriteLine($"{Name} schnurrt.");
        }

        public string fressen(string nahrung)
        {
            Console.WriteLine("Trinkt gerne Milch");
            return "Trinkt gerne Milch";
        }
    }
}
