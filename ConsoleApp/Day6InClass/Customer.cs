using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6InClass
{
    internal class Customer
    {
        public string CustomerName { get; set; }

        private int id;
        public int Id
        {
            get
            {
                return id;
            }
            private set // cannot set id outside of class
            {
                id = value;
            }
        }

        public string Email { get; set; }
        public string Phone { get; set; }

        public Customer(int id, string customerName, string email)
        {
            Id = id;
            CustomerName = customerName;
            Email = email;
        }

        public Customer(int id, string customerName, string email, string phone)
        {
            Id = id;
            CustomerName = customerName;
            Email = email;
            Phone = phone;
        }
    }
}
