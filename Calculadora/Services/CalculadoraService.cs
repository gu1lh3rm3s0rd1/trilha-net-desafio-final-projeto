namespace Calculadora.Services
{
    public class CalculadoraService
    {
        public double Adicionar(double a, double b) => a + b;
        public double Subtrair(double a, double b) => a - b;
        public double Multiplicar(double a, double b) => a * b;
        public double Dividir(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("O divisor não pode ser zero.");
            return a / b;
        }
    }
}
