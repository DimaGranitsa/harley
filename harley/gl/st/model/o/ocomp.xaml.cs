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

namespace harley.gl.st.model.o
{
    /// <summary>
    /// Логика взаимодействия для ocomp.xaml
    /// </summary>
    public partial class ocomp : Page
    {
        public ocomp()
        {
            InitializeComponent();
            pan.ItemsSource = bd.connect.harleyEntities.ocom.ToList();
            pan1.ItemsSource = bd.connect.harleyEntities.ocom.ToList();
        }

        private void pan1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void pan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
