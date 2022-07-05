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
using harley.gl.st.model;



namespace harley.gl.st.model.lic
{
    /// <summary>
    /// Логика взаимодействия для lic2.xaml
    /// </summary>
    public partial class lic2 : Page
    {
        public lic2()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            lic3 reg = new lic3();
            reg.Show();
        }

        private void vhodButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtpassword.Password))
            {
                MessageBox.Show($"Пожалуйста введите логин и пароль", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {

                var a = bd.connect.harleyEntities.login_data.Where(z => z.login == txtUsername.Text && z.password == txtpassword.Password).FirstOrDefault();
                if (a != null)
                {
                    ActualData.Id_User = a.id;
                    var b = a.Name.FirstOrDefault();
                    if (a.Name == "Admin")
                    {
                        MessageBox.Show($"Добро пожаловать  {a.Name}", "Вход в личные кабинет", MessageBoxButton.OK, MessageBoxImage.Information);
                        MainWindow.login = a;
                        f1.Navigate(new lic1());
                        
                    }
                    else if(a.id == a.id)
                        
                    {
                        MessageBox.Show($"Добро пожаловать  {a.Name}", "Вход в личные кабинет", MessageBoxButton.OK, MessageBoxImage.Information);
                        MainWindow.login = a;
                        f1.Navigate(new dom());


                    }
                }
                else
                {
                    MessageBox.Show($"Логин или пароль не верный!\n Пожалуйста попробуйте ещё раз", "Вход в личный кабинет", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void f1_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
         
       

}
