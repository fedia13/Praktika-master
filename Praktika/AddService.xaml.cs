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
    /// Логика взаимодействия для AddService.xaml
    /// </summary>
    public partial class AddService : Window
    {
        SDBEntities SC;
        public AddService(SDBEntities context1, ServiceCenter service)
        {
            InitializeComponent();
            this.SC = context1;
            this.DataContext = service;
        }
        private void btnAdd(object sender, RoutedEventArgs e)
        {
            SC.SaveChanges();
            this.Close();
        }
        private void btnBack(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
