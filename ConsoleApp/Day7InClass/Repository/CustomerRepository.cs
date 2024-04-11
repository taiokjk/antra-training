using Day7InClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7InClass.Repository
{
    internal class CustomerRepository : IRepository<Customer>
    {
        private List<Customer> customers = new List<Customer> ();

        public int Delete(int Id)
        {
            Customer c = GetById(Id);

            if (c != null)
            {
                customers.Remove(c);

                return 1;
            }

            return 0;
        }

        public List<Customer> GetAll()
        {
            return customers;
        }

        public Customer GetById(int Id)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].Id == Id)
                    return customers[i];
            }
            return null;
        }

        public int Insert(Customer obj)
        {
            if (GetById(obj.Id) == null)
            {
                customers.Add(obj);
                return 1;
            }

            return 0;
        }

        public int Update(Customer obj)
        {
            Customer c = GetById(obj.Id);
            if (c != null)
            {
                c.Id = obj.Id;
                c.Name = obj.Name;
                c.Email = obj.Email;

                return 1;
            }
            return 0;
        }
    }
}
