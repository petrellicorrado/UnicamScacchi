using Scacchi.Modello.Pezzi;
using Xunit;

namespace Scacchi.Modello
{
    public class CavalloTest
    {
        [Fact]
        public void MovimentoLInAltoASinistra()
        {
            //Given
            Cavallo cavallo = new Cavallo(Colore.Nero);
            //When
            bool esito = cavallo.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.C,
                traversaArrivo: Traversa.Sesta);
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void MovimentoLInAltoADestra()
        {
            //Given
            Cavallo cavallo = new Cavallo(Colore.Nero);
            //When
            bool esito = cavallo.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.E,
                traversaArrivo: Traversa.Sesta);
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void MovimentoLInBassoASinistra()
        {
            //Given
            Cavallo cavallo = new Cavallo(Colore.Nero);
            //When
            bool esito = cavallo.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.C,
                traversaArrivo: Traversa.Seconda);
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void MovimentoLInBassoADestra()
        {
            //Given
            Cavallo cavallo = new Cavallo(Colore.Nero);
            //When
            bool esito = cavallo.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.E,
                traversaArrivo: Traversa.Seconda);
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void MovimentoNonFattibile()
        {
            //Given
            Cavallo cavallo = new Cavallo(Colore.Nero);
            //When
            bool esito = cavallo.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.H,
                traversaArrivo: Traversa.Prima);
            //Then
            Assert.False(esito);
        }
    }
}