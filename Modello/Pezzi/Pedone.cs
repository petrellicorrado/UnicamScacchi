using System;

namespace Scacchi.Modello.Pezzi {
    public class Pedone : IPezzo
    {
        private readonly Colore colore;
        public Pedone(Colore colore)
        {
            this.colore = colore;    
        }
        public Colore Colore {
            get {
                return colore;
            }
        }
        public bool PuòMuovere(
            Colonna colonnaPartenza,
            Traversa traversaPartenza,
            Colonna colonnaArrivo,
            Traversa traversaArrivo)
        {
            var stessaColonna = (colonnaPartenza == colonnaArrivo);
            var distanzaTraLeTraverse = Math.Abs((int) traversaArrivo - (int) traversaPartenza);
            
            //I pedoni non possono rimanere fermi o muoversi indietro
            if(traversaPartenza >= traversaArrivo && this.colore == Colore.Bianco)
                return false;
            if(traversaPartenza <= traversaArrivo && this.colore == Colore.Nero)
                return false;
            
            //Se è la stessa colonna vedi se è un passaggio lecito
            if(stessaColonna){
                //Posso muovermi di 1
                if(distanzaTraLeTraverse == 1)
                    return true;
                //Pezzo bianco che parte dall'inizio e vuole partire con 2 posizioni
                else if(this.colore == Colore.Bianco && traversaPartenza == Traversa.Seconda && distanzaTraLeTraverse == 2)
                    return true;
                //Pezzo nero che parte dall'inizio e vuole partire con 2 posizioni
                else if(this.colore == Colore.Nero && traversaPartenza == Traversa.Settima && distanzaTraLeTraverse == 2)
                    return true;
                //Qualunque altro caso non è lecito
                else
                    return false;
            //In caso non sia la stessa colonna
            } else {
                return false;
            }
        }
        public override string ToString()
        {
            return "";
        }
    }
}