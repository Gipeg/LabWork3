using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program;
namespace LabWorkFunctions
{
    public static class Functions
    {
        public static double GetFactorial(double n)
        {
            if (n < 0)
            {
                return 0;
            }
            else 
            {
                return n * GetFactorial(n);                
            }
        }

        public static double GetPower(double x, int n)
        {
            throw new NotImplementedException();
        }
    }
}
