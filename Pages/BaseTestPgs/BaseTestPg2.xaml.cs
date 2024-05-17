using AdditionalLibrary.Classes;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DiplomKapustinMaximISP_41.Pages.BaseTestPgs
{
    public partial class BaseTestPg2 : Page
    {
        public BaseTestPg2()
        {
            InitializeComponent();
        }       

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            bool isAnyPressed = falseRB1.IsChecked.Value || falseRB2.IsChecked.Value || trueRB1.IsChecked.Value;
            if (!isAnyPressed)
            {
                _ = MessageBox.Show("Сперва Вам нужно ответить!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            Debug.WriteLine(trueRB1.IsChecked.Value);
            BaseTestHelper.SaveAnswer(PagesHelper.Skill.Low, 1, trueRB1.IsChecked.Value);
            PagesHelper.GetTo("BaseTestPgs/BaseTestPg3");
        }
    }
}
