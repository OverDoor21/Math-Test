using System;
using System.Collections.Generic;
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

        RandomItem randomItem = new RandomItem();
        MathOperations operations = new MathOperations();
        MyTime myTime = new MyTime();
        DispatcherTimer timer = new DispatcherTimer();
        private TimeSpan timeRemaning;
        TimeSpan interval = new TimeSpan(0, 0, 1);
        



        List<string> numbers1 = new List<string> { "Firstname", "Firstname2", "Firstname3", "Firstname4" };
        List<string> numbers2 = new List<string> { "Secondnum", "Secondnum2", "Secondnum3", "Secondnum4" };
        /*        List<string> mathoperation = new List<string> { "Mathoper", "Mathoper2", "Mathoper3", "Mathoper4" };
        */
        List<TextBlock> textBlocks = new List<TextBlock>()
        {
           new TextBlock { Text = "Text"  },
           new TextBlock { Text = "Text"  }

        };

        

       /* List<TextBox> mathoperation = new List<TextBox>(Mathoper);*/

        private void AddTextToList_Click()
        {
            string text;
            /*     foreach(string i in mathoperation)
                 {

                 }*/
        }



        public MainWindow()
        {

            InitializeComponent();
            NewGameButton.IsEnabled = false;
            CheckResultButton.IsEnabled = false;
            foreach(TextBlock textBlock in textBlocks)
            {
                Grid grid = new Grid();
                grid.Children.Add(textBlock);
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
            /*timeRemaning = timeRemaning.Subtract(TimeSpan.FromSeconds(1));*/
            timeRemaning -= interval;
            await UpdateTimeLabel();

            if (timeRemaning.TotalSeconds <= 0)
            {
                timer.Stop();

                MessageBox.Show("Your time is over!");
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


        private void StartQuest(object sender, RoutedEventArgs e)
        {

            GiveMathOperation();
            GivevaluetoButtons();
            if (int.TryParse(baba.Text, out int userTime))
            {
                timeRemaning = TimeSpan.FromSeconds(userTime);
                UpdateTimeLabel();
                StartTimer();

            }

            StartQuestButton.IsEnabled = false;
            NewGameButton.IsEnabled = true;
            CheckResultButton.IsEnabled = true;
        }
        private void CheckResult(object sender, RoutedEventArgs e)
        {
            timer.Stop();

            Domath();
        }

        private void GivevaluetoButtons()
        {
            Firstname.Text = randomItem.RandomNumbers().ToString();
            Firstname2.Text = randomItem.RandomNumbers().ToString();
            Firstname3.Text = randomItem.RandomNumbers().ToString();
            Firstname4.Text = randomItem.RandomNumbers().ToString();

            Secondnum.Text = randomItem.RandomNumbers().ToString();
            Secondnum2.Text = randomItem.RandomNumbers().ToString();
            Secondnum3.Text = randomItem.RandomNumbers().ToString();
            Secondnum4.Text = randomItem.RandomNumbers().ToString();

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


        private void NullResults()
        {
            Counter.NullCount();
            Resultbox1.Text = null;
            Resultbox2.Text = null;
            Resultbox3.Text = null;
            Resultbox4.Text = null;


        }

        private void NewGame(object sender, RoutedEventArgs e)
        {
            NullResults();
            GiveMathOperation();
            GivevaluetoButtons();

        }
    }
}
