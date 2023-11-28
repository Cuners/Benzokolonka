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

namespace Benzokolonka
{
    /// <summary>
    /// Логика взаимодействия для ChooseBenzUserControl.xaml
    /// </summary>
    public partial class ChooseBenzUserControl : UserControl
    {
        private bool SelectedObj=false;
        private bool SelectedPin=false;
        private bool SelectedCvv=false;
        public ChooseBenzUserControl()
        {
            InitializeComponent();
            myComboBox.ItemsSource = new string[]
            {
                "80",
                "92",
                "95"
            };
            myComboBox.SelectedIndex = 0;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TextBoxName.Text = "";
            RubTextBox.Text = "";
            TextBoxNameCVV.Text = "";
            TextBoxNamePin.Text = "";
            TextBoxName.IsEnabled = true;
            
        }

        private void TextBoxName_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBoxNamePin.IsEnabled = true;
            TextBoxNameCVV.IsEnabled = true;
            if (myComboBox.SelectedItem.ToString() == "80" && TextBoxName.Text.Length!=0)
            {
                double cena = 31.62 * Convert.ToDouble(TextBoxName.Text);
                RubTextBox.Text=cena.ToString();
                
            }
            else if(myComboBox.SelectedItem.ToString() == "92" && TextBoxName.Text.Length != 0)
            {
                double cena = 50.43 * Convert.ToDouble(TextBoxName.Text);
                RubTextBox.Text = cena.ToString();
            }
            else if (myComboBox.SelectedItem.ToString() == "95" && TextBoxName.Text.Length != 0)
            {
                double cena = 54 * Convert.ToDouble(TextBoxName.Text);
                RubTextBox.Text = cena.ToString();
            }
            if (TextBoxName.Text.Length == 0)
            {
                RubTextBox.Text = "";
                TextBoxNamePin.IsEnabled = false;
                TextBoxNameCVV.IsEnabled = false;
                TextBoxNamePin.Text = "";
                TextBoxNameCVV.Text = "";
            }
        }

        private void But1_Click(object sender, RoutedEventArgs e)
        {
            if(TextBoxName.IsEnabled && SelectedObj)
            {
                TextBoxName.Text += "1";
            }
            else if(TextBoxNamePin.IsEnabled && SelectedPin && TextBoxNamePin.Text.Length < 16)
            {
                TextBoxNamePin.Text += "1";
            }
            else if (TextBoxNameCVV.IsEnabled && SelectedCvv && TextBoxNameCVV.Text.Length < 3)
            {
                TextBoxNameCVV.Text += "1";
            }
        }

