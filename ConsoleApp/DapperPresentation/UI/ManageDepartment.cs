using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperCore.Entities;
using DappterInfrastructure.Repositories;

namespace DapperPresentation.UI
{
    internal class ManageDepartment
    {
        private DepartmentRepository _departmentRepository = new DepartmentRepository();

        private void AddDepartment()
        {
            Department department = new Department();
            Console.WriteLine("Enter ID: ");
            department.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Department Name: ");
            department.DepartmentName = Console.ReadLine();
            Console.WriteLine("Enter Location: ");
            department.Location = Console.ReadLine();
            _departmentRepository.Insert(department);
        }

        private void DeleteDepartment()
        {
            Console.WriteLine("Enter ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            _departmentRepository.DeleteById(id);
        }

        private void UpdateDepartment()
        {
            Department department = new Department();
            Console.WriteLine("Enter ID: ");
            department.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Department Name: ");
            department.DepartmentName = Console.ReadLine();
            Console.WriteLine("Enter Location: ");
            department.Location = Console.ReadLine();
            _departmentRepository.Update(department);
        }

        private void PrintAll()
        {
            IEnumerable<Department> departments = _departmentRepository.GetAll();

            foreach (var department in departments)
            {
                Console.WriteLine($"ID: {department.Id}, Name: {department.DepartmentName}, Location: {department.Location}");
            }
        }

        public void PrintById()
        {
            Console.WriteLine("Enter ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var department = _departmentRepository.GetById(id);
            Console.WriteLine($"ID: {department.Id}, Name: {department.DepartmentName}, Location: {department.Location}");
        }

        public void Run()
        {
            AddDepartment();
        }
    }
}
