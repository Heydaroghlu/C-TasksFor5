using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Calculation
    {
        //Overloading (Artiq yuklenme
        public int Calculate()
        {
            return 0;
        }
        public int Calculate(int a)
        {
            return a * 2;
        }
        public int Calculate(int a,int b)
        {
            return a * 2;
        }
        public double Calculate(double a)
        {
            return a*2;
        }
    }
}
