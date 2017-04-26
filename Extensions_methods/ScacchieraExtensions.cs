using System.Collections.Generic;
using System.Linq;
using Scacchi.Modello;
using Scacchi.Modello.Pezzi;

namespace Scacchi.Extensions_methods{
    public static class ScacchieraExtensions{
        public static IEnumerable<ICasa> ConPezzi(this IEnumerable<ICasa> listaCase){
            return listaCase.Where(casa => casa.PezzoPresente == null);
        }

         public static IEnumerable<ICasa> ConPezzi(this IEnumerable<ICasa> listaCase, Colore colore){
            return listaCase.Where(casa => casa.PezzoPresente == null && casa.PezzoPresente.Colore == colore);
            //return listaCase.Where(casa => casa.PezzoPresente?.Colore == colore); STESSA COSA!!!!
        }


        /*
            Permette di restituire in una lista di case i pezzi di un determinato tipo T che
            implementa IPezzo
        */
        //T deve essere di tipo IPezzo
        public static IEnumerable<ICasa> DiTipo<T>(this IEnumerable<ICasa> listaCase) where T : IPezzo{
            //Qualsiasi sia questo T controllo che sia dello stesso tipo dei pezzi presenti
            return listaCase.Where(casa => casa.PezzoPresente?.GetType() == typeof(T));
        }
    }
}