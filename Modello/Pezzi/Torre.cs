using System;

namespace Scacchi.Modello.Pezzi {
    public class Torre : IPezzo
    {
        private readonly Colore colore;
        public Torre(Colore colore)
        {
            this.colore = colore;
        }
        public Colore Colore {
            get {
                return colore;
            }
        }
        public bool PuòMuovere(Colonna colonnaPartenza, Traversa traversaPartenza, Colonna colonnaArrivo, Traversa traversaArrivo,    
            IScacchiera scacchiera = null)
        {
            if((int)colonnaPartenza == (int)colonnaArrivo && (int)traversaPartenza == (int)traversaArrivo)
                return false;
            if((int)colonnaPartenza != (int)colonnaArrivo && (int)traversaPartenza == (int)traversaArrivo)
                return true;
            if((int)colonnaPartenza == (int)colonnaArrivo && (int)traversaPartenza != (int)traversaArrivo)
                return true;
            return false;
                
        }
        public override string ToString()
        {
            return "T";
        }
    }
}