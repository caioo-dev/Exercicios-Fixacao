namespace Tabuada
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Treinador de Tabuada ===");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        TreinarOperacao("+");
                        break;
                    case "2":
                        TreinarOperacao("-");
                        break;
                    case "3":
                        TreinarOperacao("*");
                        break;
                    case "4":
                        TreinarOperacao("/");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Pressione Enter para tentar novamente.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void TreinarOperacao(string operacao)
        {
            int acertos = 0;
            int total = 0;
            Random random = new Random();

            while (true)
            {
                int a = random.Next(1, 11);
                int b = random.Next(1, 21); // Para adição/subtração
                int c = random.Next(1, 11); // Para multiplicação/divisão
                int resultadoCorreto = 0;

                if (operacao == "/")
                {
                    resultadoCorreto = a;
                    a = a * c;
                }

                Console.Clear();
                Console.WriteLine("Digite 'sair' para encerrar o treino.");
                total++;

                switch (operacao)
                {
                    case "+": resultadoCorreto = a + b; Console.Write($"{a} + {b} = "); break;
                    case "-": resultadoCorreto = a - b; Console.Write($"{a} - {b} = "); break;
                    case "*": resultadoCorreto = a * c; Console.Write($"{a} x {c} = "); break;
                    case "/": Console.Write($"{a} ÷ {c} = "); break;
                }

                string respostaStr = Console.ReadLine();

                if (respostaStr?.Trim().ToLower() == "sair")
                    break;

                bool ok = int.TryParse(respostaStr, out int resposta);

                if (ok && resposta == resultadoCorreto)
                {
                    Console.WriteLine("Correto!");
                    acertos++;
                }
                else
                {
                    Console.WriteLine($"Errado! Resposta certa: {resultadoCorreto}");
                }

                // Aguarda 1 segundo antes da próxima pergunta (opcional)
                Thread.Sleep(1000); // usando System.Threading
            }

            Console.Clear();
            Console.WriteLine($"Você respondeu {total} questões.");
            Console.WriteLine($"Acertos: {acertos}");
            Console.WriteLine($"Aproveitamento: {(total > 0 ? (acertos * 100 / total) : 0)}%");
            Console.WriteLine("Pressione Enter para voltar ao menu...");
            Console.ReadLine();
        }
    }
}
