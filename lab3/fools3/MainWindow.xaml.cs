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

namespace xlrs13._05lab3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if (statusBar.Tag == null)
            {
                statusBar.Tag = true;
                statusItem.Content = "Готово";
            }
        }


        private void OnBackgroundChangedButtonClick(object sender, RoutedEventArgs e)
        {
            string selectedColor = (colorComboBox.SelectedItem as ComboBoxItem).Content.ToString();

            System.Windows.Media.SolidColorBrush brush = (System.Windows.Media.SolidColorBrush)new System.Windows.Media.BrushConverter().ConvertFromString(selectedColor);

            this.Background = brush;

            statusItem.Content = $"Background color changed to {selectedColor}.";
        }

        private void OnAboutButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Это программа сделана Александрой Патрикеевой", "About", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void OnExitButtonClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OnColorComboBoxSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedColor = (colorComboBox.SelectedItem as ComboBoxItem).Content.ToString();

            System.Windows.Media.SolidColorBrush brush = (System.Windows.Media.SolidColorBrush)new System.Windows.Media.BrushConverter().ConvertFromString(selectedColor);

            this.Background = brush;

            statusItem.Content = $"Background color changed to {selectedColor}.";
        }
    }
    
}
