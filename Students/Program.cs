using System.Globalization;

namespace Students
{
    public class Program
    {
        static void Main(string[] args)
        {

            School escola = new School();
            Student s1 = new Student("Caio", 1);
            Student s2 = new Student("Isabela", 2);

            s1.AddGrades(6.65, 3.34, 3.53);
            s2.AddGrades(10.0, 5.0, 3.0);



            Console.WriteLine($"Média do aluno: {s1.GetAverage()
                                                        .ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"Média do aluno: {s2.GetAverage()
                                                        .ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine();
            escola.AddStudent(s1);
            escola.AddStudent(s2);

            escola.ShowAllStudents();

            Console.WriteLine();

            var aluno = escola.GetStudentByRegistration(2);
            Console.WriteLine(aluno);

            escola.DeleteStudent(aluno);
            escola.ShowAllStudents();

            Console.WriteLine();
            Console.WriteLine();
            escola.AddStudent(s2);
            escola.nsei();
        }
    }
}
