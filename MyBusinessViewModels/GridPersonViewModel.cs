using CommunityToolkit.Mvvm.ComponentModel;

namespace MyBusinessViewModels;

public partial class GridPersonViewModel : ObservableObject
{
    [ObservableProperty] public partial string? FirstName { get; set; }
    [ObservableProperty] public partial string? LastName { get; set; }
    [ObservableProperty] public partial int Age { get; set; }
}