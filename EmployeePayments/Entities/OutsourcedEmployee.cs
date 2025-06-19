namespace EmployeePayments.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; private set; }

        public OutsourcedEmployee()
        {
            
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public sealed override double Payment()
        {   // 1.1 = 110%
            return base.Payment() + (AdditionalCharge * 1.1);
        }
    }
}
