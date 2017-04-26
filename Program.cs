using System;
using System.Threading;
using Scacchi.Modello;
using Scacchi.Extensions_methods;
using Scacchi.Modello.Pezzi;
using System.Collections.Generic;
using System.Linq;

namespace Scacchi
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleXUnitRunner.SimpleXUnit.RunTests();
            Console.ReadKey();
            IScacchiera scacchiera = new Scacchiera();
            scacchiera
            .Case
            .ConPezzi(Colore.Bianco) //extension methods personale
            .DiTipo<Pedone>();

            //COVARIANZA
            //Noi facciamo sempre questo!!
            IPezzo pezzo = new Pedone(Colore.Bianco);
            //Non è possibile!!
            //Tutti i Pedoni sono IPezzo ma non tutti gli IPezzo sono pedoni
            /*List<IPezzo> pezzi = new List<Pedone>{
                new Pedone(Colore.Bianco), new Pedone(Colore.Nero)
            }*/
            //Se facessi pezzi.Add() mi consiglierebbe un IPezzo ma nulla mi dice
            //che non posso inserire una Torre, nella dichiarazione posso aggiungere
            //solo oggetti di IPezzo (tra cui Pedoni)

            //Posso farlo se faccio perchè IEnumerable non mi permette di modificare la collezione!!
            IEnumerable<IPezzo> pezzi = new List<Pedone>{
                new Pedone(Colore.Bianco), new Pedone(Colore.Nero)
            };

            //Proviamo con degli array - FUNZIONA!
            //Ma ci sono rischi a runtime
            IPezzo[] pezzi2 = new Pedone[]{
                new Pedone(Colore.Bianco), new Pedone(Colore.Nero)
            };
            //GENERA ERRORI A RUNTIME! pezzi[0] = new Torre(Colore.Bianco);


            /*
            IOrologio orologio = new Orologio(TimeSpan.FromSeconds(5));
            //Quando l'evento viene sollevato invoco NotificaSconfitta
            //Bisogna sottoscrivere gli eventi il prima possibile
            orologio.TempoScaduto += NotificaSconfitta;
            orologio.Accendi();
            //Non vengo più notificato dell'evento orologio.TempoScaduto -= NotificaSconfitta;
            orologio.Avvia();
           
            Console.ReadKey();

            /*
                Sintassi più compatta di orologio.TempoScaduto += NotificaSconfitta;

                orologio.TempoScaduto+=(sender,colore) => { Console.WriteLine($"Il giocatore {colore} ha perso la partita, secondo l'orologio {sender}"); }

                Questa è chiamata lambda expression!!!

                Vantaggi: Non devo creare NotificaSconfitta!
                            La lambdaexpression non ha nome e quindi non posso riusarla (quindi non posso disiscrivermi! dovrei
                            mettere la lambda e. in una variabile)
                            E' presente il simbolo => che dice "partendo con questi argomenti farò qualcosa nelle parentesi graffe"
            */



            /*
             ESEMPIO Dictionary (è modellato male dato che una partita non ha solo 1 scacch.)

            
             Dictionary<int, IScacchiera> partite = new Dictionary<int, IScacchiera>();
             int contatore = 1;
             partite.Add(contatore,new Scacchiera());
             //L'utente ha mosso un pezzo
             int chiave = 2;
             if(partite.ContainsKey(chiave)) //controllo che la chiave esista
                Console.WriteLine(partite[chiave].Case.Count());
            else
                Console.WriteLine("Non riesco a trovare questa partita");
             

             var pedone1 = new Pedone(Colore.Bianco);
             var pedone2 = new Pedone(Colore.Bianco);
             var dizionario = new Dictionary<Pedone, string>();
             dizionario.Add(pedone1, "Moreno");
             //non posso fare questa cosa perchè pedone1 == pedone2 sia per equals e sia per gethashcode
             dizionario.Add(pedone2, "Moreno");

             */
        }

        /*
        Ho generato un metodo che ha un sender (chi ha generato l'evento) e ciò che invia 
        */
        private static void NotificaSconfitta(object sender, Colore colore)
        {
            Console.WriteLine($"Il giocatore {colore} ha perso la partita, secondo l'orologio {sender}");
        }
    }
}
