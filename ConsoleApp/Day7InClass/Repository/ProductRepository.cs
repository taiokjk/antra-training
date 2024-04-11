using Day7InClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7InClass.Repository
{
    internal class ProductRepository : IRepository<Product>
    {
        private List<Product> products = new List<Product>();

        public int Delete(int Id)
        {
            Product p = GetById(Id);

            if (p != null)
            {
                products.Remove(p);

                return 1;
            }
            return 0;
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product GetById(int Id)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].ProductID == Id)
                    return products[i];
            }

            return null;
        }

        public int Insert(Product obj)
        {
            Product p = GetById(obj.ProductID);
            if (p == null)
            {
                products.Add(obj);

                return 1;
            }
            return 0;
        }

        public int Update(Product obj)
        {
            Product p = GetById(obj.ProductID);
            if (p != null)
            {
                p.ProductName = obj.ProductName;
                p.Price = obj.Price;

                return 1;
            }

            return 0;
        }
    }
}
