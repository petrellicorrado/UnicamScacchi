using Scacchi.Modello.Pezzi;
using Xunit;

namespace Scacchi.Modello
{
    public class TorreTest
    {
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