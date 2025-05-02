namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double n1 = 3.20;
            double n2 = 4.50;

            Console.WriteLine(Soma(n1, n2));

        }

        static double Soma(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
