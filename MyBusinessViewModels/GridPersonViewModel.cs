using CommunityToolkit.Mvvm.ComponentModel;

namespace MyBusinessViewModels;

public partial class GridPersonViewModel : ObservableObject
{
    private string? _firstName;

    public string? FirstName
    {
        get => _firstName;
        set => SetProperty(ref _firstName, value);
    }
    [ObservableProperty] public partial string? Name { get; set; }


    [ObservableProperty] public partial string? LastName { get; set; }

    partial void OnLastNameChanged(string? value)
    {
        //....
    }

    [ObservableProperty] public partial int Age { get; set; }
}