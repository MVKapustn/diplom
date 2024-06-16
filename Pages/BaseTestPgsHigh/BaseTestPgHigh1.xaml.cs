using AdditionalLibrary.Classes;
using System.Windows.Controls;

namespace DiplomKapustinMaximISP_41.Pages.BaseTestPgsHigh
{
    public partial class BaseTestPgsHigh1 : Page
    {
        public BaseTestPgsHigh1()
        {
            InitializeComponent();
        }
        private void StartTest_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            PagesHelper.GetTo("BaseTestPgsHigh/BaseTestPgHigh2");
        }
    }
}
