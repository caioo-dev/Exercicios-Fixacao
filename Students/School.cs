namespace Students
{
    internal class School
    {

        private List<Student> students = new List<Student>();

        public void AddStudent(Student s)
        {
            bool exists = students.Any(aluno => aluno.RegistrationNumber == s.RegistrationNumber);

            if (exists)
            {
                Console.WriteLine($"Aluno '{s.Name}' já está cadastrado.");
                return;
            }

            students.Add(s);
            Console.WriteLine($"Aluno '{s.Name}' adicionado com sucesso.");
        }

        public void DeleteStudent(Student s)
        {
            bool exists = students.Any(aluno => aluno.RegistrationNumber == s.RegistrationNumber);

            if (!exists)
            {
                Console.WriteLine("Aluno não encontrado");
                return;
            }
            else
            {
                Console.WriteLine($"Aluno {s.Name} removido");
                students.Remove(s);
            }
        }

        public Student GetStudentByRegistration(int regNumber)
        {
            return students.FirstOrDefault(s => s.RegistrationNumber == regNumber);
        }

        public void ShowAllStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Nenhum aluno cadastrado.");
                return;
            }

            Console.WriteLine("Lista de Alunos:");
            foreach (var aluno in students)
            {
                Console.WriteLine(aluno);
            }
        }
        public void nsei()
        {
            foreach (var aluno in students)
            {
                Console.WriteLine(aluno);
                if (aluno.GetAverage() < 5.0)
                {
                    Console.WriteLine("Reprovado");
                }
                else
                {
                    Console.WriteLine("Aprovado");
                }
            }
        }

    }
}
