using System;

namespace Scacchi.Modello.Pezzi {
    public class Cavallo : IPezzo
    {
        private readonly Colore colore;
        public Cavallo(Colore colore)
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
            
            //Distanza traversa 2; Distanza Colonna 1
            if(Math.Abs(numeroTraversaPartenza - numeroTraversaArrivo) == 2 && Math.Abs(numeroColonnaPartenza - numeroColonnaArrivo) == 1)
                return true;
            //Distanza traversa 1; Distanza Colonna 2
            if(Math.Abs(numeroTraversaPartenza - numeroTraversaArrivo) == 1 && Math.Abs(numeroColonnaPartenza - numeroColonnaArrivo) == 2)
                return true;
            //TUTTI GLI ALTRI CASI
            return false;
            
        }
        public override string ToString()
        {
            return "C";
        }
    }
}