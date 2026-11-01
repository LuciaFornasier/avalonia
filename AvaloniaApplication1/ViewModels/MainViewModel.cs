using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaApplication1.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _benvenuto = "Benvenuto";

    [ObservableProperty]
    private string _password = "";

    public List<string> Nomi { get; set; } = new() { "Alessandro", "Beatrice", "Carlo", "Diana", "Elena" };

    [ObservableProperty]
    private string? _nomeSelezionato;

    private bool _isLoggedIn = false;

    public string StatusLogin => _isLoggedIn ? "LOGOUT" : "LOGIN";

    [RelayCommand]
    public void Login()
    {
       
        _isLoggedIn = !_isLoggedIn;
        
        string nomeDaMostrare = NomeSelezionato ?? "";

        if (_isLoggedIn)
        {
            Benvenuto = $"Benvenuto/a {nomeDaMostrare}";
        }
        else
        {
          
            Benvenuto = "Arrivederci";
            Password = "";
            NomeSelezionato = null;
        }
        
        OnPropertyChanged(nameof(StatusLogin));
    }
}