<<<<<<< HEAD
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
=======

using System.Collections.Generic;

namespace Scacchi.Modello{
    public interface ITavolo {
        void RiceviGiocatori(string nomeBianco, string nomeNero);
        Dictionary<Colore,IGiocatore> Giocatori {get;}
        void AvviaPartita();
        IScacchiera Scacchiera { get; }
        IOrologio Orologio { get; }
        void InserisciMossa(string mossa);

    }
}
>>>>>>> upstream/master
