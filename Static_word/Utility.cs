using System;
namespace Static_word
{
    public static class Utility
    {
        public const string versione = "1.0";

        //faccio il costruttore che conta le istanze,
        //togliendo static alla classe
        /*
        public Utility()
        {
            Utility.contatore++;
        }
        */
        public static int contatore = 0;
        public static void stampaOra()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
