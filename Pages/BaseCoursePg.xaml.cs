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

                    tabControlMed.Visibility = System.Windows.Visibility.Hidden;
                    tabControlMed.IsEnabled = false;

                    tabControlHigh.Visibility = System.Windows.Visibility.Hidden;
                    tabControlHigh.IsEnabled = false;
                    break;
                case PagesHelper.Skill.Medium:
                    tabControlLow.Visibility = System.Windows.Visibility.Hidden;
                    tabControlLow.IsEnabled = false;

                    tabControlMed.Visibility = System.Windows.Visibility.Visible;
                    tabControlMed.IsEnabled = true;

                    tabControlHigh.Visibility = System.Windows.Visibility.Hidden;
                    tabControlHigh.IsEnabled = false;
                    break;
                case PagesHelper.Skill.High:
                    tabControlLow.Visibility = System.Windows.Visibility.Hidden;
                    tabControlLow.IsEnabled = true;

                    tabControlMed.Visibility = System.Windows.Visibility.Hidden;
                    tabControlMed.IsEnabled = false;

                    tabControlHigh.Visibility = System.Windows.Visibility.Visible;
                    tabControlHigh.IsEnabled = true;
                    break;
            }
        }
        private void Continue_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            switch (PagesHelper.SkillLevel)
            {
                case PagesHelper.Skill.Low:
                    PagesHelper.GetTo("BaseTestPgs/BaseTestPg1");
                    break;
                case PagesHelper.Skill.Medium:
                    PagesHelper.GetTo("BaseTestPgsMed/BaseTestPgMed1");
                    break;
                case PagesHelper.Skill.High:
                    PagesHelper.GetTo("BaseTestPgsHigh/BaseTestPgHigh1");
                    break;
            }
        }
    }
}
