using demo.Contexts;
using demo.Models;

namespace demo
{
    internal class Program
    {
        static void Main()
        {
            #region Rev..
             using AppDbContext context = new AppDbContext();
            // CRUD
            //var Department = new List<Department>()
            //{
            //new Department { Name = "HR" },
            //new Department { Name = "PR" },
            //new Department { Name = "IT" },
            //new Department { Name = "Sales" }
            //};
            //var Employees = new List<Employee>()
            //{
            //    new Employee { Name = "Shimaa Abdelreheem", Address = "Cairo"    ,Age = 25 ,Salary = 30000 , DeptId=100},
            //    new Employee { Name = "Adel Omar"         , Address = "Alex"     ,Age = 26 ,Salary = 10000 , DeptId=100},
            //    new Employee { Name = "Eyad Elgty"        , Address = "Assut"    ,Age = 28 ,Salary = 40000 , DeptId = 300},
            //    new Employee { Name = "Montaser Elgyiui"  , Address = "Qtar"     ,Age = 35 ,Salary = 90000 , DeptId = 100},
            //    new Employee { Name = "malkk Elgyiui"     , Address = "Giza"     ,Age = 32 ,Salary = 60000 , DeptId = 200},
            //    new Employee { Name = "Nora Elgamal"      , Address = "Nasr City",Age = 45 ,Salary = 10000 , DeptId = 400},
            //};
            //context.Departments.AddRange(Department);
            //context.Employees.AddRange(Employees);
            //context.SaveChanges();

            var Result = context.Employees.FirstOrDefault(e => e.Id == 10);
            Console.WriteLine(Result.Name);
            #endregion
        }
    }
}
