using System;
namespace Haustiere
{
    public class Hausschwein: Saeuger, IFleischfresser, IPflanzenfresser 
    {
        public Hausschwein(string name, string besitzer):base(name, besitzer)
        {
        }

        string IPflanzenfresser.fressen(string nahrung)
        {

            return "";
        }

        string IFleischfresser.fressen(string nahrung)
        {
            return "Fleischfresser!";
        }

        public override void pflegen()
        {

        }


        public override void fortbewegen()
        {

        }
    }
}