        private void But2_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.IsEnabled && SelectedObj)
            {
                TextBoxName.Text += "2";
            }
            else if (TextBoxNamePin.IsEnabled && SelectedPin && TextBoxNamePin.Text.Length < 16)
            {
                TextBoxNamePin.Text += "2";
            }
            else if (TextBoxNameCVV.IsEnabled && SelectedCvv && TextBoxNameCVV.Text.Length < 3)
            {
                TextBoxNameCVV.Text += "2";
            }
        }

        private void But3_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.IsEnabled && SelectedObj)
            {
                TextBoxName.Text += "3";
            }
            else if (TextBoxNamePin.IsEnabled && SelectedPin && TextBoxNamePin.Text.Length < 16)
            {
                TextBoxNamePin.Text += "3";
            }
            else if (TextBoxNameCVV.IsEnabled && SelectedCvv && TextBoxNameCVV.Text.Length < 3)
            {
                TextBoxNameCVV.Text += "3";
            }
        }

        private void But4_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.IsEnabled && SelectedObj)
            {
                TextBoxName.Text += "4";
            }
            else if (TextBoxNamePin.IsEnabled && SelectedPin && TextBoxNamePin.Text.Length < 16)
            {
                TextBoxNamePin.Text += "4";
            }
            else if (TextBoxNameCVV.IsEnabled && SelectedCvv && TextBoxNameCVV.Text.Length < 3)
            {
                TextBoxNameCVV.Text += "4";
            }
        }

        private void But5_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.IsEnabled && SelectedObj)
            {
                TextBoxName.Text += "5";
            }
            else if (TextBoxNamePin.IsEnabled && SelectedPin && TextBoxNamePin.Text.Length < 16)
            {
                TextBoxNamePin.Text += "5";
            }
            else if (TextBoxNameCVV.IsEnabled && SelectedCvv && TextBoxNameCVV.Text.Length < 3)
            {
                TextBoxNameCVV.Text += "5";
            }
        }

        private void But6_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.IsEnabled && SelectedObj)
            {
                TextBoxName.Text += "6";
            }
            else if (TextBoxNamePin.IsEnabled && SelectedPin && TextBoxNamePin.Text.Length < 16)
            {
                TextBoxNamePin.Text += "6";
            }
            else if (TextBoxNameCVV.IsEnabled && SelectedCvv && TextBoxNameCVV.Text.Length < 3)
            {
                TextBoxNameCVV.Text += "6";
            }
        }

        private void But7_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.IsEnabled && SelectedObj)
            {
                TextBoxName.Text += "7";
            }
            else if (TextBoxNamePin.IsEnabled && SelectedPin && TextBoxNamePin.Text.Length < 16)
            {
                TextBoxNamePin.Text += "7";
            }
            else if (TextBoxNameCVV.IsEnabled && SelectedCvv && TextBoxNameCVV.Text.Length < 3)
            {
                TextBoxNameCVV.Text += "7";
            }
        }

        private void But8_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.IsEnabled && SelectedObj)
            {
                TextBoxName.Text += "8";
            }
            else if (TextBoxNamePin.IsEnabled && SelectedPin && TextBoxNamePin.Text.Length < 16)
            {
                TextBoxNamePin.Text += "8";
            }
            else if (TextBoxNameCVV.IsEnabled && SelectedCvv && TextBoxNameCVV.Text.Length < 3)
            {
                TextBoxNameCVV.Text += "8";
            }
        }

        private void But9_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.IsEnabled && SelectedObj)
            {
                TextBoxName.Text += "9";
            }
            else if (TextBoxNamePin.IsEnabled && SelectedPin && TextBoxNamePin.Text.Length < 16)
            {
                TextBoxNamePin.Text += "9";
            }
            else if (TextBoxNameCVV.IsEnabled && SelectedCvv && TextBoxNameCVV.Text.Length < 3)
            {
                TextBoxNameCVV.Text += "9";
            }
        }

        private void But0_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.IsEnabled && SelectedObj)
            {
                TextBoxName.Text += "0";
            }
            else if (TextBoxNamePin.IsEnabled && SelectedPin)
            {
                TextBoxNamePin.Text += "0";
            }
            else if (TextBoxNameCVV.IsEnabled && SelectedCvv && TextBoxNameCVV.Text.Length<3)
            {
                TextBoxNameCVV.Text += "0";
            }
        }

        private void TextBoxName_GotFocus(object sender, RoutedEventArgs e)
        {
            SelectedObj = true;
            SelectedPin = false;
            SelectedCvv = false;
        }

        private void TextBoxNamePin_GotFocus(object sender, RoutedEventArgs e)
        {
            SelectedObj = false;
            SelectedPin = true;
            SelectedCvv = false;
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            SelectedObj = false;
            SelectedPin = false;
            SelectedCvv = true;
        }

        private void ButX_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.IsEnabled && SelectedObj )
            {
                TextBoxName.Text = "";
            }
            else if (TextBoxNamePin.IsEnabled && SelectedPin)
            {
                TextBoxNamePin.Text = "";

            }
            else if (TextBoxNameCVV.IsEnabled && SelectedCvv)
            {
                TextBoxNameCVV.Text = "";
            }
        }

        private void Butback_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.IsEnabled && SelectedObj && TextBoxName.Text.Length != 0)
            {
                TextBoxName.Text = TextBoxName.Text.Remove(TextBoxName.Text.Length-1);
            }
            else if (TextBoxNamePin.IsEnabled && SelectedPin && TextBoxNamePin.Text.Length!=0)
            {
                TextBoxNamePin.Text = TextBoxNamePin.Text.Remove(TextBoxNamePin.Text.Length - 1);
                
            }
            else if (TextBoxNameCVV.IsEnabled && SelectedCvv && TextBoxNameCVV.Text.Length!=0)
            {
                TextBoxNameCVV.Text = TextBoxNameCVV.Text.Remove(TextBoxNameCVV.Text.Length - 1);
            }
        }

        private void PayButton_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(TextBoxName.Text)>100)
            {
                ErrorTextBox.Text = "Больше 100 литров влить нельзя";
            }
            else if(TextBoxNamePin.Text.Length==16 && TextBoxNameCVV.Text.Length == 3)
            {
                ErrorTextBox.Text = "Оплата прошла. Вставьте пистолет в бак";
                MyBenz.Objem = Convert.ToInt32(TextBoxName.Text);
                MyBenz.RubObjem = Convert.ToDouble(RubTextBox.Text);
                MyBenz.NumOfBenz = Convert.ToInt32(myComboBox.SelectedItem.ToString());
                TextBoxNameCVV.Text = "";
                TextBoxNamePin.Text = "";
                TextBoxName.Text = "";
                RubTextBox.Text = "";
            }
            else if(TextBoxNamePin.Text.Length != 16)
            {
                ErrorTextBox.Text = "Пин Код введен не полностью";
            }
            else if (TextBoxNameCVV.Text.Length != 3)
            {
                ErrorTextBox.Text = "CVV введен не полностью";
            }
            
        }
    }
}
