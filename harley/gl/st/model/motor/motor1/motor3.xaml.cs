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

namespace harley.gl.st.model.motor.motor1
{
    /// <summary>
    /// Логика взаимодействия для motor3.xaml
    /// </summary>
    public partial class motor3 : Page
    {
        public motor3()
        {
            InitializeComponent();
            s1.ItemsSource = null;
            s1.ItemsSource = bd.connect.harleyEntities.motor.Where(z => z.id == Actualdata1.Tipmotor).ToList();
        }

        private void s1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void f1_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
