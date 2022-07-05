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


namespace harley.gl.st.model.mod
{
    /// <summary>
    /// Логика взаимодействия для spotster1.xaml
    /// </summary>
    public partial class spotster1 : Page
    {
        public spotster1()
        {
            InitializeComponent();
            s1.ItemsSource = bd.connect.harleyEntities.spotster.ToList().Where(z => z.division == 1);
           
        }

        private void s1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void f2_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void s2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void s3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void f1_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void f2_Navigated_1(object sender, NavigationEventArgs e)
        {

        }

        private void f3_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void s2_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void s3_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
