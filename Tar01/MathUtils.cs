using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Tar01
{
    public class MathUtils
    {
        public bool IsEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            return false;
        }


        public bool IsPrime(int a)
            {
            int index;
            bool result = true;
            if (a>1)
                {
                   for (index = 2; index <= (a - 1); index++) {
                        if (a % index == 0)
                        {
                            result = false;
                            break;
                        }
                   }
                }
            else
            {
                result = false;
            } 
            return result;
            }
        public double pow(double x, double y)
        {
            return Math.Pow(x, y);
        }
    }
}
