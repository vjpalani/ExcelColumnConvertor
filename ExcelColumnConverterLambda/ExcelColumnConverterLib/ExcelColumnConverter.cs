using System;

namespace ExcelColumnConverterLib
{
    public class ExcelColumnConverter
    {
        public static int ColumnLetterToNumber(string columnLetter)
        {
            int result = 0;
            foreach (char c in columnLetter.ToUpper())
            {
                result = result * 26 + (c - 'A' + 1);
            }
            return result;
        }

        public static string ColumnNumberToLetter(int columnNumber)
        {
            string result = "";
            while (columnNumber > 0)
            {
                int remainder = (columnNumber - 1) % 26;
                result = (char)('A' + remainder) + result;
                columnNumber = (columnNumber - 1) / 26;
            }
            return result;
        }
    }
}
