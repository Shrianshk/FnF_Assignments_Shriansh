create table Employee (
Emp_Id int primary key,
EmpName varchar(50),
Salary int,
Manager_Id int
);


insert into Employee (Emp_Id, EmpName, Salary, Manager_Id) values
(1, 'Rohit', 20000, 3),
(2, 'Sangeeta', 12000, 5),
(3, 'Sanjay', 10000, 5),
(4, 'Arun', 25000, 3),
(5, 'Zaheer', 30000, NULL);

select e.EmpName as emp_Name, M.EmpName as mgr_name
from Employee e
left join Employee m on e.Manager_Id = m.Emp_Id
order by e.EmpName;

