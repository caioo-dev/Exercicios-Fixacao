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
                        Console.WriteLine($"Position {i},{j}");
                    }

                }
            }

        }
    }
}
