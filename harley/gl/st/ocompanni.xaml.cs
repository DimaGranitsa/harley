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

namespace harley.gl.st
{
    /// <summary>
    /// Логика взаимодействия для ocompanni.xaml
    /// </summary>
    public partial class ocompanni : Page
    {
        public ocompanni()
        {
            InitializeComponent();
            pan.ItemsSource = bd.connect.harleyEntities.ocom.ToList();
            
        }

        private void pan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void pan1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
