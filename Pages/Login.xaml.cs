using AdditionalLibrary.Classes;
using System.IO;
using System.Text.Json;
using System.Windows;

namespace DiplomKapustinMaximISP_41.Pages
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            if (!File.Exists(usersFileName))
            {
                File.Create(usersFileName);
            }

            string fileContent = File.ReadAllText(usersFileName);

            if (fileContent.Length == 0)
            {
                users = [];
            }
            else
            {
                users = JsonSerializer.Deserialize<List<User>>(fileContent);
            }
        }
        private readonly string usersFileName = "Users.txt";
        private List<User>? users;

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            User currentUser = users.Find(x => x.Login == loginTB.Text && x.Password == passwordTB.Text);

            if (currentUser is null)
            {
                CustomMessageBoxWindow customMBox = new("Неверный логин или пароль!", "Ошибка", 18);
                customMBox.Show();
                return;
            }
            PagesHelper.CurrentUser = currentUser;

            MainWindow mainWindow = new();
            mainWindow.Show();

            CustomMessageBoxWindow customMessageBox = new("Вы успешно вошли!", "Ура", 18)
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            customMessageBox.Show();

            Close();
        }
        private void Singin_Click(object sender, RoutedEventArgs e)
        {
            User newUser = new User()
            {
                Login = loginTB.Text,
                Password = passwordTB.Text
            };

            if (users.Count() == 0)
            {
                newUser.Id = 1;
            }
            else
            {
                newUser.Id = users.Max(x => x.Id) + 1;
                if (users.Find(x => x.Login == newUser.Login) is not null)
                {
                    CustomMessageBoxWindow customMessageBox = new("Такой пользователь уже существует!", "Ошибка", 18);
                    customMessageBox.Show();
                    return;
                }
            }
            users.Add(newUser);
            File.WriteAllText(usersFileName, JsonSerializer.Serialize(users));
            CustomMessageBoxWindow cMBox = new("Вы успешно зарегистрировались!", "Ура", 18);
            cMBox.Show();
        }
    }
}
