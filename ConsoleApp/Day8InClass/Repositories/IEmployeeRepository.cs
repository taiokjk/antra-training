using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8InClass.Repositories
{
    internal interface IEmployeeRepository<T> where T: class
    {
        List<T> Search(Predicate<T> condition);
    }
}
