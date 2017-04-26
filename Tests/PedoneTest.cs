using Scacchi.Modello.Pezzi;
using Xunit;

namespace Scacchi.Modello
{
    public class PedoneTest
    {
        [Fact]
        public void IlPedoneBiancoPuoMuovereInDiagonalePerMangiare()
        {
            //Given
            var pedone = new Pedone(Colore.Bianco);
            var pedoneNero = new Pedone(Colore.Nero);
            //When
            bool esito = pedone.PuòMuovere(Colonna.C, Traversa.Terza, Colonna.D, Traversa.Quarta);
            //Then
            Assert.True(esito);
        }
        [Fact]
        public void IlPedoneNonPuòRestareFermo(){
            //Given
            var pedone = new Pedone(Colore.Bianco);
            //When
            bool esito = pedone.PuòMuovere(
                colonnaPartenza : Colonna.A,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo : Colonna.A,
                traversaArrivo: Traversa.Prima);
            //Then
            Assert.False(esito);
        }

        [Theory]
        //Eseguo il test 2 volte, una per bianco ed una per nero
        [InlineData(Colore.Bianco)]
        [InlineData(Colore.Nero)]
        public void IlReNonPuòRestareFermo(Colore c){
            //Given
            var re = new Re(c);
            //When
            bool esito = re.PuòMuovere(
                colonnaPartenza : Colonna.A,
                traversaPartenza: Traversa.Prima,
                colonnaArrivo : Colonna.A,
                traversaArrivo: Traversa.Prima);
            //Then
            Assert.False(esito);
        }
       
       
        [Fact]
        public void IlPedoneBiancoPuoMuovereAvantiDiUnaCasa()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Bianco);
            //When
            bool esito = pedone.PuòMuovere(
                    colonnaPartenza: Colonna.A,
                    traversaPartenza: Traversa.Seconda,
                    colonnaArrivo: Colonna.A,
                    traversaArrivo: Traversa.Terza);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void IlPedoneNeroPuoMuovereAvantiDiUnaCasa()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Nero);
            //When
            bool esito = pedone.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Settima,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Sesta);

            //Then
            Assert.True(esito);
        }

        [Fact]
        public void IlPedoneBiancoPuoMuovereAvantiDiDueCase()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Bianco);
            //When
            bool esito = pedone.PuòMuovere(
                    colonnaPartenza: Colonna.A,
                    traversaPartenza: Traversa.Seconda,
                    colonnaArrivo: Colonna.A,
                    traversaArrivo: Traversa.Quarta);

            //Then
            Assert.True(esito);
        }
        [Fact]
        public void IlPedoneNeroPuoMuovereAvantiDiDueCase()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Nero);
            //When
            bool esito = pedone.PuòMuovere(
                colonnaPartenza: Colonna.A,
                traversaPartenza: Traversa.Settima,
                colonnaArrivo: Colonna.A,
                traversaArrivo: Traversa.Quinta);

            //Then
            Assert.True(esito);
        }
        [Fact]
        public void IlPedoneBiancoNonPuoMuovereIndietro()
        {
            //Given
            Pedone pedone = new Pedone(Colore.Bianco);
            //When
            bool esito = pedone.PuòMuovere(
                    colonnaPartenza: Colonna.A,
                    traversaPartenza: Traversa.Quinta,
                    colonnaArrivo: Colonna.A,
                    traversaArrivo: Traversa.Quarta);
            //Then
            Assert.False(esito);
        }
        [Fact]
        public void IlPedoneNeroNonPuoMuovereIndietro()
        {
             //Given
            Pedone pedone = new Pedone(Colore.Nero);
            //When
            bool esito = pedone.PuòMuovere(
                    colonnaPartenza: Colonna.A,
                    traversaPartenza: Traversa.Quarta,
                    colonnaArrivo: Colonna.A,
                    traversaArrivo: Traversa.Quinta);
            //Then
            Assert.False(esito);
        }
    }
}