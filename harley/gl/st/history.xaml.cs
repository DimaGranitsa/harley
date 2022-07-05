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
    /// Логика взаимодействия для history.xaml
    /// </summary>
    public partial class history : Page
    {
        public history()
        {
            InitializeComponent();
            pan.ItemsSource = bd.connect.harleyEntities.histori.ToList();
        }

        private void pan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
