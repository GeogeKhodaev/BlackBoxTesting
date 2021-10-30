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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double a, b, c, d;
                a = Convert.ToDouble(aTextBox.Text);
                b = Convert.ToDouble(bTextBox.Text);
                c = Convert.ToDouble(cTextBox.Text);
                d = b * b - 4 * a * c;
                if (b * b - 4 * a * c < 0 || a == 0)
                {
                    MessageBox.Show("Решений нет");
                    returnTextbox.Text = " ";
                    returnTextbox2.Text = " ";
                }
                else if (b * b - 4 * a * c == 0)
                {
                    returnTextbox.Text = Convert.ToString((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
                    returnTextbox2.Text = " ";
                }
                else
                {
                    returnTextbox.Text = Convert.ToString((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
                    returnTextbox2.Text = Convert.ToString((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a));
                }
            }
            catch (FormatException) 
            {
                MessageBox.Show("заполните поля корректными данными");
            }
        }
    }
}
