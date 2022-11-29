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
    /// Логика взаимодействия для Cs.xaml
    /// </summary>
    public partial class Cs : Window
    {
        SDBEntities BD;
        public Cs()
        {
            BD = new SDBEntities();
            InitializeComponent();
            TableClientservice.ItemsSource = BD.ClientService.ToList();
        }
        private void exit_btn(object sender, object e)
        {
            Close();
        }
    }
}
