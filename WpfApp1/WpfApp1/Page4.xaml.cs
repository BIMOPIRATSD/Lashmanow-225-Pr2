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
using static System.Math;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!double.TryParse(Text1.Text, out double A))
            {

            }
            if(!double.TryParse(Text2.Text, out double B))
            {

            }
            if(!double.TryParse(Text3.Text, out double C))
            {

            }
            double S1 = A * B;
            double S2 = C * C;
            double x = S1 / S2;
            double y = S1 - x * Sqrt(C);
            Text4.Text += $"Колличество размещённых квадратов = {x}\n, Оставшаяся площадь = {y}\n";
        }
    }
}
