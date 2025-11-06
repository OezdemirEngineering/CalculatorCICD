namespace Calculator.Tests;

public class CalulatorTests
{
    [Fact]
    public void Add_TwoIntegers_PositiveSum()
    {
        // Arrange
        var calculator = new Calculator();
        var a = 5;
        var b = 10;
        var expected = 15;

        // Act
        var result = calculator.Add(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Subtract_TwoIntegers_CorrectDifference()
    {
        // Arrange
        var calculator = new Calculator();
        var a = 10;
        var b = 5;
        var expected = 5;

        // Act
        var result = calculator.Subtract(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Multiply_TwoIntegers_CorrectProduct()
    {
        // Arrange
        var calculator = new Calculator();
        var a = 3;
        var b = 4;
        var expected = 12;

        // Act
        var result = calculator.Multiply(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Divide_TwoIntegers_CorrectQuotient()
    {
        // Arrange
        var calculator = new Calculator();
        var a = 20;
        var b = 5;
        var expected = 4;

        // Act
        var result = calculator.Divide(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        var calculator = new Calculator();
        var a = 10;
        var b = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b));
    }
}