using DotNetCoreLib.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

//Scaffold-DBContext "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=fnfTraining;Integrated Security=True;Encrypt=False;Trust Server Certificate=True" Microsoft.EntityFrameworkCore.SqlServer - OutputDir Data - Tables "Employee" , "DeptTable"

namespace DotNetCoreLib.DTOs
{
    //Todo: Create Db First approach with the interface for Employees Object.

    public class EmployeeDTO
    {

        public int EmpId { get; set; }
        [Required(ErrorMessage = "Employee Name is required")]
        public string EmpName { get; set; }
        [Required(ErrorMessage = "Employee Address is required")]
        public string EmpAddress { get; set; }
        [Range(1000, 100000, ErrorMessage = "Salary must be between 1000 and 100000")] public int EmployeeId { get; set; }
        public double EmpSalary { get; set; }
        [Required(ErrorMessage = "Department Id is required")]
        public int DeptId { get; set; }
    }
    class DeptDTO
    {
        public int DeptId { get; set; }
        [Required(ErrorMessage = "Department Name is required")]
        public string DeptName { get; set; }

    }
    public interface IEmployee
    {
        List<EmployeeDTO> GetAllEmployees();
        EmployeeDTO GetEmployeeById(int id);
        void AddEmployee(EmployeeDTO employee);
        void UpdateEmployee(EmployeeDTO employee);
        void DeleteEmployee(int id);

    }
    public class EmployeeRepo : IEmployee
    {
        private FnftrainingContext _context;

        public EmployeeRepo()
        {
            _context = new FnftrainingContext();
        }
        public void AddEmployee(EmployeeDTO employee)
        {
            _context.Employees.Add(new Employee
            {
                EmpName = employee.EmpName,
                EmpAddress = employee.EmpAddress,
                EmpSalary = (decimal)employee.EmpSalary,
                DeptId = employee.DeptId

            });
            _context.SaveChanges();
        }
        public void DeleteEmployee(int id)
        {
          
            var emp = _context.Employees.Find(id);
            if (emp != null)
            {
                _context.Employees.Remove(emp);
                _context.SaveChanges();
            }
        }
        //public List<EmployeeDTO> GetAllEmployees()
        //{
        //   _context.Employees.ToList();
        //    return _context.Employees.Select(e => new EmployeeDTO
        //    {
        //        EmpId = e.EmpId,
        //        EmpName = e.EmpName,
        //        EmpAddress = e.EmpAddress,
        //        EmpSalary = (double)e.EmpSalary,
        //        DeptId = (int)e.DeptId
        //    }).ToList();
        //}
        public List<EmployeeDTO> GetAllEmployees()
        {
            return _context.Employees.Select(e => new EmployeeDTO
            {
                EmpId = e.EmpId,
                EmpName = e.EmpName,
                EmpAddress = e.EmpAddress,
                EmpSalary = e.EmpSalary.HasValue ? (double)e.EmpSalary.Value : 0.0,
                DeptId = e.DeptId.HasValue ? e.DeptId.Value : 0
            }).ToList();


        }
        public EmployeeDTO GetEmployeeById(int id)
        {
           
            var emp = _context.Employees.Find(id);
            if (emp != null)
            {
                return new EmployeeDTO
                {
                    EmpId = emp.EmpId,
                    EmpName = emp.EmpName,
                    EmpAddress = emp.EmpAddress,
                    EmpSalary = (double)emp.EmpSalary,
                    DeptId = (int)emp.DeptId
                };
            }
            return null;
        }
       
        public void UpdateEmployee(EmployeeDTO employee)
        {  
            var emp = _context.Employees.Find(employee.EmpId);
            if (emp != null)
            {
                emp.EmpName = employee.EmpName;
                emp.EmpAddress = employee.EmpAddress;
                emp.EmpSalary = (decimal)employee.EmpSalary;
                emp.DeptId = employee.DeptId;
                _context.SaveChanges();
            }
        }
    }
}
