using System.Windows;

namespace DiplomKapustinMaximISP_41.Pages
{
    public partial class CustomMessageBoxWindow : Window
    {
        public CustomMessageBoxWindow(string message, string title, int fontSize)
        {
            InitializeComponent();
            MessageTextBlock.Text = message;
            MessageTextBlock.FontSize = fontSize;
            Title = title;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        public static void Show(Window owner, string message, string title = "Message", int fontSize = 18)
        {
            CustomMessageBoxWindow messageBox = new CustomMessageBoxWindow(message, title, fontSize)
            {
                Owner = owner,
                WindowStartupLocation = WindowStartupLocation.CenterOwner               
            };
            messageBox.ShowDialog();
        }
    }
}
