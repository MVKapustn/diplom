using AdditionalLibrary.Classes;
using System.Windows;
using System.Windows.Controls;

namespace DiplomKapustinMaximISP_41.Pages.BaseTestPgsHigh
{
    public partial class BaseTestPgHigh11 : Page
    {
        public BaseTestPgHigh11()
        {
            InitializeComponent();
            progressBar.Value = BaseTestHelper.CalculateProgressBarStatus(PagesHelper.SkillLevel);
        }
        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            bool isAnyPressed = falseRB1.IsChecked.Value || falseRB2.IsChecked.Value || trueRB1.IsChecked.Value;
            if (!isAnyPressed)
            {
                CustomMessageBoxWindow.Show(owner: PagesHelper.MainWindow, message: "Сперва Вам нужно ответить!", title: "Ошибка!");
                return;
            }
            CustomMessageBoxWindow.Show(owner: PagesHelper.MainWindow, message: "Благодарим за отзыв и использование нашего приложения!", title: "Спасибо!");
            BaseTestHelper.SaveAnswer(PagesHelper.SkillLevel, 10, true);
            PagesHelper.GetTo("ResultsPg");
        }
    }
}
