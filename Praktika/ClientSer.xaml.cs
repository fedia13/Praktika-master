using Microsoft.Win32;
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

namespace Praktika
{
    /// <summary>
    /// Логика взаимодействия для ClientSer.xaml
    /// </summary>
    public partial class ClientSer : Window
    {
        SDBEntities SDBEntities { get; set; }
        public ClientSer()
        {
            SDBEntities = new SDBEntities();
            InitializeComponent();
            TableServ.ItemsSource = SDBEntities.ServiceCenter.ToList();

        }
        private void exit_btn(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            SDBEntities=new SDBEntities();
            ServiceCenter item = TableServ.SelectedItem as ServiceCenter;
            try
            {
                ServiceCenter ser = SDBEntities.ServiceCenter.Where(c => c.ID == item.ID).Single();
                SDBEntities.ServiceCenter.Remove(ser);
                SDBEntities.SaveChanges();

                MessageBox.Show("Данные успешно удалены");
                refreshdatagrid();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void refreshdatagrid()
        {
            SDBEntities  = new SDBEntities();
            TableServ.ItemsSource = SDBEntities.ServiceCenter.ToList();
            TableServ.Items.Refresh();
        }

        private void Add_Button(object sender, RoutedEventArgs e)
        {
            var NewDob = new ServiceCenter();
            SDBEntities.ServiceCenter.Add(NewDob);
            OpenFileDialog das = new OpenFileDialog();
            das.Title = "Выберите изображение";
            das.Filter = "All supported graphics|*.jpeg;*.jpg;*.png|" + " JPEG(*.jpeg;*.jpg)|*.jpeg;*.jpg|" +
            "Portable Network Graphic (*.png)|*.png";
            if (das.ShowDialog() == true)
            {
                NewDob.Photo = new Photo { PhotoPath = das.FileName };
            }
            var NewDob1 = new AddService(SDBEntities, NewDob);
            NewDob1.ShowDialog();
        }

        private void refresh_Button(object sender, RoutedEventArgs e)
        {
            refreshdatagrid();
        }

        private void EditDelete_Click(object sender, RoutedEventArgs e)
        {
            Button reda = sender as Button;
            var reda1 = reda.DataContext as ServiceCenter;
            OpenFileDialog das = new OpenFileDialog();
            das.Title = "Выберите изображение";
            das.Filter = "All supported graphics|*.jpeg;*.jpg;*.png|" + " JPEG(*.jpeg;*.jpg)|*.jpeg;*.jpg|" +
            "Portable Network Graphic (*.png)|*.png";
            if (das.ShowDialog() == true)
            {
                reda1.Photo = new Photo { PhotoPath = das.FileName };
            }
            var reda2 = new EditServise(SDBEntities, reda1);
            reda2.ShowDialog();
        }
    }
 }

