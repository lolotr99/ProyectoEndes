using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProyectoFinal;


namespace ProyectoFinalTEST
{
    [TestFixture]
    class IBANTEST
    {
        [TestCase]
        public void DevolverErrorCuandoNoHayValor()
        {
            string valor = string.Empty;
            IBAN iban = new IBAN();

            bool resultado = iban.EsIBANvalido(valor);

            Assert.AreEqual(false, resultado);
        }

        [TestCase]
        public void DevuelveTrueCuandoEsValorCorrecto()
        {
            string valor = "ES6621000418401234567891";
            IBAN iban = new IBAN();

            bool resultado = iban.EsIBANvalido(valor);

            Assert.AreEqual(true, resultado);
        }



    }
}
