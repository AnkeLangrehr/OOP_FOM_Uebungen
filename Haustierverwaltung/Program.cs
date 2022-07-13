using System;
using Haustiere;

namespace Haustierverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            string besitzer = "Der Zoodirektor";
            Goldfisch gf1 = new Goldfisch("Hugo", besitzer);
            Guppy guppy = new Guppy("Herbert", besitzer);

            gf1.schwimmen();
            guppy.schwimmen();

            ((Fisch)guppy).schwimmen();
            ((Fisch)gf1).schwimmen();


            Kaninchen kaninchen = new Kaninchen("Hasi", besitzer);
            Katzen katze = new Katzen("Baghira", besitzer);

            katze.fortbewegen();
            katze.pflegen();
            ((Saeuger)katze).pflegen();

            kaninchen.pflegen();
            kaninchen.fortbewegen();

            gf1.streicheln();
            katze.streicheln();
            kaninchen.streicheln();

            Haustier[][] zoo = new Haustier[10][];
            Saeuger[] garten = new Saeuger[20];
            garten[16] = katze;
            garten[14] = kaninchen;

            Fisch[] aquarium = new Fisch[30];
            aquarium[2] = guppy;
            aquarium[0] = gf1;

            foreach(Fisch f1 in aquarium)
            {
                if (f1 != null)
                {
                    f1.pflegen();
                    f1.schwimmen();
                }
            }

            foreach (Saeuger g1 in garten)
            {
                if (g1 != null) 
                {
                    g1.pflegen();
                    g1.streicheln();
                }
            }



            zoo[0] = aquarium;
            zoo[1] = garten;



            foreach(Haustier[] haustierArray in zoo)
            {
                if(haustierArray != null) {
                    foreach (Haustier tier in haustierArray)
                    {
                        if(tier != null)
                        {
                            tier.pflegen();
                           if(tier is Fisch)
                            {
                                ((Fisch)tier).schwimmen();

                            }

                           if (tier is Saeuger)
                            {
                                ((Saeuger)tier).streicheln();
                               
                            }
                           if (tier is Katzen)
                            {
                                ((Katzen)tier).streicheln();
                                ((Katzen)tier).fressen("Milch");
                            }

                            Console.WriteLine(tier.ToString());
                           

                        }
                    }
                }
                
            }


            try
            {

                Hausschwein mathilde = new Hausschwein("Mathilde", besitzer);
                Console.WriteLine(((IFleischfresser)mathilde).fressen(""));
                mathilde.pflegen();
                Console.WriteLine(mathilde.Besitzer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            


        }
    }
}
