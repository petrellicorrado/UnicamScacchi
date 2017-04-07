using Scacchi.Modello.Pezzi;
using Xunit;

namespace Scacchi.Modello
{
    public class ReTest
    {
        
        [Fact]
        public void MovimentoOrizzontale()
        {
            //Given
            Re re = new Re(Colore.Bianco);
            //When
             bool esito = re.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.E,
                traversaArrivo: Traversa.Quarta);
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void MovimentoVerticale()
        {
            //Given
            Re re = new Re(Colore.Bianco);
            //When
             bool esito = re.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.D,
                traversaArrivo: Traversa.Quinta);
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void MovimentoObliquo()
        {
            //Given
            Re re = new Re(Colore.Bianco);
            //When
             bool esito = re.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.E,
                traversaArrivo: Traversa.Quinta);
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void MovimentoNonValido()
        {
            //Given
            Re re = new Re(Colore.Bianco);
            //When
             bool esito = re.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.H,
                traversaArrivo: Traversa.Prima);
            //Then
            Assert.False(esito);
        }

    }
}