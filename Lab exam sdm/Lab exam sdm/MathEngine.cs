using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_exam_sdm
{
    public class MathEngine
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            if (b == 0) {
                throw new ArgumentException("Divisor cannot be zero");
            }
            return a / b;
        }


    }
}
