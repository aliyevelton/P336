namespace Employee
{
    internal class Department
    {
        public string Name;
        public int EmployeeLimit;
        public Employee[] Employee = new Employee[0];

        public void AddEmployee(Employee employee)
        {
            if(Employee.Length <= EmployeeLimit) 
            {
                Array.Resize(ref Employee, Employee.Length);
                Employee[Employee.Length] = employee;
            }
        }

        public Employee[] GetAllEmployees()
        { return Employee; }
    }
}
