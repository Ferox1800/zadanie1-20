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
    /// Logika interakcji dla klasy styczen2023.xaml
    /// </summary>
    public partial class styczen2023 : Window
    {
        public styczen2023()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void AcceptOnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("zatwierdzono dane");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }


        public static char[] Random_letters(int lenght, bool number, bool letter, bool character)
        {
            Random rnd = new Random();
            char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            char[] letters = { 'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F', 'g', 'G', 'h', 'H', 'i', 'I', 'j', 'J', 'k', 'K', 'l', 'L', 'm', 'M', 'n', 'N', 'o', 'O', 'p', 'P', 'q', 'Q', 'r', 'R', 's', 'S', 'u', 'U', 'v', 'V', 'w', 'W', 'x', 'X', 'y', 'Y', 'z', 'Z' };
            char[] characters = { '-', '_', '=', '+', '!', '<', '>' };
            char[] password = new char[lenght];

            for (int i = 0; i < lenght; i++)
            {
                password[i] = letters[rnd.Next(0, letters.Length)];
            }
            if (number == true)
            {
                password[0] = numbers[rnd.Next(0, numbers.Length)];
            }
            if (character == true)
            {
                if (lenght > 1)
                {
                    password[1] = characters[rnd.Next(0, characters.Length)];
                }
            }
            if (letter == true)
            {
                if (lenght > 2)
                {
                    password[2] = letters[rnd.Next(0, letters.Length)];
                }
            }
            return password;
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool letter = false;
            bool number = false;
            bool character = false;
            int password_lenght = int.Parse(ilosc.Text);
            if (c_number.IsChecked == true)
            {
                number = true;
            }
            if (c_letter.IsChecked == true)
            {
                letter = true;
            }
            if (c_characters.IsChecked == true)
            {
                character = true;
            }
            char[] genareted_password = Random_letters(password_lenght, number, character, letter);
            string password = "";
            for (int i = 0; i < genareted_password.Length; i++)
            {
                password += genareted_password[i].ToString();
            }
            MessageBox.Show($"Twoje hasło to: {password}");
        }
    }
}
