using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneFinale
{
    internal class Manager : Impiegato 
    {
        public decimal OreExtra { get; set; }   
        public decimal StipendioBase { get; set; }

        public override decimal CalcoloStipendio()
        {
            decimal stipendio;
            stipendio = StipendioBase + OreExtra * 10;
            return stipendio;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
