using AdditionalLibrary.Classes;
using System.Diagnostics;
using System.Windows.Controls;
using System.Windows.Media;

namespace DiplomKapustinMaximISP_41.Pages
{    
    public partial class ResultsPg : Page
    {
        public ResultsPg()
        {
            InitializeComponent();

            var results = BaseTestHelper.GetResults(PagesHelper.Skill.Low);

            ResultsTB.Text = $"Поздравляем! Вы набрали {results.Item1} баллов из {results.Item2} возможных!";            

            progressBar.Value = (double)results.Item1 / results.Item2 * 100;

            if (progressBar.Value < 50)
            {
                progressBar.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xEB, 0x53, 0x09)); ;
            }
            else if (progressBar.Value > 50 && progressBar.Value < 70)
            {
                progressBar.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xEB, 0x9C, 0x09)); ;
            }
            else if (progressBar.Value > 70 && progressBar.Value < 85)
            {
                progressBar.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xD6, 0xD9, 0x0D));
            }
            else if (progressBar.Value > 85)
            {
                progressBar.Foreground = new SolidColorBrush(Color.FromArgb(0xFF, 0xB2, 0xFF, 0x00));
            }
        }

        private void StartTest_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            PagesHelper.GetTo("GreetingsPg");
        }
    }
}
