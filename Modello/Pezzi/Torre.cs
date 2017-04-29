using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
>>>>>>> upstream/master

namespace Scacchi.Modello.Pezzi {
    public class Torre : IPezzo
    {
        private readonly Colore colore;
        public Torre(Colore colore)
        {
<<<<<<< HEAD
            this.colore = colore;
=======
            this.colore = colore;    
>>>>>>> upstream/master
        }
        public Colore Colore {
            get {
                return colore;
            }
        }
<<<<<<< HEAD
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
=======
        public bool PuòMuovere(
            Colonna colonnaPartenza,
            Traversa traversaPartenza,
            Colonna colonnaArrivo,
            Traversa traversaArrivo,
           IEnumerable<ICasa> listaCase = null)
        {
            var stessaColonna = colonnaPartenza == colonnaArrivo;
            var stessaTraversa = traversaPartenza == traversaArrivo;

            if((stessaTraversa && !stessaColonna) || (stessaColonna && !stessaTraversa)){
                return true;
            }else{
                return false;
            }
            
>>>>>>> upstream/master
        }
    }
}