using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_EsseriViventi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //istanziare gli oggetti con dei cicli for
            //20 cani 5 pesci 3 betulle 5 gigli

            List<IEssereVivente> esseriViventi = new List<IEssereVivente>();
            List<Animale> animali = new List<Animale>();

            for (int i = 1; i <= 20; i++)
            {
                Cane cane = new Cane();
                cane.Id = i;
                esseriViventi.Add(cane);
            }

            for (int i = 0; i <= 5; i++)
            {
                Pesce pesce = new Pesce();
                pesce.Id = i+20;
                esseriViventi.Add(pesce);
            }

            for (int i = 0; i <= 3; i++)
            {
                Betulla betulla = new Betulla();
                betulla.Id = i + 25;
                esseriViventi.Add(betulla);
            }

            for (int i = 0; i <= 5; i++)
            {
                Giglio giglio = new Giglio();
                giglio.Id = i + 28;
                esseriViventi.Add(giglio);
            }
            /*
            foreach(IEssereVivente essere in esseriViventi)
            {
                //essere.stampaDati();

            }
            */
            IEnumerable<Animale> query1 = esseriViventi.OfType<Animale>();
            foreach(Animale animale in query1)
            {
                animale.Muoviti();
            }

            Console.WriteLine("**************************\nsecondo foreach\n");
            foreach(var obj in esseriViventi.Where(o => o is Pesce || o is Cane))
            {
                Console.WriteLine(obj);
            }

            /*
            foreach(var xz in objects.Where(o => o is IX && o is IZ))
            {
                xz.DoStuff();
                ((IX)xz).DoX();
                ((IZ)xz).DoZ(); 
            }
            */
            //metterli nelle liste animali e vegetali e esseri viventi
            //muoviti fiorisci e stampaDati per i rispettivi

        }
    }
}
