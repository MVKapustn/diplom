using AdditionalLibrary.Classes;
using System.Windows;
using System.Windows.Controls;

namespace DiplomKapustinMaximISP_41.Pages.BaseTestPgs
{
    public partial class BaseTestPg2 : Page
    {
        public BaseTestPg2()
        {
            InitializeComponent();
            progressBar.Value = BaseTestHelper.CalculateProgressBarStatus(PagesHelper.Skill.Low);
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            bool isAnyPressed = falseRB1.IsChecked.Value || falseRB2.IsChecked.Value || trueRB1.IsChecked.Value;
            if (!isAnyPressed)
            {
                CustomMessageBoxWindow.Show(owner: PagesHelper.MainWindow, message: "Сперва Вам нужно ответить!", title: "Ошибка!");
                //_ = MessageBox.Show("Сперва Вам нужно ответить!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            //Debug.WriteLine(trueRB1.IsChecked.Value);
            BaseTestHelper.SaveAnswer(questionDifficult: PagesHelper.Skill.Low, questionNumber: 1, answer: trueRB1.IsChecked.Value);
            PagesHelper.GetTo("BaseTestPgs/BaseTestPg3");
        }
    }
}
