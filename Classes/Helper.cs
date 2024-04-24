namespace DiplomKapustinMaximISP_41.Classes
{
    public class Helper
    {
        public enum Skill
        {
            Low,
            Medium,
            High
        }        
        public static MainWindow MainWindow { get; set; }
        public static void Navigate(string pageName)
        {
            MainWindow.mainFrame.Navigate(new Uri($"Pages/{pageName}.xaml", UriKind.Relative));
        }
        public static Skill SkillLevel { get; set; }
    }
}
