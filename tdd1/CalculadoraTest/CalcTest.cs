using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculadoraTDD;

namespace CalculadoraTest
{
    [TestClass]
    public class CalcTest
    {
        [TestMethod]
        public void SumarDosNumeros_Test()
        {
            //AAA
            //1A Arrange
            ICalculadora calc = new Calculadora();
            //2A Act()
            var result = calc.Suma(2, 3);
            //3A Assert()
            Assert.AreEqual(5, result);

        }
        [TestMethod]
        public void RestarDosNumeros_Test()
        {
            //AAA
            //1A Arrange
            ICalculadora calc = new Calculadora();
            //2A Act()
            var result = calc.Resta(4, 2);
            //3A Assert()
            Assert.AreEqual(2, result);

        }
        [TestMethod]
        public void DividirDosNumeros_Test()
        {
            //AAA
            //1A Arrange
            ICalculadora calc = new Calculadora();
            //2A Act()
            var result = calc.Divicion(4, 2);
            //3A Assert()
            Assert.AreEqual(2, result);

        }
        [TestMethod]
        public void MultiplicarDosNumeros_Test()
        {
            //AAA
            //1A Arrange
            ICalculadora calc = new Calculadora();
            //2A Act()
            var result = calc.Multiplicacion(2, 3);
            //3A Assert()
            Assert.AreEqual(6, result);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SumarNumerosNegativos_Test()
        {
            //AAA
            //1A Arrange
            ICalculadora calc = new Calculadora();
            //2A Act()
            var result = calc.Suma(-2, 3);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void SumarNumeroMaximoValor_Test()
        {
            //AAA
            //1A Arrange
            ICalculadora calc = new Calculadora();
            //2A Act()
            var result = calc.Suma(int.MaxValue, 3);
        }
        [TestMethod]
        [ExpectedException(typeof(NumeroProhibidoException))]
        public void NumeroProhibido_Test()
        {
            //AAA
            //1A Arrange
            ICalculadora calc = new Calculadora();
            //2A Act()
            var result = calc.Suma(666, 3);

        }

    }
}
