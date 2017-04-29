using System;

namespace Scacchi.Modello {
    public interface IOrologio {
        TimeSpan TempoResiduoBianco {get;}
        TimeSpan TempoResiduoNero {get;}
        Colore TurnoAttuale {get;}
        TimeSpan TempoIniziale {get;}
        bool InPausa { get; }

        void Accendi();
        void Avvia();
        void Pausa();
        void Reset();
        void FineTurno();

        /*Impone che il mio metodo che vuole sottoscriversi abbia un parametro di tipo Colore */
        event EventHandler<Colore> TempoScaduto;
    }
}