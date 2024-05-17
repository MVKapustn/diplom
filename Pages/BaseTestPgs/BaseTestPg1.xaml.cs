using AdditionalLibrary.Classes;
using System.Windows.Controls;

namespace DiplomKapustinMaximISP_41.Pages
{
    public partial class BaseTestPg : Page
    {
        public BaseTestPg()
        {
            InitializeComponent();
        }

        private void StartTest_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            PagesHelper.GetTo("BaseTestPgs/BaseTestPg2");
        }
    }
}
