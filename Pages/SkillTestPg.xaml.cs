using DiplomKapustinMaximISP_41.Classes;
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
            if ((bool)Low.IsChecked)
            {
                Helper.SkillLevel = Helper.Skill.Low;
            }
            else if ((bool)Med.IsChecked)
            {
                Helper.SkillLevel = Helper.Skill.Medium;
            }
            else if ((bool)High.IsChecked)
            {
                Helper.SkillLevel = Helper.Skill.High;
            }
            Helper.Navigate("BaseCoursePg");
        }
    }
}
