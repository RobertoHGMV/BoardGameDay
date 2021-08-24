using BoardGameDay.Common.Validations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGameDay.Test.Models
{
    [TestFixture]
    public class ValidationTest
    {
        private Validation _validation;

        [SetUp]
        public void Setup()
        {
            _validation = new Validation();
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void DadoValorInvalidoDeveAdicionarValidacao(string value)
        {
            var sut = _validation.IsNullOrEmpty(value, "", "");

            var result = sut.HasNotifications;

            Assert.IsTrue(result);
        }

        [Test]
        [TestCase("teste")]
        public void DadoValorValidoNaoDeveAdicionarValidacao(string value)
        {
            var sut = _validation.IsNullOrEmpty(value, "", "");

            var result = sut.HasNotifications;

            Assert.IsFalse(result);
        }

        [Test]
        [TestCase("", 2)]
        [TestCase("teste", 6)]
        public void DadoTextoMenorQueTamanhoDeveAdicionarValidacao(string val, int min)
        {
            var sut = _validation.HasMinLen(val, min, "", "");

            var result = sut.HasNotifications;

            Assert.IsTrue(result);
        }

        [Test]
        [TestCase("teste", 2)]
        [TestCase("teste", 5)]
        public void DadoTextoMaiorOuIgualQueTamanhoDeveAdicionarValidacao(string val, int min)
        {
            var sut = _validation.HasMinLen(val, min, "", "");

            var result = sut.HasNotifications;

            Assert.IsFalse(result);
        }
    }
}
