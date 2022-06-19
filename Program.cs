// See https://aka.ms/new-console-emplate for more information;
using System;
namespace EmployeePayroll
{
    class program
    {
        static void main(string[] args)
        {

            Console.WriteLine("Welcome to Employee Payroll!");

            employee repo = new employeeRepo();
            employee Model employee = new EmployeeModel();
            Employee.EmployeeName = "Raji";
            Employee.PhoneNumber = "9542654316";
            Employee.Address = "2-78";
            Employee.Departement = "HR";
            Employee.Gender = "F";
            Employee.BasicPay = 3455.00;
            Employee.Deduction = 1500.00;
            Employee.TaxablePay = 200.00;
            Employee.Tax = 100.00;
            Employee.NetPay = 22000.00;
            Employee.City = "Guntur";
            Employee.Country = India";
        

//repo.AddEmployee(employee);

            //repo.UpdateEmployee(employee);

            //repo.DeleteEmployee(employee);

repo.GetAllEmployee();
        }
    }
}


