namespace Calculadora
{

    class Calculadora
    {
        public static double Soma(double n1, double n2)
        {
            return n1 + n2;
        }
        public static double Subtracao(double n1, double n2)
        {
            return n1 - n2;
        }
        public static double Multiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }
        public static double Divisao(double n1, double n2)
        {
            return n1 / n2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora");
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o primeiro número:");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            double n2 = double.Parse(Console.ReadLine());
            double resultado = 0;
            switch (opcao)
            {
                case 1:
                    resultado = Calculadora.Soma(n1, n2);
                    break;
                case 2:
                    resultado = Calculadora.Subtracao(n1, n2);
                    break;
                case 3:
                    resultado = Calculadora.Multiplicacao(n1, n2);
                    break;
                case 4:
                    resultado = Calculadora.Divisao(n1, n2);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    return;
            }
            Console.WriteLine($"Resultado: {resultado}");

        }

    }
}
