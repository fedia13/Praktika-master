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

namespace Praktika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Btm_close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn_Serv(object sender, RoutedEventArgs e)
        {
            Cs cs = new Cs();
            cs.ShowDialog();
        }

        private void Btn_ClientSer(object sender, RoutedEventArgs e)
        {
            ClientSer clientSer = new ClientSer();
            clientSer.ShowDialog();
        }

    }
}
