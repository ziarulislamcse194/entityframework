using EntityFrameworkExample.DatabaseContext;
using EntityFrameworkExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product()
            {
                Name = "B",
                Price = 1500,
                ProductType = "Electronics",
            };

            ProjectDbContext db = new ProjectDbContext();
            db.Products.Add(product);

            int rowAffected = db.SaveChanges();
            if (rowAffected > 0)
            {
                Console.WriteLine("Successfull");
            }

            Console.ReadKey();
        }
    }
}
