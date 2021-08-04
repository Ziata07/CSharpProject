using System.Windows;

namespace New_WPF
{
    /// <summary>
    /// 3 steps:
    /// When user presses button, validate the entries (if any).
    /// If entries ares valid, return true then begin calculation
    /// Display calculation in result box
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Initializing variables
        uint secEntry;
         uint minEntry;
         uint hrsEntry;
         uint result;
        #endregion
        public MainWindow()
        {
            InitializeComponent();
        }
        public void DisplayResults()
        {
            if (!ValidateSecondsInput())
            {
                MessageBox.Show("Invalid Entry For: Seconds");
            }
            else
            {
                result += CalculateSeconds(secEntry);
            }
            if (!ValidateHoursInput())
            {
                MessageBox.Show("Invalid Entry For: Hours");
            }
            else
            {
                result += CalculateHours(hrsEntry);
            }
            if (!ValidateMinutesInput())
            {
                MessageBox.Show("Invalid Entry For: Minutes");
            }
            else
            {
                result += CalculateMinutes(minEntry);
            }
            resultLabel.Content = "Seconds: " + result;
        }

        public void Reset()
        {
            result = 0;
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            Reset();
            DisplayResults();           
        }
        #region Initialize Calculation Methods 
        public uint CalculateSeconds(uint x)
        {            
            return x;
        }
        public uint CalculateHours(uint x)
        {            
           return x * 3600;
        }
        public uint CalculateMinutes(uint x)
        {
            if (x < 0)
            {
                x = 0; //safeguard if user puts in negative num
            }
            else
            {
                x = x * 60;
            }
            return x;
        }
        #endregion

        #region Initialize Validation Methods 
        public bool ValidateSecondsInput()
        {//line 92 - neccessary OR statement?
            string secondsInput = secTextBox.Text;
            uint x;

            if (!uint.TryParse(secondsInput, out x) || secondsInput == null)
            {
                return false;
            }
            else
            {
                secEntry = x;
                return true;
            }
        }
        public bool ValidateHoursInput()
        {
            {
                string hoursInput = hoursTextBox.Text;
                uint x;

                if (!uint.TryParse(hoursInput, out x))
                {
                    return false;
                }
                else
                {
                    hrsEntry = x;
                    return true;
                }
            }
        }
        public bool ValidateMinutesInput()
        {
            {
                string minInput = minTextBox.Text;
                uint x;

                if (!uint.TryParse(minInput, out x))
                {
                    return false;
                }
                else
                {
                    minEntry = x;
                    return true;
                }
            }
        }
        #endregion       
    }
}
