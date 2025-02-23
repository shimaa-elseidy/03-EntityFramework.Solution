using DB_First.Data.Contexts;
using DB_First.Data.Model;
using Microsoft.EntityFrameworkCore;

using AppDbContext context = new AppDbContext();
// Category category = new Category() { CategoryName = "Hamada" , Description = "Hamadaa" };
// context.Add(category);
// context.SaveChanges();

//foreach (var item in context.Categories)
//{
//    Console.WriteLine( item.CategoryName);
//    Console.WriteLine();
//    foreach (var item1 in item.Products)
//    {
//        Console.WriteLine(item1.ProductName);
//    }
//}
//context.Categories.ToList().ForEach( C => Console.WriteLine(C.CategoryName));
// RUN SQL QUERY
// 1. Select Statements : FromSqlRaw() - FromSqlInterpolated()
// 2. DML Statements [ update - insert - delete ]: ExecuteSqlRaw() - ExecuteSqlInterpolated()
//var result = context.Categories.FromSqlRaw("Select * From Categories");
//var result = context.Products.FromSqlRaw("Select * From Products where UnitsInStock = 0");
int Price = 10;
//var result = context.Products.FromSqlRaw($"Select * From Products where UnitPrice > {Price}");
//var result = context.Products.FromSqlRaw("Select * From Products where UnitPrice > {0} ",Price);
//var result = context.Products.FromSqlInterpolated($"Select * From Products where UnitPrice > {Price}");
//foreach (var item in result)
//{
//    Console.WriteLine(item.ProductName);
//}
context.Database.ExecuteSqlRaw("Update Products Set UnitsInStock = 90 where ProductID = 1");