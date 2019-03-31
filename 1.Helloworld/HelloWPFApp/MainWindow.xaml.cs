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

namespace HelloWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textBoxFirstName_LF(object sender, RoutedEventArgs e)
        {
            labelMsgName.Content = "Witaj " + textBoxFirstName.Text + " " + textBoxLastName.Text;
        }

        private void textBoxLastName_LF(object sender, RoutedEventArgs e)
        {
            labelMsgName.Content = "Witaj " + textBoxFirstName.Text + " " + textBoxLastName.Text;
        }

        private void textBoxAge_LF(object sender, RoutedEventArgs e)
        {
            int age = 0;
            try
            {
                Convert.ToInt32(textBoxAge.Text);
            }
            catch (FormatException)
            {
                //labelMsgAge.Content = "BLAD. Wpisz poprawny wiek!";
            }
            catch (OverflowException)
            {
                //labelMsgAge.Content = "BLAD. Za duzy wiek!";
            }
            if( age <= 67 && age > 0)
            {
                labelMsgAge.Content = string.Format(" do emerytury pozostalo Ci {0} lat", 67 - age);
            }
            else if (age > 67)
            {
                labelMsgAge.Content = " jestes emerytem";
            }
            else
            {
                labelMsgAge.Content = "Wystapil blad.";
            }

        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            labelMsgName.Content = "";
            labelMsgAge.Content = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxAge.Text = "";
        }
    }
}
