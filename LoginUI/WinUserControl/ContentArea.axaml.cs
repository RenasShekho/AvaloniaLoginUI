using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace LoginUI.WinUserControl;

public partial class ContentArea : UserControl
{
        static ContentArea? Instance;
    public ContentArea()
    {
        InitializeComponent();
        if(Instance == null) { Instance = this; }
    }
    public static void Navigate(UserControl control)
    {
        if(control == null) { return; }
        Instance.Content=control;

    }
}