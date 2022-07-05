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

namespace harley.gl.st.model.lic
{
    /// <summary>
    /// Логика взаимодействия для lic5.xaml
    /// </summary>
    public partial class lic5 : Window
    {
        public lic5()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
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
