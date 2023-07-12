using System;
using System.Collections.Generic;

namespace Math_test21
{
    class RandomItem
    {
        Random randomint = new Random();

        //be carefull changed from public to private
        private int Randomnumber;


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

        public int RandomNumbersForSubtraction()
        {
            int value = randomint.Next(20, 100);
            if (value % 2 == 0)
            {
                return value;
            }
            else
            {
                value--;
                return RandomNumbersForSubtraction();
            }

        }
        public int RandomNumberSecondnumberSub()
        {
            int value = randomint.Next(1,10);
            if (value % 2 == 0)
            {
                return value;
            }
            else
            {
                value--;
                return RandomNumberSecondnumberSub();
            }
        }
    }
}
