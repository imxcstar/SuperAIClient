using ReactiveUI;

namespace SuperAIClient.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private string _value = "Welcome to Avalonia!";

    public string Value
    {
        get => _value;
        set => this.RaiseAndSetIfChanged(ref _value, value);
    }

    public MessageViewModel test { get; set; } = new MessageViewModel();
}