using EntityFrameworkExample.Models;
using EntityFrameworkExample.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample.BLL
{
    public class ProductManager
    {
        ProductRepositry _productRepositry = new ProductRepositry();

        public bool Add(Product product)
        {
            return _productRepositry.Add(product);

        }

        public List<Product> GetAll()
        {
            return _productRepositry.GetAll();
        }

        public List<Product> GetByName(string name)
        {
            return _productRepositry.GetByName(name);
        }


    }
}
