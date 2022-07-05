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

namespace harley
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bd.login_data login;
        public MainWindow()
        {
            InitializeComponent();
            qwerty.Navigate(new gl.st.oc());

        }

        private void qwerty_Navigated(object sender, NavigationEventArgs e)
        {
            NavigationService.GetNavigationService(new gl.st.oc());
        }
    }
}
