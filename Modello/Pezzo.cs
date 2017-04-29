using System;
using System.Collections.Generic;
using Scacchi.Modello;
using Scacchi.Modello.Pezzi;

public class Pezzo : IPezzo{

    private Colore colore;
    public Pezzo(Colore colore)
    {
        Colore = colore;    
    }

    public Colore Colore{
        get{
            return colore;
        }
        private set{
            colore = value;
        }
    }
    public virtual bool PuòMuovere(Colonna colonnaPartenza,
            Traversa traversaPartenza,
            Colonna colonnaArrivo,
            Traversa traversaArrivo,    
            IEnumerable<ICasa> scacchiera = null)
    {
        if(colonnaPartenza == colonnaArrivo && traversaPartenza == traversaArrivo)
            return false;

            
        return true;
    }

  
}