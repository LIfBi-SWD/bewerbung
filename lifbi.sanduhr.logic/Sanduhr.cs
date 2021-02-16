using System;
using System.Text;

namespace lifbi.sanduhr.logic
{
    public class Sanduhr
    {
        public string Print(int width)
        {
            // validate input parameter
            if (width < 3)
            {
                throw new ArgumentOutOfRangeException("Minimum width of an hourglass is 3");
            }

            // a stringbuilder is used to capture each iterative layer of the hourglass
            StringBuilder stringBuilder = new StringBuilder();

            int currentWidth = width; // this stores the current layer width while building the hourglass
            bool pastMidpoint = false; // the hourglass is built from top to bottom, this stores whether the midpoint was passed

            while (true)
            {
                // create a representation of the current layer and add it to the stringbuilder
                stringBuilder.Append(LayerByWidth(currentWidth, width));
                
                // return the result when the bottom layer is reached,
                if ((currentWidth == width) && pastMidpoint)
                {
                    return stringBuilder.ToString();
                // add a trailing newline otherwise
                } else {
                    stringBuilder.Append(Environment.NewLine);
                }

                // if the current diameter is 1 or 2 the midpoint is reached
                if (currentWidth <= 2)
                {
                    pastMidpoint = true;
                }

                // update width for the next iteration
                currentWidth = CalculateNextLayer(currentWidth, pastMidpoint);
            }
        }

        private string LayerByWidth(int width, int maxWidth)
        {
            // generate a string representing the hourglass layer at a certain diameter
            string padding = new string(' ', (maxWidth - width) / 2); // this creates padding to properly align the hourglass
            string stars = new string ('*', width);

            return padding + stars;
        }

        private int CalculateNextLayer(int currentWidth, bool pastMidpoint)
        {
            // grow or shrink by 2 depending on the current direction
           if (pastMidpoint)
           {
               return currentWidth + 2;
           } else {
               return currentWidth - 2;
           }
        }
    }
}
