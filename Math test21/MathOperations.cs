using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_test21
{
    class MathOperations : RandomItem
    {
        private int result;
        
        public int Addition(int x, int y)
        {
            
            result = x + y;
            return result;
        }

        public int Subtraction( int x, int y)
        {
            if (Dictionary<int, string>.Equals(2, "-"))
                result = x - y;
            return result;
        }

        public int Division( int x, int y)
        {
            if (Dictionary<int, string>.Equals(3, "/"))
                result = x / y;
            return result;
        }

        public int Multiplication( int x, int y)
        {
            if (Dictionary<int, string>.Equals(4, "*"))
                result = x * y;
            return result;
        }

        public void WhichCalculation(int x, string parametr,int y)
        {
            if (parametr == "+" )
                Addition(x,y);
            if (parametr == "-")
                Subtraction(x, y);
            if (parametr == "/")
                Division(x, y);
            if (parametr == "*")
                Multiplication(x, y);
        }
    }
}
