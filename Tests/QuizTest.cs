using System;
<<<<<<< HEAD
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
=======
using Scacchi.Modello;
using Scacchi.Modello.Pezzi;
using Xunit;

namespace Scacchi.Tests
{
    public class QuizTest
    {
        
        [Fact]
        public void ComportamentoDiCasa()
        {
        //Given
        ICasa casa1 = new Casa(Colonna.A, Traversa.Prima);
        ICasa casa2 = casa1;
        casa1.PezzoPresente = new Pedone(Colore.Bianco);
        casa2.PezzoPresente = new Pedone(Colore.Nero);
        
        //Then
        Assert.Equal(Colore.Nero, casa1.PezzoPresente.Colore);
        Assert.Equal(Colore.Nero, casa2.PezzoPresente.Colore);

>>>>>>> upstream/master
        }

        [Fact]
        public void TestValueType()
        {
<<<<<<< HEAD
            //Given
            int a = 6;
            int b = a;
            b++;
            //When
            
            //Then
            Assert.Equal(5,a);
            Assert.Equal(6,b);
=======
        //Given
        int a = 5;
        int b = a;
        b++;
        
        //Then
        Assert.Equal(5, a);
        Assert.Equal(6, b);
>>>>>>> upstream/master
        }

        [Fact]
        public void TestData()
        {
<<<<<<< HEAD
            //Given
            DateTime d1 = new DateTime(2017,1,1);
            DateTime d2 = d1;
            d1.AddYears(1); //METODO IMMUTABILE!!!
            //When
            
            //Then
            Assert.Equal(2018,d1.Year);
            Assert.Equal(2017,d2.Year);
            
        }
=======
        //Given
        DateTime d1 = new DateTime(2017, 1, 1);
        DateTime d2 = d1;
        d1 = d1.AddYears(1);

        //When
        
        //Then
        Assert.Equal(2018, d1.Year);
        Assert.Equal(2017, d2.Year);
        }

>>>>>>> upstream/master
    }
}