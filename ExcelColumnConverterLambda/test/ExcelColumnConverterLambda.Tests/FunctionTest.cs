using Xunit;
using ExcelColumnConverterLib;

public class ExcelColumnConverterTests
{
    [Theory]
    [InlineData("A", 1)]
    [InlineData("B", 2)]
    [InlineData("Z", 26)]
    [InlineData("AA", 27)]
    [InlineData("AB", 28)]
    [InlineData("ZY", 701)]
    public void TestColumnLetterToNumber(string columnLetter, int expected)
    {
        int result = ExcelColumnConverter.ColumnLetterToNumber(columnLetter);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, "A")]
    [InlineData(2, "B")]
    [InlineData(26, "Z")]
    [InlineData(27, "AA")]
    [InlineData(28, "AB")]
    [InlineData(701, "ZY")]
    public void TestColumnNumberToLetter(int columnNumber, string expected)
    {
        string result = ExcelColumnConverter.ColumnNumberToLetter(columnNumber);
        Assert.Equal(expected, result);
    }
}