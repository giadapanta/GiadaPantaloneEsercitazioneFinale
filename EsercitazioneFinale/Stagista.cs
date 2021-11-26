using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneFinale
{
    internal class Stagista : Impiegato 
    {
        public int DurataStage { get; set; }
        public override decimal CalcoloStipendio()
        {
            int stipendio;
            stipendio = 600;
            return stipendio;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
