using Scacchi.Modello.Pezzi;
using Xunit;

namespace Scacchi.Modello
{
    public class AlfiereTest
    {
        [Fact]
        public void LAlfierePuoMuoversiInAltoADestra()
        {
            //Given
            Alfiere alfiere = new Alfiere(Colore.Bianco);
            //When
            bool esito = alfiere.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.E,
                traversaArrivo: Traversa.Quinta);
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void LAlfierePuoMuoversiInAltoASinistra()
        {
            //Given
            Alfiere alfiere = new Alfiere(Colore.Bianco);
            //When
            bool esito = alfiere.PuòMuovere(
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
            Alfiere alfiere = new Alfiere(Colore.Bianco);
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
            Alfiere alfiere = new Alfiere(Colore.Bianco);
            //When
            bool esito = alfiere.PuòMuovere(
                colonnaPartenza: Colonna.D,
                traversaPartenza: Traversa.Quarta,
                colonnaArrivo: Colonna.C,
                traversaArrivo: Traversa.Terza);
            //Then
            Assert.True(esito);
        }
    }
}