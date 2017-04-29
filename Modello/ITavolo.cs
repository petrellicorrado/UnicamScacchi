using System;
using System.Collections.Generic;

namespace Scacchi.Modello{
    public interface ITavolo{
        IScacchiera Scacchiera{ get; }
        IOrologio Orologio{ get; }
        Dictionary<Colore,IGiocatore> Giocatori{get;}
        void RiceviGiocatori(String giocatoreBianco,String giocatoreNero);
        void AvviaPartita();
        void InserisciMossa(string mossa);
    }
}