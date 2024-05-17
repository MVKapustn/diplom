using AdditionalLibrary.Classes;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace DiplomKapustinMaximISP_41.Pages.BaseTestPgs
{    
    public partial class BaseTestPg6 : Page
    {
        public BaseTestPg6()
        {
            InitializeComponent();
        }

        private void Continue_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            bool isAnyPressed = falseRB1.IsChecked.Value || falseRB2.IsChecked.Value || trueRB1.IsChecked.Value;
            if (!isAnyPressed)
            {
                _ = MessageBox.Show("Сперва Вам нужно ответить!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            Debug.WriteLine(trueRB1.IsChecked.Value);
            BaseTestHelper.SaveAnswer(PagesHelper.Skill.Low, 5, trueRB1.IsChecked.Value);
            PagesHelper.GetTo("ResultsPg");
        }
    }
}
