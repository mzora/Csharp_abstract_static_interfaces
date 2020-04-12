using System;
namespace Es_Personale
{
    public abstract class Persona : IPersona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public int Id { get; set; }


        public virtual void StampaDati()
        {
            Console.WriteLine("Id della persona: " + Id);
        }
    }
}
