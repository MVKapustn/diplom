using AdditionalLibrary.Classes;
using System.Windows.Controls;

namespace DiplomKapustinMaximISP_41.Pages
{
    public partial class TestChoosingPg : Page
    {
        public TestChoosingPg()
        {
            InitializeComponent();
        }

        private void BaseCourse_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            PagesHelper.GetTo("BaseTestPgs/BaseTestPg1");
        }
    }
}
