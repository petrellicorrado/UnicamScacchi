using Scacchi.Modello.Pezzi;
using Xunit;

namespace Scacchi.Modello
{
    public class DonnaTest
    {
        [Fact]
        public void LaDonnaPuoMuoversiInAltoADestra()
        {
            //Given
            Donna donna = new Donna(Colore.Bianco);
            //When
            bool esito = donna.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.E,
                traversaArrivo: Traversa.Quinta);
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void LaDonnaPuoMuoversiInAltoASinistra()
        {
            //Given
            Donna donna = new Donna(Colore.Bianco);
            //When
            bool esito = donna.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.C,
                traversaArrivo: Traversa.Quinta);
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void LaDonnaPuoMuoversiInBassoADestra()
        {
            //Given
            Donna donna = new Donna(Colore.Bianco);
            //When
            bool esito = donna.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.E,
                traversaArrivo: Traversa.Terza);
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void LaDonnaPuoMuoversiInBassoASinistra()
        {
            //Given
            Donna donna = new Donna(Colore.Bianco);
            //When
            bool esito = donna.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.C,
                traversaArrivo: Traversa.Terza);
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void LaDonnaPuoMuoversiDiQuanteColonneVuole()
        {
            
            //Given
            Donna donna = new Donna(Colore.Bianco);
            //When
            bool esito = donna.PuòMuovere(Colonna.A, Traversa.Prima, Colonna.H, Traversa.Prima);
            //Then
            Assert.True(esito);
        }

        [Fact]
        public void LaDonnaPuoMuoversiDiQuanteTraverseVuole()
        {
            
            //Given
            Donna donna = new Donna(Colore.Bianco);
            //When
            bool esito = donna.PuòMuovere(Colonna.A, Traversa.Prima, Colonna.A, Traversa.Settima);
            //Then
            Assert.True(esito);
        }
    }
}