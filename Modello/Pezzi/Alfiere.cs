using System;
<<<<<<< HEAD

namespace Scacchi.Modello.Pezzi {
=======
using System.Collections.Generic;

namespace Scacchi.Modello.Pezzi
{
>>>>>>> upstream/master
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

        public bool PuòMuovere(Colonna colonnaPartenza, Traversa traversaPartenza, Colonna colonnaArrivo, Traversa traversaArrivo,    
            IScacchiera scacchiera = null)
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