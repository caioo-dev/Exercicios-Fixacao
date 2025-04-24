namespace SimuladorCarro
{

    public enum Motor
    {
        ASPIRADO,
        TURBO
    }

    public class Carro
    {
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public int Ano { get; private set; }
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

            VelocidadeAtual += velocidade;

            if (Motor == Motor.ASPIRADO)
            {
                VelocidadeAtual += 5;
            }
            
            if (Motor == Motor.TURBO)
            {
                VelocidadeAtual += 10;
            }
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
            return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Motor: {Motor}, Velocidade: {VelocidadeAtual} km/h";
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro("Toyota", "Corolla", 2020, Motor.ASPIRADO);
            Carro carro2 = new Carro("Volkswagen", "Jetta", 2022, Motor.TURBO);
            Console.WriteLine("Carros criados:");
            Console.WriteLine(carro1);
            Console.WriteLine(carro2);

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
