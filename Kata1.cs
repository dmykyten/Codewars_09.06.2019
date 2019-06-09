using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars
{
    class Kata1
    {
        public static int[] Maps(int[] x)
        {
            return x.Select(xxx => xxx * 2).ToArray(); ;
        }
    }
}
