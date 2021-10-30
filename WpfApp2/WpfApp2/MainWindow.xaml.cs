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

namespace WpfApp2
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
                double a, b, c;
                a = Convert.ToDouble(aTextbox.Text);
                b = Convert.ToDouble(bTextbox.Text);
                c = Convert.ToDouble(cTextbox.Text);             
                if (a == b && a != c || a == c && a != b || b == c && b != a)
                    returnTextbox.Text = "треугольник равнобедренный";
                if (a == b && b == c)
                    returnTextbox.Text = "треугольник равносторонний";
                if (a != b && a != c && b != c)
                    returnTextbox.Text = "треугольник разностонний";
                if (Math.Sqrt(a * a + b * b) == Math.Sqrt(c * c))
                    returnTextbox.Text = "треугольник прямоугольный";
                if (a <= 0 || b <= 0 || c <= 0)
                {
                    MessageBox.Show("такого треугольника не существует");
                    returnTextbox.Text = " ";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные данные");
            }

        }
    }
}
