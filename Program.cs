using System;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee pay roll");
            EmployeeRapo rapo = new EmployeeRapo();
            EmployeeModel employee = new EmployeeModel();
            employee.EmployeeId = 1234;
            employee.EmployeeName = "Bhargavi";
            employee.Phone_Number = "1234568908";
            employee.Address = "Andhra pradesh";
            employee.Department = "Maths";

            rapo.AddEmployee(employee);
            rapo.GetAllEmployee();
        }
    }
}
