using DiplomKapustinMaximISP_41.Classes;
using System.Windows;

namespace DiplomKapustinMaximISP_41
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Helper.MainWindow = this;

            mainFrame.Navigate(new Uri("Pages/GreetingsPg.xaml", UriKind.Relative));

            /*// Возврат на предыдущую страницу
            if (mainFrame.CanGoBack)
            {
                mainFrame.GoBack();
            }

            // Переход на следующую страницу в истории переходов
            if (mainFrame.CanGoForward)
            {
                mainFrame.GoForward();
            }*/
        }
    }
}