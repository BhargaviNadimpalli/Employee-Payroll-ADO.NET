using System;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee pay roll");
            EmployeeRapo rapo = new EmployeeRapo();
            SalaryUpdate updateModel = new SalaryUpdate()
            {
                SalaryId = 1,
                Month = "Jan",
                EmployeeSalary = 120,
                EmployeeId = 1
            };
            int EmpSalary = rapo.UpdateSalary(updateModel);
            
            Console.ReadLine();
        }
    }
}
