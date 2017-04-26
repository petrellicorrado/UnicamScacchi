using System;
using System.Collections.Generic;
using System.Linq;
using Scacchi.Modello.Pezzi;

namespace Scacchi.Modello{
    public class Scacchiera : IScacchiera
    {
        //Campo privato
        private ICasa[] listaCase;
        public Scacchiera(){
            //Ha creato un array con 64 celle vuote
            listaCase = new ICasa[64];
            /*int contaPosizione = 0;
            ICasa casa = null;
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    casa = new Casa((Colonna)i,(Traversa)j);
                    listaCase[contaPosizione] = casa;
                    ++contaPosizione;
                }   
            }*/
            
             //Con LINQ - Alternativa ai cicli for annidati
             //Mi genera una lista di 64 elementi
             listaCase = Enumerable.Range(0,64)
             //Per ognuno di essi mi aspetto una casa e gli setto la scacchiera attraverso il metodo
             //CreaCasa, esso ha la responsabilità di settare la casa avendo un intero come input
             .Select(i => CreaCasa(i))
             .ToArray();

             
             
        }

        //Internal perchè voglio che sia accedibile al mio test
        internal ICasa CreaCasa(int i)
        {
            //Calcolo colonna e traversa
            Colonna colonna = (Colonna)(i%8+1);
            Traversa traversa = (Traversa)(i/8+1);
            //Genero la casa vuota
            ICasa casa = new Casa(colonna , traversa);

            if(traversa == Traversa.Seconda)
                casa.PezzoPresente = new Pedone(Colore.Bianco);
            else if(traversa == Traversa.Settima)
                casa.PezzoPresente = new Pedone(Colore.Nero);
            else if(traversa == Traversa.Prima || traversa == Traversa.Ottava){
                Colore colore = traversa == Traversa.Prima ? Colore.Bianco : Colore.Nero;
                switch(colonna){
                    case Colonna.A:
                        casa.PezzoPresente = new Torre(colore);
                        break;
                    case Colonna.B:
                        casa.PezzoPresente = new Cavallo(colore);
                        break;
                    case Colonna.C:
                        casa.PezzoPresente = new Alfiere(colore);
                        break;
                    case Colonna.D:
                        casa.PezzoPresente = new Donna(colore);
                        break;
                    case Colonna.E:
                        casa.PezzoPresente = new Re(colore);
                        break;
                    case Colonna.F:
                        casa.PezzoPresente = new Alfiere(colore);
                        break;
                    case Colonna.G:
                        casa.PezzoPresente = new Cavallo(colore);
                        break;
                    case Colonna.H:
                        casa.PezzoPresente = new Torre(colore);
                        break;
                }
            }
            return casa;
        }

        /*
        Indexer
        Permette di arrivare ad una specifica casa conoscendo la colonna e la traversa */
        public ICasa this[Colonna colonna, Traversa traversa] {
            get{
                return listaCase[(int)colonna - 1 + ((int)traversa-1)*8];
            }
        }

        public IEnumerable<ICasa> Case{
            get{
                return listaCase;
            }
        }

    }
}