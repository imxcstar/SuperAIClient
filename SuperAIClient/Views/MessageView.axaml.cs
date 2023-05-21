using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace SuperAIClient.Views;

public partial class MessageView : UserControl
{
    public MessageView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}