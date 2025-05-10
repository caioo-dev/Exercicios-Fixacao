namespace RentingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Estudante[] estudantes = new Estudante[10];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rent #{i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                estudantes[room] = new Estudante(name, email);

                Console.WriteLine();
            }

            for (int i = 0; i < 10; i++)
            {
                if (estudantes[i] != null)
                {
                    Console.WriteLine($"{i}: {estudantes[i].Name}, {estudantes[i].Email}");
                }
            }

        }
    }

    class Estudante
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Estudante(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
