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

namespace harley.gl.st.model.mod.tri1
{
    /// <summary>
    /// Логика взаимодействия для tri2.xaml
    /// </summary>
    public partial class tri2 : Page
    {
        public tri2()
        {
            InitializeComponent();
            pan.ItemsSource = bd.connect.harleyEntities.spotster.ToList().Where(z => z.division == 6);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 23).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new tri3());
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 24).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new tri3());
        }

        private void Image_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 25).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new tri3());
        }

        private void pan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void mot1_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
