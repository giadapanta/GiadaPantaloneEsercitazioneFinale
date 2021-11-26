using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercitazioneFinale
{
    internal class Menu
    {
        internal static void Start()
        {
            char choice;
            do
            {
                Console.WriteLine("Scegli tra le seguenti opzioni:" +
                    "\n[1] Visualizzare tutti gli impiegati"+
                    "\n[2] Mostra gli impiegati di un certo settore"+
                    "\n[3] Inserisci un nuovo impiegato"+
                    "\n[4] Elimina un impiegato"+
                    "\n[5] Visualizza gli impiegati con uno stipendio maggiore"+
                    "\n[6] Visualizza tutti gli impiegati con una certa skill"+
                    "\n[Q] Esci");
                  
                choice = Console.ReadKey().KeyChar;
                switch(choice)
                {
                    case '1':
                        //Visualizzare gli impiegati 
                        VisualizzaImpiegati();
                        break;
                    case '2':
                        //Mostra impiegati con input utente: settore
                        MostraImpiegatiBySettore();
                        break;
                    case '3':
                        //inserire un nuovo impiegato
                        //AddNewImpiegato();
                        break;
                    case '4':
                        break;
                    case '5':
                        break;
                    case '6':
                        break;
                    case 'Q':
                        Console.WriteLine("\nARRIVEDERCI!!!");
                        break;
                    default:
                        Console.WriteLine("\nScelta non valida!");
                        break;
                }

            }while (choice !='Q');

        }

        //private static void AddNewImpiegato()
        //{
        //    List<Impiegato> Impiegati = TestManager.FetchImpiegati();
        //    string nome = GetData("nome") ;
        //    string cognome = GetData("cognome");
        //    string codice = GetData("codice fiscale");
        //    List<Impiegato> ImpiegatiByCodice= TestManager.FetchImpiegatiByCF(codice) ;
        //    int settore = GetSettore("settore");
        //    string tipo = GetData("tipo");

        //}

        //}

        

        private static void MostraImpiegatiBySettore()
        {
            int settore = GetSettore("SETTORE");
                     
            List<Impiegato> ImpiegatiBySettore = TestManager.FetchImpiegatiBySettore(settore);
            if(ImpiegatiBySettore.Count !=0)
                foreach(Impiegato impiegato in ImpiegatiBySettore)
                {
                    Console.WriteLine($"\nImpiegato: {impiegato}");
                }
            else
            {
                Console.WriteLine("Questo settore non è tra quelli presenti in azienda.");
            }

        }
        #region Recupero input utente
        private static int GetSettore(string message)
        {
            int settore;
            do
            {
                Console.WriteLine($"\nInserisci il {message}: ");
                
            }while (!int.TryParse(Console.ReadLine(), out settore) || settore <1 || settore >3);

            return settore;
        }
        private static string GetData(string message)
        {
            string info;
            do
            {
                Console.WriteLine($"Inserisci il {message} del nuovo impiegato");
                info = Console.ReadLine();

            }while (!string.IsNullOrEmpty(info));
            return info;
        }
        #endregion

        private static void VisualizzaImpiegati()
        {
            List<Impiegato> impiegati = TestManager.FetchImpiegati();
           foreach (Impiegato i in impiegati)
            {
                Console.WriteLine(i);
            }
        }
    }
}
