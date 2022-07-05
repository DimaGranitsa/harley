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

namespace harley.gl.st.model.mod.softeil
{
    /// <summary>
    /// Логика взаимодействия для softeil.xaml
    /// </summary>
    public partial class softeil : Page
    {
        public softeil()
        {
            InitializeComponent();
           
            pan.ItemsSource = bd.connect.harleyEntities.spotster.ToList().Where(z => z.division == 2);
            


        }
        public void Refresh()
        {

        }
        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 2).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new softeil1());

        }

       

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 4).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new softeil1());
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 8).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new softeil1());
        }

        private void Image_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 9).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new softeil1());
        }

        private void Image_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 11).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new softeil1());
        }

        private void Image_MouseDown_5(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 12).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new softeil1());
        }

        private void Image_MouseDown_6(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 13).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new softeil1());
        }

        private void Image_MouseDown_7(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 16).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new softeil1());
        }

       

      

        private void Image_MouseDown_8(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 21).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new softeil1());
        }

        private void pan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void mot1_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
