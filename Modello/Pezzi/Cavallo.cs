using System;

namespace Scacchi.Modello.Pezzi {
    public class Cavallo : IPezzo
    {
        public Colore Colore => throw new NotImplementedException();

        public bool PuòMuovere(Colonna colonnaPartenza, Traversa traversaPartenza, Colonna colonnaArrivo, Traversa traversaArrivo)
        {
            throw new NotImplementedException();
        }
    }
}