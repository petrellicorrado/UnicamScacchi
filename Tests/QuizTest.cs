using System;
using Scacchi.Modello.Pezzi;
using Xunit;

namespace Scacchi.Modello
{
    public class QuizTest
    {
        [Fact]
        public void ComportamentoDiCasa()
        {
            //Given
            ICasa casa1 = new Casa(Colonna.A, Traversa.Prima);
            ICasa casa2 = casa1;
            //When
            casa1.PezzoPresente = new Pedone(Colore.Bianco); //riga inutile!!
            casa2.PezzoPresente = new Pedone(Colore.Nero);
            //Then
            Assert.Equal(Colore.Nero ,casa1.PezzoPresente.Colore);
            Assert.Equal(Colore.Nero ,casa2.PezzoPresente.Colore);
        }

        [Fact]
        public void TestValueType()
        {
            //Given
            int a = 6;
            int b = a;
            b++;
            //When
            
            //Then
            Assert.Equal(5,a);
            Assert.Equal(6,b);
        }

        [Fact]
        public void TestData()
        {
            //Given
            DateTime d1 = new DateTime(2017,1,1);
            DateTime d2 = d1;
            d1.AddYears(1); //METODO IMMUTABILE!!!
            //When
            
            //Then
            Assert.Equal(2018,d1.Year);
            Assert.Equal(2017,d2.Year);
            
        }
    }
}