using InheritanceExample.Contexts;
using InheritanceExample.Models;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main()
        {
            // 3 Ways To Generate Schema 
            // 1. TPC :: Table Per Class
            // 2. TPH :: Table Per Hierarchy
            // 3. TPCC:: Table Per Concrete Class
            using AppDbContext Context = new AppDbContext();
            //FullTimeEmployee fullTimeEmployee01 = new FullTimeEmployee()
            //{
            //    Name = "shimaa",
            //    Address = "Cairo",
            //    Email = "Shimaa@gmail.com",
            //    Salary = 30000
            //};
            //FullTimeEmployee fullTimeEmployee02 = new FullTimeEmployee()
            //{
            //    Name = "Esraa",
            //    Address = "Alex",
            //    Email = "Esraa@gmail.com",
            //    Salary = 600000
            //};
            //FullTimeEmployee fullTimeEmployee03 = new FullTimeEmployee()
            //{
            //    Name = "Omar",
            //    Address = "Alex",
            //    Email = "Omar@gmail.com",
            //    Salary = 200000
            //};
            //PartTimeEmployee partTimeEmployee01 = new PartTimeEmployee()
            //{
            //    Name = "lamyaa",
            //    Address = "Cairo",
            //    Email = "lamyaa@gmail.com",
            //    NumberOfHours = 1,
            //    HourRate = 1000,
            //};
            //PartTimeEmployee partTimeEmployee02 = new PartTimeEmployee()
            //{
            //    Name = "Mona",
            //    Address = "Alex",
            //    Email = "mona@gmail.com",
            //    NumberOfHours = 2,
            //    HourRate = 2000,
            //};
            //PartTimeEmployee partTimeEmployee03 = new PartTimeEmployee()
            //{
            //    Name = "Maha",
            //    Address = "Alex",
            //    Email = "maha@gmail.com",
            //    NumberOfHours = 11,
            //    HourRate = 11000,
            //};
            //Context.Add(fullTimeEmployee01);
            //Context.Update(fullTimeEmployee02);
            //Context.Add(fullTimeEmployee03);
            //Context.parttimeEmployees.Add(partTimeEmployee01);
            //Context.parttimeEmployees.Add(partTimeEmployee02);
            //Context.parttimeEmployees.Add(partTimeEmployee03);
            //Context.SaveChanges();
            //var Result = Context.employees.OfType<FullTimeEmployee>();
            //var Result = Context.employees.OfType<PartTimeEmployee>();
            //foreach (var item in Context.fulltimeEmployees)
            //{
            //    Console.WriteLine(item.Name);
            //}
        } 
    }
}
