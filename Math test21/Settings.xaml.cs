using System;
using System.Windows;

namespace Math_test21
{
    /// <summary>
    /// Interaction logic for Settings.xaml
    /// </summary>
    /// 



    public partial class Settings : Window
    {
        
        public Settings()
        {
            MyTime time = new MyTime();
            InitializeComponent();
            TimeTo.Text = 30.ToString();
            time.SetTime(TimeTo.Text);


        }


    }
}
