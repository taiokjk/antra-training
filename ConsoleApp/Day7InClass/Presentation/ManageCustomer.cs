using Day7InClass.Model;
using Day7InClass.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day7InClass.Presentation
{
    internal class ManageCustomer
    {
        private CustomerRepository _customerRepository = new CustomerRepository();

        private void AddCustomer()
        {
            Customer c = new Customer();
            Console.Write("Enter Id: ");
            c.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            c.Name = Console.ReadLine();
            Console.Write("Enter Email: ");
            c.Email = Console.ReadLine();

            if (_customerRepository.Insert(c) == 1)
                Console.WriteLine("Customer has been added");
            else
                Console.WriteLine("Error occured");
        }

        private void PrintAllCustomers()
        {
            List<Customer> customers = _customerRepository.GetAll();

            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine(customers[i].ToString());                
            }
        }

        private void DeleteCustomer()
        {
            Console.Write("Enter ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (_customerRepository.Delete(id) == 1)
                Console.WriteLine("Customer has been removed");
            else
                Console.WriteLine("Error occured");
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Press 1 to Add");
            Console.WriteLine("Press 2 to Print All");
            Console.WriteLine("Press 3 to Delete");
            Console.WriteLine("Press 9 to exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            while (choice != 9)
            {
                switch (choice)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        PrintAllCustomers();
                        break;
                    case 3:
                        DeleteCustomer();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                Console.Write("Enter your option: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
