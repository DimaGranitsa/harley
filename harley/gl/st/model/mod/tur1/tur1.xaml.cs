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

namespace harley.gl.st.model.mod.tur1
{
    /// <summary>
    /// Логика взаимодействия для tur1.xaml
    /// </summary>
    public partial class tur1 : Page
    {
        public tur1()
        {
            InitializeComponent();
            pan.ItemsSource = bd.connect.harleyEntities.spotster.ToList().Where(z => z.division == 3);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 17).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new tur2());
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 3).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new tur2());
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 10).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new tur2());
        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 18).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new tur2());
        }

        private void Image_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 19).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new tur2());
        }

        private void Image_MouseDown_5(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 20).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new tur2());
        }

        private void Image_MouseDown_6(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 22).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new tur2());
        }

        private void pan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void mot1_Navigated(object sender, NavigationEventArgs e)
        {
          
        }

        private void Image_MouseDown_7(object sender, MouseButtonEventArgs e)
        {
var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 26).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new tur2());
        }
    }
}
