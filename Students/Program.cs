namespace Students
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Caio", 1, [2.23, 5.32, 34.3]);

            Student.AverageGrades(s1.Grades);

            s1.AddGrades([2.22]);
        }
    }
}
