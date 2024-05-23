using AdditionalLibrary.Classes;
using System.Windows.Controls;

namespace DiplomKapustinMaximISP_41.Pages
{
    public partial class BaseCoursePg : Page
    {
        public BaseCoursePg()
        {
            InitializeComponent();
        }

        private void Page_Initialized(object sender, EventArgs e)
        {
            switch (PagesHelper.SkillLevel)
            {
                case PagesHelper.Skill.Low:
                    tabControlLow.Visibility = System.Windows.Visibility.Visible;
                    tabControlLow.IsEnabled = true;
                    break;
                case PagesHelper.Skill.Medium:
                    tabControlMed.Visibility = System.Windows.Visibility.Visible;
                    tabControlMed.IsEnabled = true;
                    break;
                case PagesHelper.Skill.High:
                    tabControlHigh.Visibility = System.Windows.Visibility.Visible;
                    tabControlHigh.IsEnabled = true;
                    break;
            }
        }   
        private void Continue_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            PagesHelper.GetTo("TestChoosingPg");
        }
    }
}
