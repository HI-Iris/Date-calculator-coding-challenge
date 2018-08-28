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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using System.IO;
using Microsoft.Win32;
using System.Globalization;

namespace DateDifference
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public static bool isValidDate(string Date)
        {
            bool isValid = Regex.IsMatch(Date, @"^(((0[1-9]|[12][0-9]|3[01])/((0[13578]|1[02]))|((0[1-9]|[12][0-9]|30)/(0[469]|11))|(0[1-9]|[1][0-9]|2[0-8])/(02))/([0-9]{3}[1-9]|[0-9]{2}[1-9][0-9]{1}|[0-9]{1}[1-9][0-9]{2}|[1-9][0-9]{3}))|(29/02/(([0-9]{2})(0[48]|[2468][048]|[13579][26])|((0[48]|[2468][048]|[3579][26])00)))$");
            return isValid;
        }

        private void FirstDateInput_GotFocus(object sender, RoutedEventArgs e)
        {
            FirstDateInput.Text = "";
        }

        private void SecondDateInput_GotFocus(object sender, RoutedEventArgs e)
        {
            SecondDateInput.Text = "";
        }

        private void CalculateInput_Click(object sender, RoutedEventArgs e)
        {
            var firstDate = isValidDate(FirstDateInput.Text);
            var secondDate = isValidDate(SecondDateInput.Text);

            if (firstDate && secondDate)
            {

                DateTime dat1 = DateTime.ParseExact(FirstDateInput.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime dat2 = DateTime.ParseExact(SecondDateInput.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                TimeSpan spanTime = (dat1 - dat2);
                int diffDays = spanTime.Days;
                if (diffDays > 0)
                {
                    DateDifference.Content = SecondDateInput.Text + ", " + FirstDateInput.Text + ", " + "Difference: " + diffDays;
                }
                else
                {
                    DateDifference.Content = FirstDateInput.Text + ", " + SecondDateInput.Text + ", " + "Difference: " + System.Math.Abs(diffDays);
                }

            }
            else if (FirstDateInput.Text == "" || SecondDateInput.Text == "")
            {
                DateDifference.Content = "Please enter the date. DD/MM/YYYY";
            }
            else
            {
                DateDifference.Content = "Please enter a valid date. DD/MM/YYYY";
            }

        }

        private void ReadFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "txt|*.txt";
            if (fd.ShowDialog() == true)
            {
                if (fd.FileName != "")
                {
                    FilePath.Text = fd.FileName;
                    FileStream fs = new FileStream(@fd.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader rd = new StreamReader(fs);
                    rd.BaseStream.Seek(0, SeekOrigin.Begin);
                    FirstDateFile.Text = "";
                    SecondDateFile.Text = "";
                    string s;
                    var lines = new List<string>();
                    while ((s = rd.ReadLine()) != null)
                    {
                        lines.Add(s);
                    }
                    rd.Close();
                    fs.Close();
                    if (lines.Count > 1)
                    {
                        var firstDate = isValidDate(lines[0]);
                        var secondDate = isValidDate(lines[1]);
                        if (firstDate && secondDate)
                        {
                            FirstDateFile.Text = lines[0];
                            SecondDateFile.Text = lines[1];
                            CalculateFile.IsEnabled = true;
                        }
                        else
                        {
                            DateDifference.Content = "Please check the format of date file. DD/MM/YYYY";
                        }
                    }
                    if (lines.Count <= 1)
                    {
                        string[] tem = lines[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        var firstDate = isValidDate(tem[0]);
                        var secondDate = isValidDate(tem[1]);
                        if (firstDate && secondDate)
                        {
                            FirstDateFile.Text = tem[0];
                            SecondDateFile.Text = tem[1];
                            CalculateFile.IsEnabled = true;
                        }
                        else
                        {
                            DateDifference.Content = "Please check the format of date file. DD/MM/YYYY";
                        }
                    }

                }
            }

        }

        private void CalculateFile_Click(object sender, RoutedEventArgs e)
        {


            DateTime dat1 = DateTime.ParseExact(FirstDateFile.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime dat2 = DateTime.ParseExact(SecondDateFile.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            TimeSpan spanTime = (dat1 - dat2);
            int diffDays = spanTime.Days;
            if (diffDays > 0)
            {
                DateDifference.Content = SecondDateFile.Text + ", " + FirstDateFile.Text + ", " + "Difference: " + diffDays;
            }
            else
            {
                DateDifference.Content = FirstDateFile.Text + ", " + SecondDateFile.Text + ", " + "Difference: " + System.Math.Abs(diffDays);
            }
            CalculateFile.IsEnabled = false;
        }

        private void InputTabs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FirstDateInput.Text = "DD/MM/YYYY";
            SecondDateInput.Text = "DD/MM/YYYY";
            DateDifference.Content = "Enter the date or upload files to compare difference";
            FilePath.Text = "";
            FirstDateFile.Text = "DD/MM/YYYY";
             SecondDateFile.Text = "DD/MM/YYYY";
        }
    }
}

