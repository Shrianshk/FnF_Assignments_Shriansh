using System;
using System.Collections.Generic;

namespace SampleDotNetCore.Data;

public partial class Employee
{
    public int EmpId { get; set; }

    public string? EmpName { get; set; }

    public string? EmpAddress { get; set; }

    public decimal? EmpSalary { get; set; }

    public int? DeptId { get; set; }

    public virtual DeptTable? Dept { get; set; }
}
