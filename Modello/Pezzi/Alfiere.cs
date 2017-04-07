using System;

namespace Scacchi.Modello.Pezzi {
    public class Alfiere : IPezzo
    {
        private readonly Colore colore;
        public Alfiere(Colore colore)
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
            int     numeroColonnaPartenza = (int)colonnaPartenza,
                    numeroTraversaPartenza = (int)traversaPartenza,
                    numeroColonnaArrivo = (int)colonnaArrivo,
                    numeroTraversaArrivo = (int)traversaArrivo;

            if(numeroColonnaPartenza == numeroColonnaArrivo && numeroTraversaPartenza == numeroTraversaArrivo)
                return false;
            else if(Math.Abs(numeroColonnaArrivo - numeroColonnaPartenza) == Math.Abs(numeroTraversaArrivo-numeroTraversaPartenza))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "A";
        }
    }
}