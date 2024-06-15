using AdditionalLibrary.Classes;
using System.Windows.Controls;

namespace DiplomKapustinMaximISP_41.Pages.BaseTestPgsMed
{    
    public partial class BaseTestPgMed1 : Page
    {
        public BaseTestPgMed1()
        {
            InitializeComponent();
        }
        private void StartTest_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            PagesHelper.GetTo("BaseTestPgsMed/BaseTestPgMed2");
        }
    }
}
