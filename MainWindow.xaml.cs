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

namespace Tema2_CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextoUsuarioTexBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextoConFormato.Text = TextoUsuarioTexBox.Text;
        }
        private void CheckBox_onClick(object sender, RoutedEventArgs e)
        {
            if (NegritaCheckBox.IsChecked == true)
                TextoConFormato.FontWeight = FontWeights.Bold;
            else
                TextoConFormato.FontWeight = FontWeights.Normal;

            if (CursivaCheckBox.IsChecked == true)
                TextoConFormato.FontStyle = FontStyles.Italic;
            else
                TextoConFormato.FontStyle = FontStyles.Normal;
        }

        private void ColoresRadioButton_onClick(object sender, RoutedEventArgs e)
        {
            if (AzulRadioButton.IsChecked == true)
                TextoConFormato.Foreground = Brushes.Blue;
            else if (RojoRadioButton.IsChecked == true)
                TextoConFormato.Foreground = Brushes.Red;
            else TextoConFormato.Foreground = Brushes.Green;
        }
    }
}
