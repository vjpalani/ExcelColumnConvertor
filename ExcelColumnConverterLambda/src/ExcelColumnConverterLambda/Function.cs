// Function.cs
using Amazon.Lambda.Core;
using Amazon.Lambda.Serialization.SystemTextJson;
using ExcelColumnConverterLib; // Add this line


[assembly: LambdaSerializer(typeof(DefaultLambdaJsonSerializer))]

public class Function
{
    public string ColumnLetterToNumber(string columnLetter, ILambdaContext context)
    {
        int result = ExcelColumnConverter.ColumnLetterToNumbecd..r(columnLetter);
        return result.ToString();
    }

    public string ColumnNumberToLetter(int columnNumber, ILambdaContext context)
    {
        string result = ExcelColumnConverter.ColumnNumberToLetter(columnNumber);
        return result;
    }
}
