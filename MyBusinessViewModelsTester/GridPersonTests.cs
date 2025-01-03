using MyBusinessViewModels;

namespace MyBusinessViewModelsTester;

public class GridPersonTests
{
    [Fact]
    public void Test1()
    {
        var gridP = new GridPersonViewModel();

        gridP.Name = "John";

        gridP.LastName = "Doe";
    }
}
