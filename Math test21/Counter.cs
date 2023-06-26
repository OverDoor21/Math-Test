using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_test21
{
    public class Counter
    {
        private static int count = 0;

        public static void Increment()
        {
            count++;
        }

        public static int GetCount()
        {
            return count;
        }

        public static int NullCount()
        {
            return count = 0;
        }

    }
}
