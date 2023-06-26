using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_test21
{
     class MyTime
    {
        TimeSpan time { get; set; }

        public TimeSpan SetTime(string TimeTo)
        {
            return time = TimeSpan.Parse(TimeTo);
        }

        public string GetTime()
        {
            return time.ToString();
        }
    }
}
