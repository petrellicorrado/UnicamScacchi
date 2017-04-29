using System;
using System.Collections.Generic;
using System.Linq;
using Scacchi.Modello;
using Scacchi.Modello.Pezzi;
using Xunit;

namespace Scacchi.Tests
{
<<<<<<< HEAD
    public class ScacchieraTest
    {
        [Fact]
        public void LaScacchieraDeveAvere64Case()
=======

    public class ScacchieraTest
    {

        [Fact]
        public void ScacchieraDeveAvere64Case()
>>>>>>> upstream/master
        {
            //Given
            IScacchiera scacchiera = new Scacchiera();
            //When

            //Then
<<<<<<< HEAD
            //.Count() si trova in LINQ
            Assert.Equal(64, scacchiera.Case.Count());
        }
        [Fact]
        public void IndexerDeveRestituireCasaCorretta()
=======
            Assert.Equal(64, scacchiera.Case.Count());
        }
        [Fact]
        public void indexerDeveRestituireCasaCorretta()
>>>>>>> upstream/master
        {
            //Given
            IScacchiera scacchiera = new Scacchiera();
            //When
<<<<<<< HEAD
            ICasa casa = scacchiera[Colonna.F, Traversa.Terza];
            //Then
            //.Count() si trova in LINQ
            Assert.Equal(Colonna.F, casa.Colonna);
            Assert.Equal(Traversa.Terza, casa.Traversa);
        }
=======
            ICasa casa = scacchiera[Colonna.F, Traversa.Quinta];
            //Then
            Assert.Equal(Colonna.F, casa.Colonna);
            Assert.Equal(Traversa.Quinta, casa.Traversa);
        }

>>>>>>> upstream/master
        [Fact]
        public void InSecondaTraversaDevonoEsserciTuttiPedoniBianchi()
        {
            //Given
            IScacchiera scacchiera = new Scacchiera();
            //When
<<<<<<< HEAD
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
=======
            /*for (int i = 1; i <= 8; i++){
            Assert.IsType(typeof(Pedone), scacchiera[(Colonna) i, Traversa.Seconda].PezzoPresente);
            }*/
            IEnumerable<ICasa> caseInSecondaTraversa = scacchiera.Case.Where(casa => casa.Traversa == Traversa.Seconda);
            bool sonoTuttiPedoni = caseInSecondaTraversa.All(casa => casa.PezzoPresente is Pedone && casa.PezzoPresente.Colore == Colore.Bianco);
            //Then
            Assert.True(sonoTuttiPedoni);
        }

        [Fact]
        public void DeveEsserciUnSoloReBiancoInPosizioneE1()
>>>>>>> upstream/master
        {
            //Given
            IScacchiera scacchiera = new Scacchiera();
            //When
            IEnumerable<ICasa> caseConReBianco = scacchiera.Case.Where(casa => casa.PezzoPresente is Re && casa.PezzoPresente.Colore == Colore.Bianco);
<<<<<<< HEAD
            //NON C'E' L'EQUALS!! IEnumerable<ICasa> caseConReBianco =  scacchiera.Case.Where(casa => casa.PezzoPresente.Equals(new Re(Colore.Bianco)));
            //Then
            //Il Re è 1 e si trova in E1
            Assert.Equal(1,caseConReBianco.Count());
=======
            //Then
            Assert.Equal(1, caseConReBianco.Count());
>>>>>>> upstream/master
            Assert.Equal(Colonna.E, caseConReBianco.First().Colonna);
            Assert.Equal(Traversa.Prima, caseConReBianco.First().Traversa);
        }

        [Theory]
<<<<<<< HEAD
        [InlineData(typeof(Torre),Colore.Bianco,Colonna.A, Traversa.Prima)]
        public void IPezziDevonoTrovarsiNellaPosizioneIndicataDallaSpecifica(Type tipoDiPezzo, Colore colorePezzo, Colonna colonna, Traversa traversa)
        {
            //Given
            IScacchiera scacchiera = new Scacchiera();
            //Mi aspetto che da questo criterio di filtro ci sia solo 1 risultato!
            scacchiera.Case.Single(casa =>
                casa.PezzoPresente != null &&
                casa.PezzoPresente.GetType() == tipoDiPezzo && 
                casa.PezzoPresente.Colore == colorePezzo &&
                casa.Traversa == traversa &&
                casa.Colonna == colonna);
            //When
            
            //Then
            //Non serve il controllo di 1 singolo pezzo!
        }
    }
}
=======
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

>>>>>>> upstream/master
