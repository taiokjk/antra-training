using Day6.Program3.Interfaces;
using Day6.Program3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Program3.Services
{
    internal class DepartmentService : CRUDService<Department>, IDepartmentService
    {
        private ICourseService _courseService;
        public List<Course> GetCourses(int id)
        {
            List<Course> courses = _courseService.GetAll();

            for (int i = 0; i < courses.Count; i++)
            {
                if (courses[i].Department.Id != id)
                {
                    courses.RemoveAt(i);
                }
            }

            return courses;
        }
    }
}
