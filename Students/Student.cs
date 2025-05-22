namespace Students
{
    internal class Student
    {
        public string Name { get; private set; }
        public int RegistrationNumber { get; private set; }
        public double[] Grades { get; private set; }

        public Student(string name, int registrationNumber)
        {
            Name = name;
            RegistrationNumber = registrationNumber;
        }

        public Student(string name, int registrationNumber, double[] grades) : this(name, registrationNumber)
        {
            Grades = grades;
        }

        public void AddGrades(double[] grades)
        {
            Grades = grades;
        }

        public static void AverageGrades(double[] grades)
        {
            double total = 0;

            for(int i = 0; i < grades.Length; i++)
            {
                total += grades[i];
            }

            Console.WriteLine(total / grades.Length);
        }
    }
}
