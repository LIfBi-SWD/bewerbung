using System;

namespace lifbi.sanduhr.logic
{
    public class Sanduhr
    {
        public string Print(int width)
        {
            if (width == 1) throw new ArgumentOutOfRangeException();
            string res = "";
            int i;
            for (i = width; i > 0; i -= 2)
                res += RepeatedStarWithSpaces(i, (width - i) / 2) + Environment.NewLine;
            for (i += 4; i <= width; i += 2)
            {
                res += RepeatedStarWithSpaces(i, (width - i) / 2);
                if (i + 2 <= width) res += Environment.NewLine;
            }
            return res;
        }

        private string RepeatedStarWithSpaces(int width, int spaces)
        {
            string res = "";
            for (int i = 0; i < spaces; i++)
                res += " ";
            for (int i = 0; i < width; i++)
                res += "*";
            return res;
        }
    }
}
