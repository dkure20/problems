using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class problemSix
    {
        public static void Main()
        {
            Func<decimal, decimal, decimal> add = (a, b) => a + b;
            Func<decimal,decimal,decimal> Sub = (a, b) => a - b;
            Func<decimal,decimal,decimal> Mul = (a, b) => a * b;
            Func<decimal, decimal, decimal> Div = (a, b) =>
            {
                if (b == 0) throw new Exception("b is equal to 0");
                return a / b;
            };
        }
    }
}
