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
    /// Логика взаимодействия для otzov2.xaml
    /// </summary>
    public partial class otzov2 : Page
    {
        public otzov2()
        {
            InitializeComponent();
            //pan1.ItemsSource = bd.connect.harleyEntities.otzov10.ToList().Where(z => z.tip == 1);
            //pan.ItemsSource = bd.connect.harleyEntities.otzov2.ToList().Where(z => z.tip == 1);
            std.ItemsSource = bd.connect.harleyEntities.otzov3.ToList();
            ward.ItemsSource = bd.connect.harleyEntities.otzov3.ToList();
            pan1.ItemsSource = bd.connect.harleyEntities.spotster.ToList();
            pan.ItemsSource = bd.connect.harleyEntities.motor.ToList();

        }
        private void refr()
        {
            std.ItemsSource = bd.connect.harleyEntities.otzov3.ToList();
        }
        private void redact()
        {
            bd.otzov3 qwe1 = new bd.otzov3();

            if (std.SelectedIndex == -1)
                return;

            else
            {
                name1.Text = ((bd.otzov3)std.SelectedItem).name;
                motor.Text = ((bd.otzov3)std.SelectedItem).motor;
                mottxt.Text = ((bd.otzov3)std.SelectedItem).mot;
                otzov4.Text = ((bd.otzov3)std.SelectedItem).otzov2;
                otzov6.Text = ((bd.otzov3)std.SelectedItem).otzov5;
            }
            bd.connect.harleyEntities.otzov3.Add(qwe1);
            var red = std.SelectedItem as otzov3;
            red.name = name1.Text;
            red.motor = motor3.Text;
            red.mot = moto3.Text;
            red.otzov2 = otzov4.Text;
            red.otzov5 = otzov6.Text;
            bd.connect.harleyEntities.SaveChanges();
            refr();
        }

        private void pan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void pan1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void serach_tb_TextChanged(object sender, TextChangedEventArgs e)
        {

            std.ItemsSource = bd.connect.harleyEntities.otzov3.ToList().Where(z => z.name.Contains(serach_tb.Text)); //поиск по имени
        }

        private void std_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void add_students_Click(object sender, RoutedEventArgs e)
        {
            bd.otzov3 qwe = new bd.otzov3()
            {
                name = name1.Text,
                motor = motor3.Text,
                mot = moto3.Text,
                otzov2 = otzov4.Text,
                otzov5 = otzov6.Text,

            };
            bd.connect.harleyEntities.otzov3.Add(qwe);
            bd.connect.harleyEntities.SaveChanges();
            refr();
        }

        private void sort_az_Click(object sender, RoutedEventArgs e)
        {
            std.ItemsSource = bd.connect.harleyEntities.otzov3.ToList().OrderBy(z => z.name); /*сортеровка по имени*/
        }

        private void ob_az_Click(object sender, RoutedEventArgs e)
        {
            refr();
        }

        private void std_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            //var b = ((sender as ListView).SelectedItem as otzov3);
            if (std.SelectedIndex == -1)
                return;
            else
            {
                name1.Text = ((bd.otzov3)std.SelectedItem).name;
                motor.Text = ((bd.otzov3)std.SelectedItem).motor;
                mottxt.Text = ((bd.otzov3)std.SelectedItem).mot;
                otzov4.Text = ((bd.otzov3)std.SelectedItem).otzov2;
                otzov6.Text = ((bd.otzov3)std.SelectedItem).otzov5;
            }
        }

        private void motor3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void moto3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void otzov4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void otzov6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void redak_Click(object sender, RoutedEventArgs e)
        {
            redact();
        }

        private void NaMe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ward_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string cbselect = ward.SelectedItem.ToString();
            
        }
    }
}
