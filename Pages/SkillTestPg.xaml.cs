using AdditionalLibrary.Classes;
using System.Windows;
using System.Windows.Controls;

namespace DiplomKapustinMaximISP_41.Pages
{
    public partial class SkillTestPg : Page
    {
        public SkillTestPg()
        {
            InitializeComponent();
        }
        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            if (Low.IsChecked.HasValue && Low.IsChecked.Value)
            {
                PagesHelper.SkillLevel = PagesHelper.Skill.Low;
            }
            else if (Med.IsChecked.HasValue && Med.IsChecked.Value)
            {
                PagesHelper.SkillLevel = PagesHelper.Skill.Medium;
            }
            else if (High.IsChecked.HasValue && High.IsChecked.Value)
            {
                PagesHelper.SkillLevel = PagesHelper.Skill.High;
            }
            PagesHelper.GetTo("BaseCoursePg");            
        }
    }
}
