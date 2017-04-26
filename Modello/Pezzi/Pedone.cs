using System;

namespace Scacchi.Modello.Pezzi {
    public class Pedone : Pezzo
    {
        public Pedone(Colore Colore) : base(Colore)
        {
        }
        public override bool PuòMuovere(
            Colonna colonnaPartenza,
            Traversa traversaPartenza,
            Colonna colonnaArrivo,
            Traversa traversaArrivo,    
            IScacchiera scacchiera = null)
        {
            bool puòMuovere = base.PuòMuovere( colonnaPartenza,traversaPartenza,colonnaArrivo, traversaArrivo);

            if(!puòMuovere)
            return false;
            var stessaColonna = (colonnaPartenza == colonnaArrivo);
            var distanzaTraLeTraverse = Math.Abs((int) traversaArrivo - (int) traversaPartenza);
            
            //I pedoni non possono rimanere fermi o muoversi indietro
            if(traversaPartenza >= traversaArrivo && this.Colore == Colore.Bianco)
                return false;
            if(traversaPartenza <= traversaArrivo && this.Colore == Colore.Nero)
                return false;
            
            //Se è la stessa colonna vedi se è un passaggio lecito
            if(stessaColonna){
                //Posso muovermi di 1
                if(distanzaTraLeTraverse == 1)
                    return true;
                //Pezzo bianco che parte dall'inizio e vuole partire con 2 posizioni
                else if(this.Colore == Colore.Bianco && traversaPartenza == Traversa.Seconda && distanzaTraLeTraverse == 2)
                    return true;
                //Pezzo nero che parte dall'inizio e vuole partire con 2 posizioni
                else if(this.Colore == Colore.Nero && traversaPartenza == Traversa.Settima && distanzaTraLeTraverse == 2)
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
            return $"Pedone {Colore}";
        }

        public override bool Equals (object altroOggetto)
        {
            if(!(altroOggetto is Pedone))
                return false;

            //Restituisce se altro oggetto non è null ed il colori sono uguali
            return ((Pedone) altroOggetto)?.Colore == this.Colore;
        }
        

        public override int GetHashCode()
        {
            return Colore.GetHashCode();
        }
    }
}