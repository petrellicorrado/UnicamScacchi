using System;
using System.Collections.Generic;

namespace Scacchi.Modello
{
    public interface IScacchiera
    {
        //ACCESSO SEQUENZIALE
        //Consentiamo solamente di elencare le case (non aumentarle non diminuirle)
        //Qualcosa di scorribile attraverso un foreach (restituirà ogni volta un'istanza
        //di una Casa che può essere solo visualizzata)
        IEnumerable<ICasa> Case { get; }
        ICasa this[Colonna colonna, Traversa traversa] { get; }
        bool ReInVita(Colore colore);
        void SpostaPezzo(ICasa casaPartenza, ICasa casaArrivo);

    }
}