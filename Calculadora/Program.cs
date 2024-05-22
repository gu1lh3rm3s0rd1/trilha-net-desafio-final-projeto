// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using Calculadora.Services;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculadora = new CalculadoraService();

            Console.WriteLine("Adição: 5 + 3 = " + calculadora.Adicionar(5, 3));
            Console.WriteLine("Subtração: 5 - 3 = " + calculadora.Subtrair(5, 3));
            Console.WriteLine("Multiplicação: 5 * 3 = " + calculadora.Multiplicar(5, 3));
            Console.WriteLine("Divisão: 5 / 3 = " + calculadora.Dividir(5, 3));
        }
    }
}
