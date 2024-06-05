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
            string message = "Программа \"Изучение языка C++\" выполнена студентом группы ИСП-41 Капустиным Максимом Викторовичем в рамках дипломного проекта.";
            CustomMessageBoxWindow.Show(owner: PagesHelper.MainWindow, message: message, title: "О программе", 12);
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            PagesHelper.MainWindow?.Close();
        }
    }
}
