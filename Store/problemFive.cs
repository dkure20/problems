using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    
    public enum Employees
    {
         Manager = 120,
         Clerk = 130,
         Director = 110
    }
    public class ccaountant
    {
        public bool askForBonus(Employees employees, int hours)
        {
            int hoursWorked = (int) employees;
            if (hoursWorked > hours) return true;
            return false;
        }
    }
}
