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
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            bool isAnyPressed = falseRB1.IsChecked.Value || trueRB1.IsChecked.Value;
            if (!isAnyPressed)
            {
                _ = MessageBox.Show("Сперва Вам нужно ответить!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            Debug.WriteLine(trueRB1.IsChecked.Value);

            BaseTestHelper.SaveAnswer(PagesHelper.Skill.Low, 4, trueRB1.IsChecked.Value);
            PagesHelper.GetTo("BaseTestPgs/BaseTestPg6");
        }
    }
}
