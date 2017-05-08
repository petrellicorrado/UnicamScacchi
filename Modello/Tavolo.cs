using System;
using System.Collections.Generic;
<<<<<<< HEAD

namespace Scacchi.Modello{
    public class Tavolo : ITavolo
    {
        
        private readonly IScacchiera scacchiera;
        private readonly IOrologio orologio;
        public Tavolo(IScacchiera scacchiera, IOrologio orologio)
        {
            Scacchiera = scacchiera;
            Orologio = orologio;
        }
        public Dictionary<Colore, IGiocatore> Giocatori{
            get; private set;
        }

        public IScacchiera Scacchiera {
            get;
            private set;
        }
        public IOrologio Orologio {
            get;
            private set;
        }


        public void AvviaPartita()
        {
            if(Giocatori == null)
                throw new InvalidOperationException("Attenzione, Prima devi indicare i nomi dei giocatori");
=======
using Scacchi.Modello;
namespace Scacchi.Modello{
    public class Tavolo : ITavolo
    {
        public Tavolo(IScacchiera scacchiera, IOrologio orologio)
        {
            Scacchiera = scacchiera;
            Orologio = orologio;    
        }
        public Dictionary<Colore, IGiocatore> Giocatori {get; private set;}

        public IScacchiera Scacchiera { get; private set; }
        public IOrologio Orologio { get; private set; }

        public void AvviaPartita()
        {
            if (Giocatori == null)
                throw new InvalidOperationException("Attenzione, prima devi indicare i nomi dei giocatori!");

>>>>>>> upstream/master
            Orologio.Accendi();
            Orologio.Avvia();
        }

        public void InserisciMossa(string mossa)
        {
<<<<<<< HEAD
            Coordinata partenza = InterpretaCoordinataCasa(mossa.Substring(0,2));
            Coordinata arrivo = InterpretaCoordinataCasa(mossa.Substring(3,2));

            //ALTRO
        }

        internal Coordinata InterpretaCoordinataCasa(string casa){
            /* INSERISCI VALIDAZIONE DI UNA MOSSA */
            Enum.TryParse<Colonna>(casa.Substring(0,1), out Colonna colonna);
            int.TryParse(casa.Substring(1,1),out int traversaTMP);
            Traversa traversa = (Traversa)traversaTMP;
            return new Coordinata(traversa, colonna);
        }

        public void RiceviGiocatori(String giocatoreBianco,String giocatoreNero)
        {
            Giocatori = new Dictionary<Colore,IGiocatore>();
            Giocatori.Add(Colore.Bianco,new Giocatore(giocatoreBianco));
            Giocatori.Add(Colore.Nero,new Giocatore(giocatoreNero));
        }
    }
}
=======
           
            Coordinata partenza = InterpretaCoordinataCasa(mossa.Substring(0, 2));
            Coordinata arrivo = InterpretaCoordinataCasa(mossa.Substring(3, 2));

            ///
        }

        internal Coordinata InterpretaCoordinataCasa(string casa) {
            Enum.TryParse<Colonna>(casa.Substring(0, 1), out Colonna colonna);
            int.TryParse(casa.Substring(1, 1), out int traversaInt);
            Traversa traversa = (Traversa) traversaInt;
            return new Coordinata(traversa, colonna);
        }


        public void RiceviGiocatori(string nomeBianco, string nomeNero)
        {
            Giocatori = new Dictionary<Colore,IGiocatore>();
            Giocatori.Add(Colore.Bianco, new Giocatore(nomeBianco));
            Giocatori.Add(Colore.Nero, new Giocatore(nomeNero));
        }
    }
}
>>>>>>> upstream/master
