using AdditionalLibrary.Classes;
using System.Windows;
using System.Windows.Navigation;
namespace DiplomKapustinMaximISP_41
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();          
            PagesHelper.MWFrame = mainFrame;
            PagesHelper.MainWindow = this;
            mainFrame.Navigate(new Uri("Pages/GreetingsPg.xaml", UriKind.Relative));
        }
    }
}