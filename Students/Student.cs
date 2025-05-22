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

        public void AddGrade(double grade)
        {
            Grades.Add(grade);
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
    }
}
