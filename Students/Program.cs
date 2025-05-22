using System.Globalization;

namespace Students
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Caio", 1);

            s1.AddGrade(3.4);
            s1.AddGrade(7.7);
            s1.AddGrade(10.0);

            Console.WriteLine($"Média do aluno: {s1.GetAverage()
                                                        .ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
