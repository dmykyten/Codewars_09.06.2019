using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars
{
    class SeriesSum
    {
        public static string seriesSum(int n)
        {
            if(n == 0)
            {
                return "0.00";
            }
            double sum = 1;
            for(int i = 1;i <= n; i++)
            {
                sum = 1 / (1 / (3 * i));
            }
            Math.Round(sum,2);
            return sum.ToString();
        }
    }
}
