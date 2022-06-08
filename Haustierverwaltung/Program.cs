using System;
using Haustiere;

namespace Haustierverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Goldfisch gf1 = new Goldfisch("Hugo");
            Guppy guppy = new Guppy("Herbert");

            gf1.schwimmen();
            guppy.schwimmen();

            ((Fisch)guppy).schwimmen();
            ((Fisch)gf1).schwimmen();


            Kaninchen kaninchen = new Kaninchen("Hasi");
            Katzen katze = new Katzen("Baghira");

            katze.fortbewegen();
            katze.pflegen();
            ((Saeuger)katze).pflegen();

            kaninchen.pflegen();
            kaninchen.fortbewegen();

            gf1.streicheln();
            katze.streicheln();
            kaninchen.streicheln();

        }
    }
}
