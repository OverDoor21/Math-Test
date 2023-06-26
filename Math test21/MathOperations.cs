using System;

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

        public int Subtraction(int x, int y)
        {

            result = x - y;
            return result;
        }

        public int Division(int x, int y)
        {
            
            result = x / y;
            return result;
        }

        public int Multiplication(int x, int y)
        {
            result = x * y;
            return result;
        }

        public int WhichCalculation(int x, string parametr, int y)
        {
            if (parametr == "+")
                return Addition(x, y);
            if (parametr == "-")
                return Subtraction(x, y);
            if (parametr == "/")
                return Division(x, y);
            if (parametr == "*")
                return Multiplication(x, y);
            return default;
        }
    }
}
