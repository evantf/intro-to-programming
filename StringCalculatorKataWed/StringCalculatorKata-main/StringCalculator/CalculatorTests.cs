

namespace StringCalculator;
public class CalculatorTests
{
    private static readonly Calculator _calculator = new();

    [Fact]
    public void EmptyStringReturnsZero()
    {
        string inputTest = string.Empty;
        _calculator.Add(inputTest);

        Assert.Equal(0, _calculator.ReturnResult());
    }

    [Fact]
    public void SingleIntReturnsSelf()
    {
        _calculator.Add("2");

        Assert.Equal(2, _calculator.ReturnResult());
    }

    [Fact]
    public void DoubleIntReturnsSum()
    {
        _calculator.Add("1,2");

        Assert.Equal(3, _calculator.ReturnResult());
    }

    [Fact]
    public void HighDigitIntsCompute()
    {
        _calculator.Add("42,53");

        Assert.Equal(95, _calculator.ReturnResult());
    }

    [Fact]
    public void ArbitraryStringLengthReturnsSum()
    {
        _calculator.Add("1,2,3,4,5");

        Assert.Equal(15, _calculator.ReturnResult());
    }

    [Fact]
    public void MultipleDelimitersReturnSum()
    {
        _calculator.Add("1\n2\n3");

        Assert.Equal(6, _calculator.ReturnResult());
    }

    [Fact]
    public void NegativeNumbersAreNotAllowed()
    {
        Assert.ThrowsAny<ArgumentException>(() => _calculator.Add("1.2-3"));
    }
}
