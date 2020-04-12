using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Personale
{
    public class UtilityNames
    {
        public static List<string>[] GetNames()
        {
            List<string> cognomi = new List<string>();
            List<string> nomi = new List<string>();

            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine("scrivi cognome " + i + ":");
                cognomi.Add(Console.ReadLine());
                Console.WriteLine("scrivi nome " + i + ":");
                nomi.Add(Console.ReadLine());
            }
            return new List<string>[] { nomi, cognomi };
        }
    }
}
