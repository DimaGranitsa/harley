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

namespace harley.gl.st.model.lic
{
    /// <summary>
    /// Логика взаимодействия для licnaz.xaml
    /// </summary>
    public partial class licnaz : Page
    {
        public licnaz()
        {
            InitializeComponent();
            this.DataContext = MainWindow.login;

        }
    }
}
