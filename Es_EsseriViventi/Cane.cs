using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_EsseriViventi
{
    public class Cane:Animale
    {
        public override void Muoviti()
        {
            Console.WriteLine("cane correndo..");
        }
    }
}
