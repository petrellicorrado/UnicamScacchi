using System;
using Scacchi.Modello.Pezzi;

namespace Scacchi.Modello
{
    public class Casa : ICasa
    {
        private Colonna colonna;
        private Traversa traversa;
<<<<<<< HEAD
        private IPezzo pezzoPresente;

=======
>>>>>>> upstream/master
        public Casa(Colonna colonna, Traversa traversa)
        {
            this.colonna = colonna;
            this.traversa = traversa;
        }

<<<<<<< HEAD
        public Colonna Colonna {
            get{
                return this.colonna;
            }
        }

        public Traversa Traversa {
            get{
                return this.traversa;
            }
        }

        public IPezzo PezzoPresente { 
            get{
                return pezzoPresente;
            }
            set {
                pezzoPresente = value;
            } 
=======

        public Colonna Colonna
        {
            get { return colonna; }
        }

        public Traversa Traversa
        {
            get { return traversa; }
        }

        private IPezzo pezzoPresente;
        public IPezzo PezzoPresente
        {
            get
            {
                return pezzoPresente;
            }
            set
            {
                pezzoPresente = value;
            }
>>>>>>> upstream/master
        }
    }
}