using ClassLibrary;

namespace TestProject;

public class UnitTest1
{
    [Fact(DisplayName = "numero de entrada menor 3 devulve 0")]
    public void Test1()
    {
        int[] A = { 0 };
        Solution solution = new Solution();
        Assert.Equal(0, solution.solution(A));
    }

    [Fact(DisplayName = "si es un pico valido devulve 1")]
    public void Test2()
    {
        int[] A = { 1, 5, 3 };
        Solution solution = new Solution();
        Assert.Equal(1, solution.solution(A));
    }

    [Theory(DisplayName = "validaciones donde se devuelve 0")]
    [InlineData(new[] { 0 })]
    [InlineData(new[] { 1 })]
    [InlineData(new[] { 1, 2, 3 })]
    public void Test3(int[] A)
    {
        Solution solution = new Solution();
        Assert.Equal(0, solution.solution(A));
    }


    [Fact(DisplayName = "cuando ingresa una linea sin picos devuelve 0")]
    public void Test4()
    {
        int[] A = { 1, 2, 3, 4 };
        Solution solution = new Solution();
        Assert.Equal(0, solution.solution(A));
    }

  
    [Fact(DisplayName = "cuando ingresa picos validos")]
    public void Test5()
    {
        int[] A = { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2  };
        Solution solution = new Solution();
        Assert.Equal(3, solution.solution(A));
    }

}