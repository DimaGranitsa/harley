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
using harley.gl.st.model.mod;
using harley.bd;
using harley.gl.st.model.mod.softeil;
using harley.gl.st.model.mod.tur1;
using harley.gl.st.model.mod.tri1;
using harley.gl.st.model.mod.cvo1;
using harley.gl.st.model.mod.pan1;


namespace harley.gl.st
{
    /// <summary>
    /// Логика взаимодействия для mod.xaml
    /// </summary>
    public partial class mod : Page
    {
          
        public mod()
        {
            InitializeComponent();
          
        }

        private void spotster_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var sprt = spotster.SelectedItem;
           
        }

        private void spotstr_Navigated(object sender, NavigationEventArgs e)
        {
           
        }

        private void mom1_Navigated(object sender, NavigationEventArgs e)
        {
            

        }

        private void m1_Click(object sender, RoutedEventArgs e)
        {
            mot1.Navigate(new spotstr());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void m2_Click(object sender, RoutedEventArgs e)
        {
            mot1.Navigate(new tur1());
        }

        private void m3_Click(object sender, RoutedEventArgs e)
        {
            mot1.Navigate(new tri2 ());
        }

        private void m4_Click(object sender, RoutedEventArgs e)
        {
            mot1.Navigate(new softeil());
        }

        private void m4_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void m5_Click(object sender, RoutedEventArgs e)
        {
            mot1.Navigate(new cvo2());
        }

        private void m6_Click(object sender, RoutedEventArgs e)
        {
            mot1.Navigate(new pan2());
        }
    }
}
