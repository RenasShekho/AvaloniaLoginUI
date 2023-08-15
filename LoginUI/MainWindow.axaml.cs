using Avalonia.Controls;
using LoginUI.WinUserControl;

namespace LoginUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ContentArea.Navigate(new LoginUserControl());
        }
    }
}