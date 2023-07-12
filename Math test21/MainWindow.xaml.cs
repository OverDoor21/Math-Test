using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;

namespace Math_test21
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        TextBlock Mathoper = new TextBlock()
        {
            Text = "?"
        };

        TextBlock Mathoper2 = new TextBlock()
        {

            Text = "?"
        };

        TextBlock Mathoper3 = new TextBlock()
        {

            Text = "?"
        };

        TextBlock Mathoper4 = new TextBlock()
        {

            Text = "?"
        };



        RandomItem randomItem = new RandomItem();
        MathOperations operations = new MathOperations();
        MyTime myTime = new MyTime();
        DispatcherTimer timer = new DispatcherTimer();
        private TimeSpan timeRemaning;
        TimeSpan interval = new TimeSpan(0, 0, 1);
        Grid grid = new Grid();



        List<string> numbers1 = new List<string> { "Firstname", "Firstname2", "Firstname3", "Firstname4" };
        List<string> numbers2 = new List<string> { "Secondnum", "Secondnum2", "Secondnum3", "Secondnum4" };


        public MainWindow()
        {

            InitializeComponent();

          
            CheckResultButton.IsEnabled = false;



            List<TextBlock> MathOpers = new List<TextBlock>
            {
                Mathoper,
                Mathoper2,
                Mathoper3,
                Mathoper4
            };

            foreach (TextBlock textBlocks in MathOpers)
            {

                Grid.SetColumn(textBlocks, 2);
                Grid.SetRow(Mathoper, 1);
                Grid.SetRow(Mathoper2, 2);
                Grid.SetRow(Mathoper3, 3);
                Grid.SetRow(Mathoper4, 4);




                Gridik.Children.Add(textBlocks);
            }


        }

        public void StartTimer()
        {
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        public async void Timer_Tick(object? sender, EventArgs e)
        {

            timeRemaning -= interval;
            await UpdateTimeLabel();

            if (timeRemaning.TotalSeconds <= 0)
            {
                timer.Stop();
                Domath();
                MessageBox.Show($"Your time is over!{Counter.GetCount()}","Time is over");
            }

        }

        private async Task UpdateTimeLabel()
        {
            TimeText.Text = timeRemaning.ToString(@"mm\:ss");
        }


        private void ButtonSettings_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();

        }
        //It seems like i have problem here
        public void ChangerBorderColor(Brush border, Color color)
        {
            SolidColorBrush brush = new SolidColorBrush(color);
            border = brush;
        }


        private async void StartQuest(object sender, RoutedEventArgs e)
        {
            CMBChangeYourTime.Visibility = Visibility.Collapsed;
            GiveMathOperation();
            GivevaluetoButtons();
            if (int.TryParse(GetComboTextValue(CMBChangeYourTime), out int userTime))
            {
                timeRemaning = TimeSpan.FromSeconds(userTime);
                await UpdateTimeLabel();
                StartTimer();

            }

            StartQuestButton.IsEnabled = false;
            
            CheckResultButton.IsEnabled = true;
        }
        private void CheckResult(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            Domath();
            var result = MessageBox.Show($"Your score are : {Counter.GetCount()} Well Done!", "Would you like to retry?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                string currentExecutablePath = Process.GetCurrentProcess().MainModule.FileName;
                Process.Start(currentExecutablePath);
                Application.Current.Shutdown();
            }
            else
            {
                this.Close();
            }
        }

        private void GivevaluetoButtons()
        {
            if (Mathoper.Text.Contains("/"))
            {
                Firstname.Text = randomItem.RandomNumbersForSubtraction().ToString();
                Secondnum.Text = randomItem.RandomNumberSecondnumberSub().ToString();
            }
            else
            {
                Firstname.Text = randomItem.RandomNumbers().ToString();
                Secondnum.Text = randomItem.RandomNumbers().ToString();
            }
            if (Mathoper2.Text.Contains("/"))
            {
                Firstname2.Text = randomItem.RandomNumbersForSubtraction().ToString();
                Secondnum2.Text = randomItem.RandomNumberSecondnumberSub().ToString();
            }
            else
            {
                Firstname2.Text = randomItem.RandomNumbers().ToString();
                Secondnum2.Text = randomItem.RandomNumbers().ToString();
            }
            if (Mathoper3.Text.Contains("/"))
            {
                Firstname3.Text = randomItem.RandomNumbersForSubtraction().ToString();
                Secondnum3.Text = randomItem.RandomNumberSecondnumberSub().ToString();
            }
            else
            {
                Firstname3.Text = randomItem.RandomNumbers().ToString();
                Secondnum3.Text = randomItem.RandomNumbers().ToString();
            }
            if (Mathoper4.Text.Contains("/"))
            {
                Firstname4.Text = randomItem.RandomNumbersForSubtraction().ToString();
                Secondnum4.Text = randomItem.RandomNumberSecondnumberSub().ToString();
            }
            else
            {
                Firstname4.Text = randomItem.RandomNumbers().ToString();
                Secondnum4.Text = randomItem.RandomNumbers().ToString();
            }



        }

        private void GiveMathOperation()
        {
            Mathoper.Text = randomItem.MathOperationRandom();
            Mathoper2.Text = randomItem.MathOperationRandom();
            Mathoper3.Text = randomItem.MathOperationRandom();
            Mathoper4.Text = randomItem.MathOperationRandom();
        }

        private void Domath()
        {



            int result = operations.WhichCalculation(Convert.ToInt32(Firstname.Text), Mathoper.Text, Convert.ToInt32(Secondnum.Text));
            int result2 = operations.WhichCalculation(Convert.ToInt32(Firstname2.Text), Mathoper2.Text, Convert.ToInt32(Secondnum2.Text));
            int result3 = operations.WhichCalculation(Convert.ToInt32(Firstname3.Text), Mathoper3.Text, Convert.ToInt32(Secondnum3.Text));
            int result4 = operations.WhichCalculation(Convert.ToInt32(Firstname4.Text), Mathoper4.Text, Convert.ToInt32(Secondnum4.Text));
            try
            {
                if (result == Convert.ToInt32(Resultbox1.Text))
                {
                    Counter.Increment();
                    ChangerBorderColor(Resultbox1.BorderBrush, Color.FromRgb(235, 64, 52));
                }
                if (result2 == Convert.ToInt32(Resultbox2.Text))
                {
                    Counter.Increment();
                    ChangerBorderColor(Resultbox1.BorderBrush, Color.FromRgb(235, 64, 52));
                }
                if (result3 == Convert.ToInt32(Resultbox3.Text))
                {
                    Counter.Increment();
                    ChangerBorderColor(Resultbox1.BorderBrush, Color.FromRgb(235, 64, 52));
                }
                if (result4 == Convert.ToInt32(Resultbox4.Text))
                {
                    Counter.Increment();
                    ChangerBorderColor(Resultbox1.BorderBrush, Color.FromRgb(235, 64, 52));
                }
                MessageBox.Show($"Your result is: {Counter.GetCount()}");
            }
            catch { }

        }

        private string GetComboTextValue(ComboBox comboBox)
        {
            if (comboBox.SelectedItem != null)
            {
                ComboBoxItem item = (ComboBoxItem)comboBox.SelectedItem;
                string result = item.Content.ToString();
                return result;  
            }

            else
            {
                 string UserInput = comboBox.Text;
                return UserInput;
            }
        }

    }
}
