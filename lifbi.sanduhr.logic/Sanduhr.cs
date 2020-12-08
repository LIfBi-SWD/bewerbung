using System;
using System.Text;

namespace lifbi.sanduhr.logic
{
    public class Sanduhr
    {
        private const int minWidth = 3;
        private const int stepSize = 2;

        public string Print(int width){
            if(width < Sanduhr.minWidth) {
                throw new System.ArgumentOutOfRangeException(String.Format("Die übergebene Breite darf nicht kleiner als {0} sein.", Sanduhr.minWidth));
            }
            StringBuilder sb = new StringBuilder();
            int starsInMiddle = AppendTopToMiddle(width, sb);
            AppendBottom(width, starsInMiddle, sb);
            return sb.ToString();
        }

        private int AppendTopToMiddle(int width, StringBuilder sb){
            int stars = width;
            while(stars > Sanduhr.stepSize){
                sb.Append(CreateLine(width, stars, Environment.NewLine));
                stars -= Sanduhr.stepSize;
            }
            return stars;
        }

        private void AppendBottom(int width, int stars, StringBuilder sb){
            while(stars <= width - Sanduhr.stepSize){
                sb.Append(CreateLine(width, stars, Environment.NewLine));
                stars += Sanduhr.stepSize;
            }
            sb.Append(CreateLine(width, stars));
        }

        private string CreateLine(int width, int stars, string lineDelimiter){
            return new String(' ', Spaces(width, stars)) +  new String('*', stars) + lineDelimiter;
        }

        private string CreateLine(int width, int stars){
            return new String(' ', Spaces(width, stars)) +  new String('*', stars);
        }

        private int Spaces(int width, int stars){
            return (width - stars)/2;
        }

    }
}
