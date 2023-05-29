using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class problemSeven
    {
       public static void Main()
        {
            Func<Func<int>[], decimal> method = (Func<int>[] a) =>
            {
                decimal sum = 0;
                foreach (var i in a)
                {
                    sum += i();
                }
                return sum / a.Length;
            };
            
        }
    }
}
