using System;

namespace lifbi.sanduhr.logic
{
    public class Sanduhr
    {
        // void Main()
        // {
        //     Console.WriteLine(Print(3)); // example usage
        //     Console.WriteLine(Print(4)); // example usage
        //     Console.WriteLine(Print(5)); // example usage
        //     Console.WriteLine(Print(99)); // example usage
        // }

        public string Print(int width)
        {
            if (width < 3)
            {
                throw new ArgumentOutOfRangeException("width", "Width must be greater than or equal to 3.");
            }

            int halfWidth = (width + 1) / 2;
            string result = "";

            for (int i = 1; i <= halfWidth; i++)
            {
                result += GetSpaces(i - 1);
                result += GetStars(width - 2 * (i - 1));
                result += Environment.NewLine;
            }

            for (int j = halfWidth - 1; j >= 1; j--)
            {               
                result += GetSpaces(j - 1);
                result += GetStars(width - 2 * (j - 1));
                if (j > 1)
                {
                    result += Environment.NewLine;
                }             
            }

            return result;
        }

        private static string GetSpaces(int count)
        {
            return new String(' ', count);
        }

        private static string GetStars(int count)
        {
            return new String('*', count);
        }
    }
}
