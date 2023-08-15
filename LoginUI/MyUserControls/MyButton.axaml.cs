using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace LoginUI.MyUserControls;

public partial class MyButton : UserControl
{
    public string Text { get; set; } = "";
    public MyButton()
    {
        InitializeComponent();
    }
}