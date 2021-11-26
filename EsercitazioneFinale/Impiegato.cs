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
        public decimal Stipendio { get; set; }
        
       public static decimal CalcoloStipendio()
        {
            return 0;
        }

    }
    public enum Settori
    {
        Vendite =1,
        Amministrazione=2 ,
        Sviluppo=3 
    }

}
