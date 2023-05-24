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

namespace Math_test21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            MessageBox.Show(clickedButton.Content.ToString());
        }
    }
}
