using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace Math_test21
{
     class MyTime
    {
        private TimeSpan time { get; set; }

        public TimeSpan Time
        {
            get { return time; }
            set
            {
                time = value;
                
            }
        }

        

        

        /*public TimeSpan SetTime(int TimeTo)
        {
            return this.time = TimeSpan.FromSeconds(TimeTo);
            
        }

        public string GetTime()
        {
            return time.ToString() ;
        }*/
    }
}
