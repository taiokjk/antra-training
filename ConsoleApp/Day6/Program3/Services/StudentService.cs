using Day6.Program3.Interfaces;
using Day6.Program3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6.Program3.Services
{
    internal class StudentService : PersonService<Student>, IStudentService
    {
        public decimal CalculateGPA(int id)
        {
            Student student = GetById(id);
            if (student == null)
                return 0;

            decimal gpa = 0;
            int total = 0;
            foreach (KeyValuePair<Course, string> course in student.Courses)
            {
                switch (course.Value)
                {
                    case "A+":
                        gpa += 4.0m;
                        total++;
                        break;
                    case "A-":
                        gpa += 4.0m;
                        total++;
                        break;
                    case "A":
                        gpa += 3.7m;
                        total++;
                        break;
                    case "B+":
                        gpa += 3.3m;
                        total++;
                        break;
                    case "B":
                        gpa += 3.0m;
                        total++;
                        break;
                    case "B-":
                        gpa += 2.7m;
                        total++;
                        break;
                    case "C+":
                        gpa += 2.3m;
                        total++;
                        break;
                    case "C":
                        gpa += 2.0m;
                        total++;
                        break;
                    case "C-":
                        gpa += 1.7m;
                        total++;
                        break;
                    case "D":
                        gpa += 1.0m;
                        total++;
                        break;
                    case "WIP":
                        break;
                    default:
                        total++;
                        break;
                }
            }

            return gpa / total;
        }
    }
}
