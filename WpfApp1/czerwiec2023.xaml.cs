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

        private void confirm_Click(object sender, RoutedEventArgs e)
        {
            int kod = kod_pocztowy.Text.Length;

            if(kod!=5 ) {
                MessageBox.Show("Kod pocztowy jest niepoprawny");
            }
            else
            {
                MessageBox.Show("Kod pocztowy jest poprawny");
            }
        }

        private void sprawdz_Click(object sender, RoutedEventArgs e)
        {
            double cenaj;
            if(pocztowka.IsChecked == true)
            {
                cenaj = 1;
            }else if(list.IsChecked == true)
            {
                cenaj = 1.5;      
            }else {
                cenaj = 10;
            }

            cena.Content ="cena: "+cenaj +"zł";
        }
    }
}
