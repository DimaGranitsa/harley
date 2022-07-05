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


namespace harley.gl.st.model.mod.pan1
{
    /// <summary>
    /// Логика взаимодействия для pan2.xaml
    /// </summary>
    public partial class pan2 : Page
    {
        public pan2()
        {
            InitializeComponent();
            pan.ItemsSource = bd.connect.harleyEntities.spotster.ToList().Where(z => z.division == 5);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 14).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new pan3());
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            var a = bd.connect.harleyEntities.spotster.Where(z => z.Id == 15).FirstOrDefault();
            ActualData.IDmoto = a.Id;
            mot1.Navigate(new pan3());
        }

        private void pan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void mot1_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
