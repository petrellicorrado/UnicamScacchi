using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
>>>>>>> upstream/master

namespace Scacchi.Modello.Pezzi {
    public class Donna : IPezzo
    {
        private readonly Colore colore;
        public Donna(Colore colore)
        {
<<<<<<< HEAD
=======

>>>>>>> upstream/master
            this.colore = colore;    
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
=======
        public bool PuòMuovere(
            Colonna colonnaPartenza,
            Traversa traversaPartenza,
            Colonna colonnaArrivo,
            Traversa traversaArrivo,
            IEnumerable<ICasa> listaCase = null)
        {
            var differenzaColonne = colonnaPartenza - colonnaArrivo;
            var differenzaTraverse = (int) traversaPartenza - (int) traversaArrivo;
            var stessaColonna = colonnaPartenza == colonnaArrivo;
            var stessaTraversa = traversaPartenza == traversaArrivo;
            if (differenzaColonne == 0 && differenzaTraverse == 0)
                return false;
            if((Math.Abs(differenzaColonne) <= 1 && Math.Abs(differenzaTraverse) <= 1) || ((stessaTraversa && !stessaColonna) 
            || (stessaColonna && !stessaTraversa)) || ((Math.Abs(differenzaColonne) - Math.Abs(differenzaTraverse)) == 0) )
            {
            return true;
            }else{
                return false;
            }
>>>>>>> upstream/master
        }
    }
}