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
using System.Diagnostics;
using harley.gl.st.model.motor.motor1;
using harley.gl.st.model.o;
using harley.gl.st.model.lic;
using harley.gl.st.model.otzov;
using harley.bd;

namespace harley.gl.st
{
    /// <summary>
    /// Логика взаимодействия для oc.xaml
    /// </summary>
    public partial class oc : Page
    {
        public oc()
        {
            InitializeComponent();
            if (ActualData.Id_User == 0)
            {
                otzov4.IsEnabled = false;
            }
            else { otzov4.IsEnabled = true; }
            f1.Navigate(new dom());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.GetNavigationService(new st.dom());
            f1.Navigate(new dom());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new mod());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new motor2());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new history());
        }


        private void lic_Click(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new lic2());
            
        }

        private void orjv_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void otzov4_Click(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new gl.st.model.otzov.otzov2());
        }

        private void orjv_Click(object sender, RoutedEventArgs e)
        {
           f1.Navigate(new ocomp());
        }

        private void ob_Click(object sender, RoutedEventArgs e)
        {
            if (ActualData.Id_User == 0)
            {
                otzov4.IsEnabled = false;
            }
            else { otzov4.IsEnabled = true; }
        }
    }
}
