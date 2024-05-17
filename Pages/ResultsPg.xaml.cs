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
                progressBar.Foreground = Brushes.Red;
            }
            else if (progressBar.Value > 50 && progressBar.Value < 70)
            {
                progressBar.Foreground = Brushes.Orange;
            }
            else if (progressBar.Value > 70 && progressBar.Value < 85)
            {
                progressBar.Foreground = Brushes.Yellow;
            }
            else if (progressBar.Value > 85)
            {
                progressBar.Foreground = Brushes.Green;
            }
        }

        private void StartTest_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            PagesHelper.GetTo("GreetingsPg");
        }
    }
}
