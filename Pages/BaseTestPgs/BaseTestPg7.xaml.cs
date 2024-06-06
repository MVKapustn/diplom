using AdditionalLibrary.Classes;
using System.Windows;
using System.Windows.Controls;

namespace DiplomKapustinMaximISP_41.Pages.BaseTestPgs
{    
    public partial class BaseTestPg7 : Page
    {
        public BaseTestPg7()
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
                return;
            }
            //Debug.WriteLine(trueRB1.IsChecked.Value);
            BaseTestHelper.SaveAnswer(PagesHelper.Skill.Low, 6, trueRB1.IsChecked.Value);
            PagesHelper.GetTo("ResultsPg"/*"BaseTestPgs/BaseTestPg8"*/);
        }
    }
}
