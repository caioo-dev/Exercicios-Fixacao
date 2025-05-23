namespace Students
{
    internal class Student
    {
        public string Name { get; private set; }
        public int RegistrationNumber { get; private set; }
        public List<double> Grades { get; private set; }

        public Student(string name, int registrationNumber)
        {
            Name = name;
            RegistrationNumber = registrationNumber;
            Grades = new List<double>();
        }

        public void AddGrades(params double[] grades)
        {
            Grades.AddRange(grades);
        }

        public double GetAverage()
        {
            if (Grades.Count == 0) return 0;

            double total = 0;
            foreach (var grade in Grades)
            {
                total += grade;
            }
            return total / Grades.Count;
        }

        public override string ToString()
        {
            return $"Nome: {Name}, Matricula: {RegistrationNumber}";
        }
   
    }
}
