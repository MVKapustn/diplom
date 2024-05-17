using AdditionalLibrary.Classes;
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
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            PagesHelper.GetTo("SkillTestPg");
        }
        private void AboutProgram_CLick(object sender, RoutedEventArgs e)
        {
            string message = "Программа \"Изучение языка C++\" выполнена студентом группы ИСП-41 Капустиным Максимом Викторовичем в рамках преддипломного проекта.";
            _ = MessageBox.Show(message, "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            PagesHelper.MainWindow?.Close();
        }
    }
}
