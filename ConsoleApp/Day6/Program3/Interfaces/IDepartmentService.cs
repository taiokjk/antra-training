using Day6.Program3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Program3.Interfaces
{
    internal interface IDepartmentService : ICRUDService<Department>
    {
        List<Course> GetCourses(int id);
    }
}
