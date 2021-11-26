using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneFinale
{
    internal class TestManager
    {
        #region lista di skill
        public static List<Skill> Skills = new List<Skill>()
        {
            new Skill() {Codice = "C1", Descrizione ="Time management" },
            new Skill() {Codice="C2", Descrizione = "Resistenza allo stress"},
            new Skill() {Codice="C3", Descrizione= "Precisione"},
            new Skill() {Codice="C4", Descrizione="Lidearship"},
            new Skill() {Codice="C5", Descrizione= "Team Work"},
            new Skill() {Codice ="C6", Descrizione="Proattività"},
        };
        #endregion


        public static List<Impiegato> Impiegati = new List<Impiegato>()
        {
            new Tecnico () {Nome = "Mario", Cognome ="Verdi", CodiceFiscale ="VRDMR12A65C543W",
                             Settore= Settori.Manutenzione, PagaOraria=11, OreLavorate= 160,
                             Skills= new List<Skill>(){Skills [0], Skills[1]}},
            new Tecnico () {Nome = "Massimo", Cognome ="Bianchi", CodiceFiscale ="BNCMS56H65C512Q",
                             Settore= Settori.Amministrazione, PagaOraria=12, OreLavorate= 170,
                             Skills = new List<Skill> () {Skills[1] } },
            new Stagista () {Nome ="Chiara", Cognome="Rossi", CodiceFiscale="RSSCHA65R27Y127T",
                             Settore=Settori.Manutenzione, DurataStage=6,
                                Skills= new List<Skill>(){Skills [4], Skills[5]}},
            new Stagista () {Nome ="Luca", Cognome="Neri", CodiceFiscale="NRLCA43R12Q654Y",
                             Settore=Settori.Sviluppo, DurataStage=6,
                             Skills= new List<Skill>(){Skills [0], Skills[4]}},
            new Manager (){Nome ="Marco", Cognome="Rossi", CodiceFiscale= "RSSMRC12A32E120P",
                            Settore=Settori.Amministrazione,OreExtra= 20, StipendioBase= 2100,
                            Skills= new List<Skill>(){Skills [0], Skills[5]}},
            new Manager (){Nome ="Maria", Cognome="Gialli", CodiceFiscale= "GLLMRA14R56Q678L",
                            Settore=Settori.Sviluppo, OreExtra= 15, StipendioBase= 3000,
                            Skills= new List<Skill>(){Skills [3], Skills[4]}},
        };


        internal static List<Impiegato> FetchImpiegatiBySettore(int settore)
        {
            List<Impiegato> ImpiegatiBySettore = new List<Impiegato>();
            Console.WriteLine($"Gli impiegati del settore {(Settori)settore} sono:\n ");

            foreach (Impiegato i in Impiegati)
                if (i.Settore == (Settori)settore)
                    ImpiegatiBySettore.Add(i);
            return ImpiegatiBySettore;


        }
        //internal static List<Impiegato> FetchImpiegatiByCF(string codice)
        //{
        //    List<Impiegato> ImpiegatiByCodice = new List<Impiegato> ();
        //    foreach (Impiegato i in Impiegati)
        //    { if (i.CodiceFiscale != codice)
        //        {
        //            ImpiegatiByCodice.Add(i);
        //            return ImpiegatiByCodice;
        //        }
        //        else Console.WriteLine($"Codice fiscale già esistente -> l'impiegato è già " +
        //            $"nella lista");
        //        return null;
        //    }



        internal static List<Impiegato> FetchImpiegati()
        {
            return Impiegati;
        }
    }
}  

    
    

