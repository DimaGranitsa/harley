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
using System.Windows.Threading;
using System.Collections.ObjectModel;
using System.Reflection;
using harley.bd;

namespace harley.gl.st.model.mod
{
    /// <summary>
    /// Логика взаимодействия для spotstr.xaml
    /// </summary>
    public partial class spotstr : Page
    {
       
        public spotstr()
        {
            InitializeComponent();/*SportsterS*/
            s1.ItemsSource = bd.connect.harleyEntities.spotster.ToList().Where(z => z.division == 1);

        }

        private void spotster_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void spotster_Click(object sender, RoutedEventArgs e)
        {
            f2.Navigate(new spotster1());
        }

        private void f2_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
