using System.Windows;
using System.Windows.Controls;

namespace AdditionalLibrary.Classes
{
    public class PagesHelper
    {
        private static Skill skillLevel;

        public enum Skill
        {
            Low,
            Medium,
            High
        }
        public static Frame? MWFrame { get; set; }
        public static Window? MainWindow { get; set; }
        public static void GetTo(string pageName)
        {
            MWFrame?.Navigate(new Uri($"Pages/{pageName}.xaml", UriKind.Relative));
        }
        public static Skill SkillLevel { get => skillLevel; set => skillLevel = value; }
    }
}
