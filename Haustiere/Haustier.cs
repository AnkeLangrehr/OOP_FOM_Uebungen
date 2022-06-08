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

        private string _Name;

        public Haustier(string name)
        {
            _Name = name;
        }


        public abstract void pflegen();

    }
}