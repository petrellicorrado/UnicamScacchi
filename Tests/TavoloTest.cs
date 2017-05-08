using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
using Scacchi.Modello.Pezzi;
using Xunit;

namespace Scacchi.Modello
=======
using Scacchi.Modello;
using Xunit;

namespace Scacchi.Tests
>>>>>>> upstream/master
{
    public class TavoloTest
    {
        [Fact]
<<<<<<< HEAD
        public void ControlloCheNelTavoloCiSiaUnGiocatoreBiancoEdUnoNero()
        {
            //Given
            ITavolo tavolo = new Tavolo(null,null);
            //When
            tavolo.RiceviGiocatori("Bianco","Nero");
            Dictionary<Colore,IGiocatore> dict = tavolo.Giocatori;
            IGiocatore bianco = dict[Colore.Bianco];
            IGiocatore nero = dict[Colore.Nero];
            //Then
            Assert.Equal(2,dict.Count);
            //Assert.Equal(1,dict.Where(colore => colore.Key == Colore.Bianco).Count());
            //Assert.Equal(1,dict.Where(colore => colore.Key == Colore.Nero).Count());
            Assert.Equal("Bianco",bianco.Nome);
            Assert.Equal("Nero",nero.Nome);
        }
        [Fact]
        public void AllAvvioDellaPartitaDeveEsserePredispostaUnaScacchieraELorologioAvviato()
=======
        public void TestIlTavoloHaDueGiocatori()
        {
            ITavolo tavolo = new Tavolo(null, null);

            tavolo.RiceviGiocatori("Bianco", "Nero");

            Dictionary<Colore, IGiocatore> dict = tavolo.Giocatori;
            IGiocatore bianco = dict[Colore.Bianco];
            IGiocatore nero = dict[Colore.Nero];

            Assert.Equal(2, dict.Count);

            Assert.Equal(1, dict.Where(colore => colore.Key == Colore.Bianco).Count());
            Assert.Equal(1, dict.Where(colore => colore.Key == Colore.Nero).Count());

            Assert.Equal("Bianco", bianco.Nome);
            Assert.Equal("Nero", nero.Nome);

        }

        [Fact]
        public void AllAvvioDellaPartitaDeveEsserePredispostaUnaScacchieraELOrologioAvviato()
>>>>>>> upstream/master
        {
            //Given
            IScacchiera scacchiera = new Scacchiera();
            IOrologio orologio = new Orologio();
<<<<<<< HEAD
            ITavolo tavolo = new Tavolo(scacchiera,orologio);
            //When
            tavolo.RiceviGiocatori("","");
            tavolo.AvviaPartita();
            //Then
            Assert.NotEqual(null,tavolo.Scacchiera);
            Assert.NotEqual(null,tavolo.Orologio);
            Assert.False(orologio.InPausa);

        }

        [Fact]
        public void iLtavoloDeveEssereInGradoDiInterpretareLeCoordinateDigitateDallUtente()
        {
            //Given
            Tavolo tavolo = new Tavolo(null,null);
            //When
            Coordinata coordinata = tavolo.InterpretaCoordinataCasa("A4");
            //Then
            Assert.Equal(Traversa.Quarta,coordinata.Traversa);
            Assert.Equal(Colonna.A,coordinata.Colonna);
=======
            ITavolo tavolo = new Tavolo(scacchiera, orologio);

            //When
            tavolo.RiceviGiocatori("", "");
            tavolo.AvviaPartita();

            //Then
            Assert.NotEqual(null, tavolo.Scacchiera);
            Assert.NotEqual(null, tavolo.Orologio);
            Assert.False(orologio.InPausa);
        }

        [Fact]
        public void IlTavoloDeveEssereInGradoDiInterpretareLeCoordinateDigitateDallUtente()
        {
        //Given
        Tavolo tavolo = new Tavolo(null, null);
        //When
        Coordinata coordinata = tavolo.InterpretaCoordinataCasa("A4");
        
        //Then
        Assert.Equal(Traversa.Quarta, coordinata.Traversa);
        Assert.Equal(Colonna.A, coordinata.Colonna);
>>>>>>> upstream/master
        }
    }
}