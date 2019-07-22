using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkExample.Models;

namespace EntityFrameworkExample.DatabaseContext
{
    public class ProjectDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
