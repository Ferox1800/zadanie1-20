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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void sty23_Click(object sender, RoutedEventArgs e)
        {
            styczen2023 Styczen2023 = new styczen2023();
            Styczen2023.Show();

            this.Close();
        }

        private void sty24_Click(object sender, RoutedEventArgs e)
        {
                styczen2024 Styczen2024 = new styczen2024();
                Styczen2024.Show();

                this.Close();
            }

        private void cze23_Click(object sender, RoutedEventArgs e)
        {
            czerwiec2023 Czerwiec2023 = new czerwiec2023();
            Czerwiec2023.Show();
        }
    }
}
