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
        public void LAlfierePuoMuoversiInBassoADestra()
        {
            //Given
            Donna alfiere = new Donna(Colore.Bianco);
            //When
            bool esito = alfiere.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.E,
                traversaArrivo: Traversa.Terza);
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void LAlfierePuoMuoversiInBassoASinistra()
        {
            //Given
            Donna alfiere = new Donna(Colore.Bianco);
            //When
            bool esito = alfiere.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.C,
                traversaArrivo: Traversa.Terza);
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void LaTorrePuoMuoversiDiQuanteColonneVuole()
        {
            
            //Given
            Torre torre = new Torre(Colore.Bianco);
            //When
            bool esito = torre.PuòMuovere(Colonna.A, Traversa.Prima, Colonna.H, Traversa.Prima);
            //Then
            Assert.True(esito);
        }

        [Fact]
        public void LaTorrePuoMuoversiDiQuanteTraverseVuole()
        {
            
            //Given
            Torre torre = new Torre(Colore.Bianco);
            //When
            bool esito = torre.PuòMuovere(Colonna.A, Traversa.Prima, Colonna.A, Traversa.Settima);
            //Then
            Assert.True(esito);
        }

        [Fact]
        public void LaTorrePuoNonPuoMuoversiSpostandosiSiaDiColonnaCheDiTraversa()
        {
            
            //Given
            Torre torre = new Torre(Colore.Bianco);
            //When
            bool esito = torre.PuòMuovere(Colonna.A, Traversa.Prima, Colonna.C, Traversa.Settima);
            //Then
            Assert.False(esito);
        }
    }
}