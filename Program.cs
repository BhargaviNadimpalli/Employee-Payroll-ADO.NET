using System;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee pay roll");
            EmployeeRapo rapo = new EmployeeRapo();
           
            rapo.GetAllEmployee();
        }
    }
}
