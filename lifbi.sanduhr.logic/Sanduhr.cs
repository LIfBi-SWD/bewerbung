using System;

namespace lifbi.sanduhr.logic
{
    public class Sanduhr
    {
        public string Print(int width){
            if(width < 3){
                throw new ArgumentOutOfRangeException("Parameter less than 3");
            } else {
                string sResult = "";
                /*setting the amount of rows. if the width is odd we need as much rows as it is wide, an even width requires one row less than width*/
                int iRows = (width % 2 == 1 ? width : width-1);
                /*because the middle gets set by the if part we have one iteration less in else so we need to set off the missing run
                by skipping one run if width is odd or two runs if width is even*/
                int iSkip = (width % 2 == 1 ? 1 : 2);
                //first for counts the rows
                for(int x = 0; x < iRows; x++){
                    //second for counts the columns
                    for(int y = 0; y < width; y++){
                        //checks if we reached the middle of the rows
                        if(x < iRows/2){
                            /*with every row we need one more space at beginning and end
                            only draw a asterisk when column is greater or equal the row and smaller than width-current row*/
                            sResult += (y >= x && y < width-x ? "*" : " ");
                            //check for the next iteration, break when the last asterisk of this row is drawn
                            if(y+1 >= width-x){ break; }
                        } else {
                            /*with every row we need one space less at beginning and end
                            only draw a asterisk when column is greater or equal the max width-current row + offset
                            and column is smaller than current row+offset*/
                            sResult += (y >= width-(x+iSkip) && y < (x+iSkip) ? "*" : " ");
                            //check for the next iteration, break when the last asterisk of this row is drawn
                            if(y+1 >= (x+iSkip)){ break; }
                        }
                    }
                    //end of row, skip for last row
                    if(x+1 < iRows){
                        sResult += Environment.NewLine;
                    }
                }
                return sResult;
            }
        }
    }
}
