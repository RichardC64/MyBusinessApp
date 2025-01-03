using CommunityToolkit.Mvvm.ComponentModel;

namespace MyBusinessViewModels;

public partial class GridPersonViewModel : ObservableObject
{
    [ObservableProperty] public partial string? Name
    {
        get;
        set;
    }
   

    [ObservableProperty]
    public partial string? LastName
    {
        get;
        set;
    }

    partial void OnLastNameChanged(string? value)
    {
        //....
    }

    [ObservableProperty]
    public partial int Age
    {
        get;
        set;
    }
}