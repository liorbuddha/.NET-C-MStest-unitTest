using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tar01

{
    public class Calculator
    {
        public double Add (double x, double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Mul(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
           
             return x / y;
           
            
        }

        public double Add(double x, double y, bool a)
        {
            if (a== true)
            {
                return 100;
            }
            return x + y;
        }
    }
}
