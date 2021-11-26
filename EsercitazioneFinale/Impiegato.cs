using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneFinale
{
    internal class Impiegato : Person
    {
        public Settori Settore { get; set; }
               
       public virtual decimal CalcoloStipendio()
        {
            return 0;
        }

        public List<Skill> Skills = new List<Skill>();

        public override string ToString()
            { 
            return base.ToString() + $"- {Settore} - stipendio: {CalcoloStipendio()} Euro \n";
        }

    }
    public enum Settori
    {
        Manutenzione =1,
        Amministrazione=2 ,
        Sviluppo=3 
    }

}
