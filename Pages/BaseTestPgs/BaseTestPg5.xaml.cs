using AdditionalLibrary.Classes;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace DiplomKapustinMaximISP_41.Pages.BaseTestPgs
{
    public partial class BaseTestPg5 : Page
    {
        public BaseTestPg5()
        {
            InitializeComponent();
            progressBar.Value = BaseTestHelper.CalculateProgressBarStatus(PagesHelper.Skill.Low);
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            bool isAnyPressed = falseRB1.IsChecked.Value || trueRB1.IsChecked.Value;
            if (!isAnyPressed)
            {
                CustomMessageBoxWindow.Show(owner: PagesHelper.MainWindow, message: "Сперва Вам нужно ответить!", title: "Ошибка!");
                return;
            }
            //Debug.WriteLine(trueRB1.IsChecked.Value);
            BaseTestHelper.SaveAnswer(PagesHelper.Skill.Low, 4, trueRB1.IsChecked.Value);
            PagesHelper.GetTo("BaseTestPgs/BaseTestPg6");
        }
    }
}
