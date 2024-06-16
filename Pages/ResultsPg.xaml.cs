using AdditionalLibrary.Classes;
using System.Collections;
using System.IO;
using System.Text.Json;
using System.Windows.Controls;
using System.Windows.Media;

namespace DiplomKapustinMaximISP_41.Pages
{
    public partial class ResultsPg : Page
    {
        private string usersResultsFileName;
        private List<User> usersResultsList;

        public ResultsPg()
        {
            InitializeComponent();

            var results = BaseTestHelper.GetResults(PagesHelper.SkillLevel);

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

            switch (PagesHelper.SkillLevel)
            {
                case PagesHelper.Skill.Low:
                    usersResultsFileName = "usersLowResults.txt";
                    PagesHelper.CurrentUser.LowTestResult = (uint)results.Item1;
                    break;
                case PagesHelper.Skill.Medium:
                    usersResultsFileName = "usersMedResults.txt";
                    PagesHelper.CurrentUser.MedTestResult = (uint)results.Item1;
                    break;
                case PagesHelper.Skill.High:
                    usersResultsFileName = "usersHighResults.txt";
                    PagesHelper.CurrentUser.HighTestResult = (uint)results.Item1;
                    break;
                default:
                    break;
            }

            if (!File.Exists(usersResultsFileName))
            {
                File.Create(usersResultsFileName);
            }

            string fileContent = File.ReadAllText(usersResultsFileName);

            if (fileContent.Length == 0)
            {
                usersResultsList = [];
            }
            else
            {
                usersResultsList = JsonSerializer.Deserialize<List<User>>(fileContent);
            }

            User currentUser = usersResultsList.Find(x => x.Login == PagesHelper.CurrentUser.Login);

            if (currentUser is null)
            {                
                usersResultsList.Add(PagesHelper.CurrentUser);
            }
            else
            {
                currentUser = PagesHelper.CurrentUser;
            }
            ArrayList arrayList = new ArrayList();
            switch (PagesHelper.SkillLevel)
            {
                case PagesHelper.Skill.Low:
                    usersResultsList = [.. usersResultsList.OrderBy(x => x.LowTestResult).Reverse()];
                    for (int i = 0; i < usersResultsList.Count; i++)
                    {
                        arrayList.Add(new { Топ = i + 1, Имя_пользователя = usersResultsList[i].Login, Баллы = usersResultsList[i].LowTestResult });
                    }                    
                    break;
                case PagesHelper.Skill.Medium:
                    usersResultsList = [.. usersResultsList.OrderBy(x => x.MedTestResult).Reverse()];
                    for (int i = 0; i < usersResultsList.Count; i++)
                    {
                        arrayList.Add(new { Топ = i + 1, Имя_пользователя = usersResultsList[i].Login, Баллы = usersResultsList[i].MedTestResult });
                    }
                    break;
                case PagesHelper.Skill.High:
                    usersResultsList = [.. usersResultsList.OrderBy(x => x.HighTestResult).Reverse()];
                    for (int i = 0; i < usersResultsList.Count; i++)
                    {
                        arrayList.Add(new { Топ = i + 1, Имя_пользователя = usersResultsList[i].Login, Баллы = usersResultsList[i].MedTestResult });
                    };
                    break;
                default:
                    break;
            }
            File.WriteAllText(usersResultsFileName, JsonSerializer.Serialize(usersResultsList));
            DG.ItemsSource = null;
            DG.ItemsSource = arrayList;
        }
        private void StartTest_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            PagesHelper.GetTo("GreetingsPg");
        }
    }
}
