using Xunit;
using Calculadora.Services;
using System;

namespace Calculadora.Tests.Services
{
    public class CalculadoraServiceTests
    {
        private readonly CalculadoraService _calculadoraService;

        public CalculadoraServiceTests()
        {
            _calculadoraService = new CalculadoraService();
        }

        [Fact]
        public void Adicionar_DeveRetornarResultadoCorreto()
        {
            var resultado = _calculadoraService.Adicionar(5, 3);
            Assert.Equal(8, resultado);
        }

        [Fact]
        public void Subtrair_DeveRetornarResultadoCorreto()
        {
            var resultado = _calculadoraService.Subtrair(5, 3);
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Multiplicar_DeveRetornarResultadoCorreto()
        {
            var resultado = _calculadoraService.Multiplicar(5, 3);
            Assert.Equal(15, resultado);
        }

        [Fact]
        public void Dividir_DeveRetornarResultadoCorreto()
        {
            var resultado = _calculadoraService.Dividir(6, 3);
            Assert.Equal(2, resultado);
        }

        [Fact]
        public void Dividir_DeveLancarExcecaoQuandoDivisorForZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculadoraService.Dividir(6, 0));
        }
    }
}
