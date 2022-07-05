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
using harley.gl.st.model.mod.softeil;

namespace harley.gl.st.model.mod.softeil
{
    /// <summary>
    /// Логика взаимодействия для softeil1.xaml
    /// </summary>
    public partial class softeil1 : Page
    {
        public softeil1()
        {
            InitializeComponent();
            s1.ItemsSource = null;
            s1.ItemsSource = bd.connect.harleyEntities.spotster.Where(z => z.Id == ActualData.IDmoto).ToList();
        }

        private void s1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void f1_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
