namespace Task_3
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        decimal baseSalary;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public Employee(string lastName, string firstName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public decimal CalculateSalary(string post, int experience)
        {
            
            switch (post.ToLower())
            {
                case "manager":
                    this.baseSalary = 3000;
                    break;
                case "developer":
                    baseSalary = 5000;
                    break;
                case "designer":
                    baseSalary = 2000;
                    break;
            }
            decimal experienceBonus = baseSalary * (experience * 0.05m);
            decimal totalSalary = baseSalary + experienceBonus;
            
            return totalSalary;
            
        }
        
        public decimal CalculateTax(decimal salary)
        {
            decimal tax = salary * 0.15m;
            return tax;
        }
    }
}