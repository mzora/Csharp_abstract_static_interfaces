using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Personale
{
    
    class MainClass
    {
        public static void Main(string[] args)
        {   /*
            Impiegato dipendente_1 = new Impiegato();
            dipendente_1.Nome = "mario";
            dipendente_1.Cognome = "rossi";
            dipendente_1.Stipendio = 2000;

            Studente studente_1 = new Studente();
            studente_1.Cognome = "carli";
            studente_1.MediaVoti = 8.75f;
            */
            //dipendente_1.StampaDati();
            //studente_1.StampaDati();

            //seconda parte 100istanze

            List<string>[] array = UtilityNames.GetNames();
            List<string> nomi = array[0];
            List<string> cognomi = array[1];

            List<IPersona> persone = new List<IPersona>();
            for (int i = 0; i < 50; i++)
            {
                Impiegato dipendente = new Impiegato();
                dipendente.Id = i;
                //dipendente.Cognome = "dip_" + i.ToString();
                dipendente.Nome = Utility.getRandomStringFromList(nomi);
                dipendente.Cognome = Utility.getRandomStringFromList(cognomi);
                dipendente.Stipendio = Utility.getRandomNumber(1000,50000);


                Studente studente = new Studente();
                studente.Id = i;
                studente.Cognome = "stud_" + i.ToString();
                studente.MediaVoti = Utility.averGen();

                persone.Add(dipendente);
                persone.Add(studente);
            }

            foreach(IPersona persona in persone)
            {
                persona.StampaDati();
                Console.WriteLine("\n");
            }

            //terza parte
            //dipendente.nome = Utility.getRandomName();

            //quartaparte
            /*
            _ input utente 3 nomi possibili
            _ input utente 3 cognomi possibili
            _ valorizzare gli oggetti nel ciclo
            _ stipendio e mediavoti sono generati automaticamente

             */
        }
    }
}
