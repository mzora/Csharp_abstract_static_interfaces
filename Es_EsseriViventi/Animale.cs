using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_EsseriViventi
{
    public abstract class Animale:IEssereVivente
    {
        public int Id { get; set; }
        public void stampaDati()
        {
            Console.WriteLine("Animale numero: " + this.Id);
        }

        public virtual void Muoviti()
        {
            Console.WriteLine("animale "+this.Id+" movimento eseguito..");
        }
    }
}
