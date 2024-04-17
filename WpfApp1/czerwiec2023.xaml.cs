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

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy czerwiec2023.xaml
    /// </summary>
    public partial class czerwiec2023 : Window
    {
        public czerwiec2023()
        {
            InitializeComponent();
        }

        private void powrot_Click(object sender, RoutedEventArgs e)
        {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                this.Close();
        }
    }
}
