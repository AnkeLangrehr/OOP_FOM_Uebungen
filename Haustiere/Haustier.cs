using System;
namespace Haustiere
{
    public abstract class Haustier
    {
        public string Name
        {
            get
            {
                return _Name;
            }

            private set { _Name = value; }
        }

        public string Besitzer
        {
            get
            {
                return _Besitzer;
            }

        }
        private string _Besitzer;
        private string _Name;

        public Haustier(string name, string besitzer)
        {
            _Name = name;
            _Besitzer = besitzer;
        }


        public abstract void pflegen();

        public override string ToString()
        {
            string name = "Der Name ist: " +this.Name+"\n";
            string typ = "Es ist ein: "+ this.GetType().ToString()+ "\n";

            return name + typ;
        }

    }

}