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
            AzulRadioButton.IsChecked = true;
        }

        private void TextoUsuarioTexBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextoConFormato.Text = TextoUsuarioTexBox.Text;
        } 
        

        private void ColoresRadioButton_onClick(object sender, RoutedEventArgs e)
        {
            if (AzulRadioButton.IsChecked == true)
                TextoConFormato.Foreground = Brushes.Blue;
            else if (RojoRadioButton.IsChecked == true)
                TextoConFormato.Foreground = Brushes.Red;
            else TextoConFormato.Foreground = Brushes.Green;
        }
         
        //Corregir checkd y unchecked con los colores y cursiva
        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (NegritaCheckBox.IsChecked == true)
                TextoConFormato.FontWeight = FontWeights.Bold;

        }

        private void NegritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            if(NegritaCheckBox.IsChecked == false)
                TextoConFormato.FontWeight = FontWeights.Normal;
        }

        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (CursivaCheckBox.IsChecked == true)
                TextoConFormato.FontStyle = FontStyles.Italic;
        }

        private void CursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {

            if (CursivaCheckBox.IsChecked == false)
                TextoConFormato.FontStyle = FontStyles.Normal;
        }

        private void AzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (AzulRadioButton.IsChecked == true)
                TextoConFormato.Foreground = Brushes.Blue;
        }
        private void RojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (RojoRadioButton.IsChecked == true)
                TextoConFormato.Foreground = Brushes.Red;
        }
        private void VerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (VerdeRadioButton.IsChecked == true)
                TextoConFormato.Foreground = Brushes.Green;
        }
    }
}
