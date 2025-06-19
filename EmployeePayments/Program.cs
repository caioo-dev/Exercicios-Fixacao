using EmployeePayments.Entities;

namespace EmployeePayments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int N = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourceQuestion = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (outsourceQuestion == 'y' || outsourceQuestion == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());

                    Employee outsourcedEmployee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    employees.Add(outsourcedEmployee);
                    continue;
                }

                Employee employee = new Employee(name, hours, valuePerHour);
                employees.Add(employee);
            }

            Console.WriteLine("PAYMENTS: ");
            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }
        }
    }
}
