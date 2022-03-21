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

namespace llerlllu2
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        //ax^2+bx+c
        private void Button_Click(object sender, RoutedEventArgs e)
        {
        
            double a = double.Parse(Text1.Text);
            double b = double.Parse(Text2.Text);
            double c = double.Parse(Text3.Text);

            double res = b * b - 4 * a * c;
            double x1 = (b * (-1) + Math.Sqrt(res)) / (2 * a);
            double x2 = (b * (-1) - Math.Sqrt(res)) / (2 * a);
            Text4.Text = res.ToString();
        }

        }
    }

