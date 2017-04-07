using System;

namespace Scacchi.Modello.Pezzi {
    public class Re : IPezzo
    {
        private readonly Colore colore;
        public Re(Colore colore)
        {
            this.colore = colore;    
        }
        public Colore Colore {
            get {
                return colore;
            }
        }
        public bool PuòMuovere(Colonna colonnaPartenza, Traversa traversaPartenza, Colonna colonnaArrivo, Traversa traversaArrivo)
        {
            int distanzaColonna = Math.Abs((int)colonnaPartenza - (int)colonnaArrivo);
            int distanzaTraversa = Math.Abs((int)traversaPartenza - (int)traversaArrivo);
            
            if(distanzaColonna == 0 && distanzaTraversa == 1)
                return true;
            else if(distanzaColonna == 1 && distanzaTraversa == 1)
                return true;
            else if(distanzaColonna == 1 && distanzaTraversa == 0)
                return true;
            else
                return false;
            
        }
        public override string ToString()
        {
            return "R";
        }
    }
}