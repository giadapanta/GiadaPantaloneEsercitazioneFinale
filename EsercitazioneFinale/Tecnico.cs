using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneFinale
{
    internal class Tecnico : Impiegato
    {
        public decimal PagaOraria { get; set; } 
        public decimal OreLavorate { get; set; } 
        
        public override decimal CalcoloStipendio()
        {
            decimal stipendio;
            stipendio = PagaOraria * OreLavorate;
            return stipendio;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
