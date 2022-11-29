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
    /// Логика взаимодействия для EditServise.xaml
    /// </summary>
    public partial class EditServise : Window
    {
        SDBEntities SC;
        public EditServise(SDBEntities sDBEntities, ServiceCenter reda1 )
        {
            InitializeComponent();
            this.SC = sDBEntities;
            this.DataContext = reda1;
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
