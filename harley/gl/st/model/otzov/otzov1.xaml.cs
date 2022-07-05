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

namespace harley.gl.st.model.otzov
{
    /// <summary>
    /// Логика взаимодействия для otzov1.xaml
    /// </summary>
    public partial class otzov1 : Page
    {
        public static void comboox()
        {
            

        }
        private void refr()
        {
            std.ItemsSource = bd.connect.harleyEntities.otzov3.ToList();
        }
        public otzov1()
        {
            InitializeComponent();
        
            std.ItemsSource = bd.connect.harleyEntities.otzov3.ToList();
        }

        private void pan1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void pan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            mottxt.Text = moto3.SelectedItem.ToString();
        }

        private void serach_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            std.ItemsSource = bd.connect.harleyEntities.otzov3.ToList().Where(z => z.name.Contains(serach_tb.Text)); //поиск по имени
        }

        private void add_students_Click(object sender, RoutedEventArgs e)
        {
            bd.otzov3 qwe = new bd.otzov3()
            {
                name = (name.Text),
                motor = motor3.Text,
                mot = moto3.Text,
                otzov2 = otzov4.Text,
                otzov5 = otzov6.Text,

            };
            bd.connect.harleyEntities.otzov3.Add(qwe);
            bd.connect.harleyEntities.SaveChanges();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sort_az_Click(object sender, RoutedEventArgs e)
        {
            std.ItemsSource = bd.connect.harleyEntities.otzov3.ToList().OrderBy(z => z.name); /*сортеровка по имени*/
        }

        private void ob_az_Click(object sender, RoutedEventArgs e)
        {
            refr();
        }

        private void std_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {

        }

        private void moto3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void motor3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void otzov4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void otzov6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void otzov6_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
