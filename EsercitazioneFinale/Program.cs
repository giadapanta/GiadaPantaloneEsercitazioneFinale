//Creare una Console Application per la gestione degli impiegati di un’azienda.

//Entità:
//L’impiegato deve essere inteso come una derivazione di Persona.

//Persona ha le seguenti caratteristiche:
// Nome
// Cognome
// Codice Fiscale

//L’impiegato ha anche le seguenti caratteristiche:
// Settore(Manuntenzione, Amministrazione.Sviluppo)
// Calcolo stipendio mensile (metodo)
// Lista di skills

//Il Tecnico è un impiegato ma ha anche:
// Paga Oraria
// Ore Lavorate
// Calcolo stipendio: lo stipendio mensile del tecnico è dato da: Ore Lavorate * Paga Oraria

//Lo Stagista è un impiegato ma ha anche:
// Durata dello stage (in mesi. Esempio: 3)
// Calcolo stipendio: lo stipendio mensile dello stagista è 600 €.

//Il manager è un impiegato ma ha anche:
// Ore di straordinario (nel mese)
// Stipendio di base (mensile)
// Calcolo stipendio: lo stipendio mensile del manager è dato da: Stipendio Base + (Ore di
//straordinario * 10).

//La Skill ha come caratteristiche:
// Codice
// Descrizione
//(Esempio: Codice: “S1”, Descrizione: “Leadership”).

//Suggerimento:
//Inizializzare una lista di skills.
//Inizializzare una lista di impiegati, con almeno un elemento per ogni sottoclasse di impiegato e
//ognuno con almeno una skill nella propria lista di skills.

//Programma:
//All’accesso, l’utente deve poter scegliere tra:
//  1.Visualizzare tutti gli impiegati come Nome Cognome – Settore – Stipendio – (opzionale) Skills
//  2.Mostrare gli impiegati appartenenti ad un determinato settore (input: settore)
//  3.Inserire un nuovo impiegato, verificando che non sia già nella lista. Due Persone sono uguali se
//      hanno lo stesso codice fiscale.
//      Attenzione: aggiungere un nuovo impiegato vuol dire avere la possibilità di aggiungere un tecnico,
//      uno stagista o un manager.
//      Se l’utente sceglie di aggiungere, per esempio, un manager, bisognerà chiedere all’utente tutte le
//      informazioni sul manager. Stessa cosa per le altre figure.
//      Le skills da associare all’impiegato che si sta aggiungendo deve essere fatta tra le skills disponibili.
//      Non si può aggiungere due volte la stessa skill su un impiegato.
//  4. Eliminare un impiegato (input: codice fiscale).
//  5.Visualizzare gli impiegati con stipendio maggiore o uguale a quello inserito dall’utente.
//  6. Visualizzare tutti gli impiegati con una certa skill.

//Quando l’utente termina un’operazione, deve poter rivedere il menu e fare un’altra scelta.
//Inserire i controlli opportuni.
using EsercitazioneFinale;

Menu.Start();