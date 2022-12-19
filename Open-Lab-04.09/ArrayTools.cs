using System;
using System.Linq;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            string[] result = strings.Distinct().ToArray();
         return result ;
        }
    }
}
