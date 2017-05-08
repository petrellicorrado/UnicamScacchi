using System;

namespace Scacchi.Modello
{
    public class Giocatore : IGiocatore
    {
<<<<<<< HEAD
        private string giocatore;

        public Giocatore(string giocatore)
        {
            this.giocatore = giocatore;
        }

        public string Nome { 
            get ;
            private set ;
        }
        public int Punteggio { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
=======
        public string Nome { get; private set; }
        public int Punteggio { get; set; }

        public Giocatore(string nome){
            this.Nome = nome;
        }
>>>>>>> upstream/master
    }
}