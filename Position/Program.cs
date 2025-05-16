namespace Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] values = Console.ReadLine().Split(' ');

            int M = int.Parse(values[0]);
            int N = int.Parse(values[1]);

            int[,] mat = new int[M, N];

            for(int i = 0; i < M; i++)
            {

                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {

                    mat[i, j] = int.Parse(valores[j]);

                }
            }

            int X = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {

                    if (mat[i, j] == X)
                    {
                        Console.WriteLine($"Position {i},{j}:");
                        if (j > 0) // checa se J (Coluna) é maior que 0, se for maior que 0 quer dizer que não está na primeira coluna e consequentemente tem número a esquerda
                        {
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }
                        if (j < N - 1) // checa se J é menor que N(tamanho total de colunas) - 1 (ultima coluna). se for menor que N-1 quer dizer que não está na ultima coluna e tem número a direita
                        {
                            Console.WriteLine($"Right: {mat[i, j + 1]}");
                        }
                        if (i > 0) // checa se I(linhas) é maior que 0, se for maior que 0 consequentemente não está na primeira linha e tem número acima
                        {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }
                        if (i < M - 1) // checa se I é menor que M(numero total de linhas) -1. se for menor quer dizer que tem número abaixo pois I vai ser igual a última linha de linhas
                        {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }
                    }

                }
            }

        }
    }
}
