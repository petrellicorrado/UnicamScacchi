using System;

namespace Scacchi.Modello.Pezzi {
    public class Donna : IPezzo
    {
        private readonly Colore colore;
        public Donna(Colore colore)
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
            int     numeroColonnaPartenza = (int)colonnaPartenza,
                    numeroTraversaPartenza = (int)traversaPartenza,
                    numeroColonnaArrivo = (int)colonnaArrivo,
                    numeroTraversaArrivo = (int)traversaArrivo;
            
            if(numeroColonnaPartenza == numeroColonnaArrivo && numeroTraversaPartenza == numeroTraversaArrivo)
                return false;
            //Mi muovo per la colonna
            if(numeroColonnaPartenza != numeroColonnaArrivo && numeroTraversaPartenza == numeroTraversaArrivo)
                return true;
            //Mi muovo per la traversa
            if(numeroColonnaPartenza == numeroColonnaArrivo && numeroTraversaPartenza != numeroTraversaArrivo)
                return true;
            //Mi muovo di diagonale
            if(Math.Abs(numeroColonnaArrivo - numeroColonnaPartenza) == Math.Abs(numeroTraversaArrivo-numeroTraversaPartenza))
                return true;

            //Qualunque altro caso
            return false;
            
        }
        public override string ToString()
        {
            return "D";
        }
    }
}