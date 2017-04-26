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
        /*
            ACCESSO CASUALE
            Proprietà
            Che per accedere ad una specifica casa nella scacchiera vuole una colonna ed una traversa
        */
        ICasa this[Colonna colonna, Traversa traversa] { get;}
    }
}