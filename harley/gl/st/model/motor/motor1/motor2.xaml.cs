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
using harley.bd;

namespace harley.gl.st.model.motor.motor1
{
    /// <summary>
    /// Логика взаимодействия для motor2.xaml
    /// </summary>
    public partial class motor2 : Page
    {
        public motor2()
        {
            InitializeComponent();
            pan.ItemsSource = bd.connect.harleyEntities.motor.ToList();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.motor.Where(z => z.id == 1).FirstOrDefault();
            Actualdata1.Tipmotor = a.id;
            mot1.Navigate(new motor3());
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.motor.Where(z => z.id == 2).FirstOrDefault();
            Actualdata1.Tipmotor = a.id;
            mot1.Navigate(new motor3());
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.motor.Where(z => z.id == 3).FirstOrDefault();
            Actualdata1.Tipmotor = a.id;
            mot1.Navigate(new motor3());
        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.motor.Where(z => z.id == 4).FirstOrDefault();
            Actualdata1.Tipmotor = a.id;
            mot1.Navigate(new motor3());
        }

        private void Image_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.motor.Where(z => z.id == 5).FirstOrDefault();
            Actualdata1.Tipmotor = a.id;
            mot1.Navigate(new motor3());
        }

        private void Image_MouseDown_5(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.motor.Where(z => z.id == 6).FirstOrDefault();
            Actualdata1.Tipmotor = a.id;
            mot1.Navigate(new motor3());
        }

        private void Image_MouseDown_6(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.motor.Where(z => z.id == 7).FirstOrDefault();
            Actualdata1.Tipmotor = a.id;
            mot1.Navigate(new motor3());
        }

        private void Image_MouseDown_7(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.motor.Where(z => z.id == 8).FirstOrDefault();
            Actualdata1.Tipmotor = a.id;
            mot1.Navigate(new motor3());
        }

        private void Image_MouseDown_8(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.motor.Where(z => z.id == 9).FirstOrDefault();
            Actualdata1.Tipmotor = a.id;
            mot1.Navigate(new motor3());
        }

        private void Image_MouseDown_9(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.motor.Where(z => z.id == 10).FirstOrDefault();
            Actualdata1.Tipmotor = a.id;
            mot1.Navigate(new motor3());
        }

        private void Image_MouseDown_10(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.motor.Where(z => z.id == 11).FirstOrDefault();
            Actualdata1.Tipmotor = a.id;
            mot1.Navigate(new motor3());
        }

        private void Image_MouseDown_11(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.motor.Where(z => z.id == 12).FirstOrDefault();
            Actualdata1.Tipmotor = a.id;
            mot1.Navigate(new motor3());
        }

        private void Image_MouseDown_12(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.motor.Where(z => z.id == 13).FirstOrDefault();
            Actualdata1.Tipmotor = a.id;
            mot1.Navigate(new motor3());
        }

        private void Image_MouseDown_13(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.motor.Where(z => z.id == 14).FirstOrDefault();
            Actualdata1.Tipmotor = a.id;
            mot1.Navigate(new motor3());
        }

        private void pan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void mot1_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
