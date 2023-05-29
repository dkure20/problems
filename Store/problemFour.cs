using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public static class problemFour
    {
        static void Print(string line, int color)
        {

            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(line);
        }
        public static void Main2()
        {
             string input = Console.ReadLine();
             string color = Console.ReadLine();
            int colorId = Convert.ToInt32(color);
            Print(input, colorId);
        }
    }
}
