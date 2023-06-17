using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

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
            int RandomKey = randomint.Next(1,4);
            return mathkeys[RandomKey];
        }

        public int RandomNumbers()
        {
           return Randomnumber = randomint.Next(1, 100);
        }
    }
}
