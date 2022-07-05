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

namespace harley.gl.st.model.lic
{
    /// <summary>
    /// Логика взаимодействия для vhod.xaml
    /// </summary>
    public partial class vhod : Page
    {
        public vhod()
        {
            InitializeComponent();
            std.ItemsSource = bd.connect.harleyEntities.login_data.ToList();
        }

        private void serach_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            std.ItemsSource = bd.connect.harleyEntities.login_data.ToList().Where(z => z.Name.Contains(serach_tb.Text)); //поиск по имени
        }
        private void refr()
        {
            std.ItemsSource = bd.connect.harleyEntities.login_data.ToList();
        }
        private void add_students_Click(object sender, RoutedEventArgs e)
        {
            lic5 reg = new lic5();
            reg.Show();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            var b = std.SelectedItem as bd.login_data;
            if (b != null)
            {
                bd.connect.harleyEntities.login_data.Remove(b);
                bd.connect.harleyEntities.SaveChanges();

            }
            else { MessageBox.Show("Такой записи нет"); }
            refr();
        }

        private void sort_az_Click(object sender, RoutedEventArgs e)
        {
            std.ItemsSource = bd.connect.harleyEntities.login_data.ToList().OrderBy(z => z.Name);
        }

        private void std_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ob_az_Click(object sender, RoutedEventArgs e)
        {
            refr();
        }
    }
}
