using CommunityToolkit.Mvvm.ComponentModel;

namespace MyBusinessViewModels;

public class PersonViewModel(Person person) : ObservableObject
{
    public Person Person => person;

    // SetProperty avec un stateless callback
    public string? FirstName
    {
        get => person.FirstName;
        set => SetProperty(person.FirstName, value, person, (model, name) => model.FirstName = name);
    }

    // SetProperty avec un callback
    public string? LastName
    {
        get => person.LastName;
        set => SetProperty(person.LastName, value, lastName => person.LastName = lastName);
    }

    // SetProperty avec un stateless callback et une validation
    public int Age
    {
        get => person.Age;
        set => SetProperty(person.Age,value, person, (model, age) =>
        {
            if (age < 0) age = 0;
            if (age > 150) age = 150;
            model.Age = age;
        });
    }
}