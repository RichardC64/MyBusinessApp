using MyBusinessViewModels;

namespace MyBusinessViewModelsTester;

public class GridPersonTests
{
    [Fact]
    public void Test1()
    {
        var gridPerson = new GridPersonViewModel();

        gridPerson.FirstName = "John";
        gridPerson.LastName = "Doe";
    }

    [Fact]
    public void Test2()
    {
        var person = new Person
        {
            FirstName = "Richard",
            LastName = "Clark",
            Age = 60
        };

        var personVm = new PersonViewModel(person);

        Assert.Equal(person.FirstName, personVm.FirstName);
        Assert.Equal(person.LastName, personVm.LastName);
        Assert.Equal(person.Age, personVm.Age);

        personVm.FirstName = "John";
        personVm.LastName = "Doe";
        personVm.Age = 30;

        Assert.Equal("John", personVm.Person.FirstName);
        Assert.Equal("Doe", personVm.Person.LastName);
        Assert.Equal(30, personVm.Person.Age);
    }
}
