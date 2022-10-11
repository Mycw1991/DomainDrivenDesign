using Application.DTO;

namespace tests.Application;

public class UnitTest1
{
    [Fact]
    public void TestGetTodoList()
    {
        string RandomTitle = "randomString";
        Assert.Equal(RandomTitle, new TodoListRequestDTO { Title = RandomTitle}.GetTodoList().Title);
    }
}