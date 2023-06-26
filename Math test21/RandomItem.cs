using System;
using System.Collections.Generic;

namespace Math_test21
{
    class RandomItem
    {
        Random randomint = new Random();
        //be carefull changed from public to private
        private int Randomnumber;
        private int mathkey;



        Dictionary<int, string> mathkeys = new Dictionary<int, string>()
        {
            {1,"+"},
            {2,"-"},
            {3,"/"},
            {4,"*"}
        };

        public string MathOperationRandom()
        {
            int RandomKey = randomint.Next(1, 5);
            return mathkeys[RandomKey];
        }

        public int RandomNumbers()
        {
            return Randomnumber = randomint.Next(1, 100);
        }
    }
}
