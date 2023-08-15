using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using LoginUI.Model;

namespace LoginUI.WinUserControl;

public partial class CreateUser : UserControl
{
    CreateUserModel CUM;


    public CreateUser()
    {
        InitializeComponent();
        DataContext = CUM;
    }
}