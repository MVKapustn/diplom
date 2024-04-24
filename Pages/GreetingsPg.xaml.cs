using DiplomKapustinMaximISP_41.Classes;
using System.Windows;
using System.Windows.Controls;

namespace DiplomKapustinMaximISP_41.Pages
{
    public partial class GreetingsPg : Page
    {
        public GreetingsPg()
        {
            InitializeComponent();
        }
        private void Start_Click(object sender, System.Windows.RoutedEventArgs e)
        {           
            Helper.Navigate("TestChoosingPg");            
        }

        private void AboutProgram_CLick(object sender, System.Windows.RoutedEventArgs e)
        {
            string message = "Программа \"Вставьте текст\" выполнена студентом группы ИСП-41 Капустиным Максимом Викторовичем в рамках выпускной квалификационной работы.";
            _ = MessageBox.Show(message, "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Helper.MainWindow.Close();
        }
    }
}
