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
using System.Windows.Shapes;
using harley.bd;

namespace harley.gl.st.model.lic
{
    /// <summary>
    /// Логика взаимодействия для lic3.xaml
    /// </summary>
    public partial class lic3 : Window
    {
        public lic3()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void regButton_Click_1(object sender, RoutedEventArgs e)
        {
            bd.login_data qwe = new bd.login_data()
            {
                login = (txtUsername.Text),
                password = txtpassword.Password,
                Name = txtUsername1.Text
                
            };
            bd.connect.harleyEntities.login_data.Add(qwe);
            bd.connect.harleyEntities.SaveChanges();

        }
    }
}
