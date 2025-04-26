namespace SimuladorCarro
{

    public enum Motor
    {
        ASPIRADO,
        TURBO
    }

    public class Carro
    {
        public string Marca { get; }
        public string Modelo { get; }
        public int Ano { get; }
        public int VelocidadeAtual { get; private set; }
        public Motor Motor { get; set; }

        public Carro(string marca, string modelo, int ano, Motor motor) 
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Motor = motor;
        }

        public void Acelerar(int velocidade)
        {
            int bonus = Motor switch
            {
                Motor.ASPIRADO => 5,
                Motor.TURBO => 10,
                _ => 0
            };

            VelocidadeAtual += velocidade + bonus;
        }
        public void Frear(int velocidade) 
        {
            VelocidadeAtual = Math.Max(0, VelocidadeAtual - velocidade);
        }

        public void Parar()
        {
            VelocidadeAtual = 0;
        }

        public override string ToString()
        {
            return $"Marca: {Marca}{Environment.NewLine}" +
                   $"Modelo: {Modelo}{Environment.NewLine}" +
                   $"Ano: {Ano}{Environment.NewLine}" +
                   $"Motor: {Motor}{Environment.NewLine}" +
                   $"Velocidade: {VelocidadeAtual} km/h";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = CriarCarro("Toyota", "Corolla", 2020, Motor.ASPIRADO);
            Carro carro2 = CriarCarro("Volkswagen", "Jetta", 2022, Motor.TURBO);

            MostrarCarros(carro1, carro2);
            TestarCarro(carro1, carro2);
        }

        static Carro CriarCarro(string marca, string modelo, int ano, Motor motor)
        {
            return new Carro(marca, modelo, ano, motor);
        }

        static void MostrarCarros(Carro carro1, Carro carro2)
        {
            Console.WriteLine("Carros criados:");
            Console.WriteLine(carro1);
            Console.WriteLine(carro2);
        }

        static void TestarCarro(Carro carro1, Carro carro2)
        {
            Console.WriteLine("\nAcelerando carro aspirado...");
            carro1.Acelerar(20);
            Console.WriteLine($"Velocidade atual: {carro1.VelocidadeAtual} km/h");

            Console.WriteLine("\nAcelerando carro turbo...");
            carro2.Acelerar(20);
            Console.WriteLine($"Velocidade atual: {carro2.VelocidadeAtual} km/h");

            carro2.Frear(50);
            Console.WriteLine($"Velocidade após frear: {carro2.VelocidadeAtual} km/h");

            Console.WriteLine("\nAcelerando carro turbo novamente...");
            carro2.Acelerar(100);
            Console.WriteLine($"Velocidade atual: {carro2.VelocidadeAtual} km/h");

            carro2.Parar();
            Console.WriteLine($"\nVelocidade após parar: {carro2.VelocidadeAtual} km/h");
        }

    }
}
