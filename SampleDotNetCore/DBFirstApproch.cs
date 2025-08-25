using Microsoft.EntityFrameworkCore;
using SampleDotNetCore.Data;
using SampleDotNetCore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Scaffold - DBContext "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FnfTraining;Integrated Security=True;Encrypt=False;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer - OutputDir Data - Tables "Employee","DeptTable"

namespace SampleDotNetCore
{
    internal class DBFirstApproch
    {
        static void Main(string[] args)
        {
            RemoveEmployee();
        }
        public static void AddEmployee()
        {
            try
            {
                var context = new FnfTrainingContext();
                context.Employees.Add(new Employee
                {
                    DeptId = 2,
                    EmpName = "John Doe",
                    EmpAddress = "King Landing",
                    EmpSalary = 60000
                });
                context.SaveChanges();
                Console.WriteLine("Employee added Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public static void RemoveEmployee()
        {
            var context = new FnfTrainingContext();
            Console.WriteLine("Enter the id to remove");
            int id = int.Parse(Console.ReadLine());
            var employee = context.Employees.FirstOrDefault(e => e.EmpId==id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
                Console.WriteLine("Employee Removed Successfully");
            }
        }
        public static void GetEmployees()
        {
            var context = new FnfTrainingContext();
            var employees = context.Employees.Include(e => e.Dept).ToList();
            foreach (var emp in employees)
            {
                Console.WriteLine($"Id : {emp.EmpId}, Name : {emp.EmpName}, Address : {emp.EmpAddress}, Salary : {emp.EmpSalary}, Dept : {emp.Dept?.DeptName}");
            }
        }
        public static void UpdateEmployee()
        {
            var context = new FnfTrainingContext();
            int id = int.Parse(Console.ReadLine());
            var employee = context.Employees.FirstOrDefault(e => e.EmpId == id);
            if (employee != null)
            {
                employee.EmpSalary = 70000;
                context.SaveChanges();
                Console.WriteLine("Employee Updated Successfully");
            }
        }
    }
}
