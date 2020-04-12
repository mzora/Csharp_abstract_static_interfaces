using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Es_Personale
{
    public class Studente:Persona
    {
        public float MediaVoti { get; set; }
        public override void StampaDati()
        {
            //base.StampaDati();
            Console.WriteLine("Ecco lo studente "+ this.Id+" : "+this.Cognome);
            Console.WriteLine("e la media:" + MediaVoti);
        }
    }
}
