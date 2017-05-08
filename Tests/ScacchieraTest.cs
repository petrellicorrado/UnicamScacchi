using System;
using System.Collections.Generic;
using System.Linq;
using Scacchi.Modello;
using Scacchi.Modello.Pezzi;
using Xunit;

namespace Scacchi.Tests
{

    public class ScacchieraTest
    {

        [Fact]
        public void ScacchieraDeveAvere64Case()
        {
            //Given
            IScacchiera scacchiera = new Scacchiera();
            //When

            //Then
            Assert.Equal(64, scacchiera.Case.Count());
        }
        [Fact]
        public void indexerDeveRestituireCasaCorretta()
        {
            //Given
            IScacchiera scacchiera = new Scacchiera();
            //When
            ICasa casa = scacchiera[Colonna.F, Traversa.Quinta];
            //Then
            Assert.Equal(Colonna.F, casa.Colonna);
            Assert.Equal(Traversa.Quinta, casa.Traversa);
        }

        [Fact]
        public void InSecondaTraversaDevonoEsserciTuttiPedoniBianchi()
        {
            //Given
            IScacchiera scacchiera = new Scacchiera();
            //When
            //Prendo tutte le case che si trovano in seconda traversa
            IEnumerable<ICasa> caseInSecondaTraversa = scacchiera.Case.Where(casa => casa.Traversa == Traversa.Seconda);
            //Controllo che tutte le case in seconda traversa siano del tipo "Pedone"
            //sonoTuttiPedoni restituisce true solo se tutti i pezzi presenti in caseInSecondaTraversa sono pedoni e sono bianchi
            bool sonoTuttiPedoniBianchi = caseInSecondaTraversa.All(casa => casa.PezzoPresente is Pedone && casa.PezzoPresente.Colore == Colore.Bianco);
            /*
            Approccio ad accesso randomico
            for(int i = 1; i <= 8 ; i++)
                Assert.IsType(typeof(Pedone),scacchiera[(Colonna) i, Traversa.Seconda].PezzoPresente);
            */
            //Then
            Assert.True(sonoTuttiPedoniBianchi);
        }
        [Fact]
        public void DeveEsserciSoloUnReBiancoInPosizioneE1()
        {
            //Given
            IScacchiera scacchiera = new Scacchiera();
            //When
            IEnumerable<ICasa> caseConReBianco = scacchiera.Case.Where(casa => casa.PezzoPresente is Re && casa.PezzoPresente.Colore == Colore.Bianco);
            //Then
            Assert.Equal(1, caseConReBianco.Count());
            Assert.Equal(Colonna.E, caseConReBianco.First().Colonna);
            Assert.Equal(Traversa.Prima, caseConReBianco.First().Traversa);
        }

        [Theory]
        [InlineData(typeof(Torre), Colore.Bianco, Colonna.A, Traversa.Prima)]
        public void IPezziDevonoTrovarsiNellaPosizioneIndicataDallaSpecifica(Type tipoDiPezzo, Colore colorePezzo, Colonna colonna, Traversa traversa)
        {
        //Given
        IScacchiera scacchiera = new Scacchiera();
        scacchiera.Case.Single(casa =>
        casa.PezzoPresente != null
        && casa.PezzoPresente.GetType() == tipoDiPezzo
        && casa.PezzoPresente.Colore == colorePezzo
        && casa.Traversa == traversa
        && casa.Colonna == colonna);
        }

    }

}

