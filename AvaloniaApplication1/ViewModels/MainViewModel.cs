using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApplication1.ViewModels;

public partial class MainViewModel : ViewModelBase
{ 
    [ObservableProperty] public partial string Benvenuto { get; set; } = "Benvenuto";
   
    private bool logged;
    
    [ObservableProperty]  public partial string Name { get; set; } = "";
    public string StatusLogin => logged ? "Logout" : "Login";
    

    [RelayCommand]
    public void Login()
    {
        logged = !logged;
        Benvenuto = logged ? $"Benvenuto/a {Name}" : $"Arrivederci {Name}";
        OnPropertyChanged(nameof(StatusLogin));
    }
}