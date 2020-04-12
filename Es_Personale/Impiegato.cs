using System;
namespace Es_Personale
{
    public class Impiegato:Persona
    {
        //costruttore con int id serve per prendere i dati dal db
        //Impiegato impiegato = new Impiegato(512)

        /*
        public Impiegato()
        {
            this.Nome = Utility.getRandomName();
        }
        */

        public int Stipendio { get; set; }
        public override void StampaDati()
        {
            //base.StampaDati();
            Console.WriteLine("Ecco l'impiegato "+this.Id +" : "+ this.Cognome+" "+ this.Nome);
            Console.WriteLine("stipendio:" + Stipendio);
        }
    }
}
