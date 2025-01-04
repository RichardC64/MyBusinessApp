using CommunityToolkit.Mvvm.ComponentModel;

namespace MyBusinessViewModels;

public class PersonViewModel(Person person) : ObservableObject
{
    public Person Person => person;
    public string? FirstName
    {
        get => person.FirstName;
        set => SetProperty(person.FirstName, value, person, (model, name) => model.FirstName = name);
    }

    public string? LastName
    {
        get => person.LastName;
        set => SetProperty(person.LastName, value, person, (model, name) => model.LastName = name);
    }

    public int Age
    {
        get => person.Age;
        set => SetProperty(person.Age, value, person, (model, age) => model.Age = age);
    }
}