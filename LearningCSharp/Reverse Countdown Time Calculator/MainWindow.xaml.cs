using System.Windows;

namespace Reverse_Countdown_Time_Calculator
{
    /// <summary>
    /// Calculator for converting seconds into Hours, Mins, & Secs
    /// User enters input for seconds
    /// Functions Validate then Calculate input if applicable
    /// </summary>
    public partial class MainWindow : Window
    {
        uint secondsEntry;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            DisplayResults();
        }
        public bool ValidateSeconds()
        {
            string secondsInput = secondsInputBox.Text;
            uint x;

            if (!uint.TryParse(secondsInput, out x))
            {
                return false;
            }
            else
            {
                secondsEntry = x;
                return true;
            }
        }

        #region Initialize Calculations Methods
        public uint CalculateHours(uint x)
        {
            return x / 3600;
        }
        public uint CalculateSecondsFromHours(uint x)
        {
            return x - (CalculateHours(x) * 3600);
        }
        public uint CalculateMinutes(uint x)
        {
           return CalculateSecondsFromHours(x) / 60;
        }
        public uint CalculateSecondsFromMinutes(uint x)
        {
            return  CalculateSecondsFromHours(x) - (CalculateMinutes(x) * 60);
        }
        #endregion
        public void DisplayResults()
        {
            if (!ValidateSeconds())
            {
                MessageBox.Show("Invalid Entry For: Seconds");
            }
            else
            {
                resultSec.Content = CalculateSecondsFromMinutes(secondsEntry);
                resultHrs.Content = CalculateHours(secondsEntry);
                resultMin.Content = CalculateMinutes(secondsEntry);
            }
        }
    }
}