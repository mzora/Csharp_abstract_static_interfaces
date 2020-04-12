using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Es_Personale
{
    public class Utility
    {
        private static Random r = new Random();//bug

        public static string getRandomStringFromList()
        {
            List<string> nomi = new List<string>
            {
                "aa","bb","cc"
            };
            return nomi[r.Next(nomi.Count)];
        }
        //overload funzione getRandomName
        public static string getRandomStringFromList(List<string> name)
        {
            /*
            List<string> nomi = new List<string>
            {
                "aa","bb","cc"
            };
            */
            return name[r.Next(name.Count)];
            //se r è istanziato qua dentro
            //essendo istanziato in momenti troppo vicini
            //lavora male la classe Random
        }


        public static int getRandomNumber(int min, int max)
        {
            return r.Next(min, max);
        }

        public static float averGen()
        {
            return r.Next(0, 10);
        }


    }
}
