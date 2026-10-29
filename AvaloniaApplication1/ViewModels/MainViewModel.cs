using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApplication1.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public string Benvenuto { get; set; } = "Benvenuto";
    private bool logged;
    [ObservableProperty] public partial string Name { get; set; } = "";
    public string StatusLogin => logged ? "Logout" : "Login";
    

    [RelayCommand]
    private void Login()
    {
        logged = !logged;
        Benvenuto = logged ? $"Benvenuto/a {Name}" : $"Arrivederci {Name}";
        OnPropertyChanged(nameof(Benvenuto));
    }
}