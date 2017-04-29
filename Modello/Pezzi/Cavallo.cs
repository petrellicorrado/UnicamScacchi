using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
>>>>>>> upstream/master

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
<<<<<<< HEAD
        public bool PuòMuovere(Colonna colonnaPartenza, Traversa traversaPartenza, Colonna colonnaArrivo, Traversa traversaArrivo,    
            IScacchiera scacchiera = null)
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
            if(differenzaTraverse == 2 || differenzaTraverse == -2){
                if(differenzaColonne == 1 || differenzaColonne == -1){
                    return true;
                } else{
                    return false;
                }
            } else if(differenzaColonne == 2 || differenzaColonne == -2){
                
                if(differenzaTraverse == 1 || differenzaTraverse == -1){
                    return true;
                } else{
                    return false;
                }
            } else{
                return false;
            }
>>>>>>> upstream/master
        }
    }
}