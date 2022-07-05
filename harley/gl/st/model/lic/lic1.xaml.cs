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

namespace harley.gl.st.model.lic
{
    /// <summary>
    /// Логика взаимодействия для lic1.xaml
    /// </summary>
    public partial class lic1 : Page
    {
        public lic1()
        {
            InitializeComponent();
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new odzovaddmin());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new vhod());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new licnaz());
        }
    }
}
