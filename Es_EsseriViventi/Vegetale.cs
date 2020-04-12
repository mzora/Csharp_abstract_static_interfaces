using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_EsseriViventi
{
    public abstract class Vegetale: IEssereVivente
    {
        public int Id { get; set; }

        public void stampaDati()
        {
            Console.WriteLine("Vegetale numero: " + this.Id);
        }

        public virtual void Fiorisci()
        {
            Console.WriteLine("Fioritura " + this.Id + " ..");
        }
    }
}
