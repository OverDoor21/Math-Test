using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Math_test21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RandomItem randomItem = new RandomItem();
        MathOperations operations = new MathOperations();
        List<string> numbers1 = new List<string> { "Firstname", "Firstname2", "Firstname3", "Firstname4" };
        List<string> numbers2 = new List<string> { "Secondnum", "Secondnum2", "Secondnum3", "Secondnum4" };
        List<string> mathoperation = new List<string> { "Mathoper", "Mathoper2", "Mathoper3", "Mathoper4" };
        

        public MainWindow()
        {
            InitializeComponent();  
            

          
     


            /*Допиши ебанную анимацию когда наводишься на кнопку и обратно*/

            /* DoubleAnimation buttonAnimation = new DoubleAnimation() ;
             RotateTransform rotateTransform1 = new RotateTransform() ;
             rotateTransform1.Angle = 180 ;
             rotateTransform1.BeginAnimation(rotateTransform1.Angle,TimeSpan.FromSeconds(3));
             *//*    buttonAnimation.From = ButtonSettings.ActualWidth;
                 buttonAnimation.To = 150;
                 buttonAnimation.AutoReverse = true ;
                 buttonAnimation.Duration = TimeSpan.FromSeconds(3);
                 ButtonSettings.BeginAnimation(Button.WidthProperty, buttonAnimation);*/




        }

        private void ButtonSettings_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
       

        private void StartQuest(object sender, RoutedEventArgs e)
        {
            GivevaluetoButtons();
            GiveMathOperation();
        }

        private void GivevaluetoButtons()
        {
            foreach (string number in numbers1)
            {
                Firstname.Text = randomItem.RandomNumbers().ToString();
                Firstname2.Text = randomItem.RandomNumbers().ToString();
                Firstname3.Text = randomItem.RandomNumbers().ToString();
                Firstname4.Text = randomItem.RandomNumbers().ToString();
            }
            foreach(string number in numbers2)
            {
                Secondnum.Text = randomItem.RandomNumbers().ToString();
                Secondnum2.Text = randomItem.RandomNumbers().ToString();
                Secondnum3.Text = randomItem.RandomNumbers().ToString();
                Secondnum4.Text = randomItem.RandomNumbers().ToString();
            }
        }

        private void GiveMathOperation()
        {
            foreach (string number in mathoperation)
            {
                Mathoper.Text = randomItem.MathOperationRandom();
                Mathoper2.Text = randomItem.MathOperationRandom();
                Mathoper3.Text = randomItem.MathOperationRandom();
                Mathoper4.Text = randomItem.MathOperationRandom();
            }
        }

        private void CheckResults()
        {
           
        }
    }
}
