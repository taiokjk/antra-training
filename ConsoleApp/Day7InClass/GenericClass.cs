using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7InClass
{
    internal static class GenericClass<T> 
                                        //where T: class
    {
        //public static bool AreEqual(object a, object b)
        //{
        //    return a.Equals(b);
        //}

        public static bool AreEqualGeneric(T a, T b)
        {
            return a.Equals(b);
        }
    }
}
