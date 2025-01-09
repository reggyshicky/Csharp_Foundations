using System.Runtime.InteropServices;

namespace Codility_Dates
{
    public class Codility_Date
    {
        public string Format(DateTime date, DateTime current)
        {
            TimeSpan timeDifference = current - date;

            if (timeDifference.TotalDays >= 7)
            {
                return date.ToString("yyyy-MM-dd HH:mm");
            }
            else if (timeDifference.TotalDays >= 1)
            {
                int days = (int)timeDifference.TotalDays;
                return $"{days} day(s) ago";
            }
            else if (timeDifference.TotalHours >= 1)
            {
                int hours = (int)timeDifference.TotalHours;
                return $"{hours} hour(s) ago";
            }
            else if (timeDifference.TotalMinutes >= 1)
            {
                int minutes = (int)timeDifference.TotalMinutes;
                return $"{minutes} minute(s) ago";
            }
            else
            {
                return "now";
            }
        }


    }

    //public class X_Y
    //{
    //    public int Solution(int X, int Y, int[] A)
    //    {
    //        int N = A.Length;
    //        int result = -1;
    //        int nX = 0;
    //        int nY = 0;

    //        for (int i = 0; i < N; i++)
    //        {
    //            if (A[i] == X)
    //                nX++;
    //            if (A[i] == Y)
    //                nY++;

    //            // Update result if counts are equal and current index is greater than previous result
    //            if ((nX == nY) && (nX != 0 && nY != 0))
    //                //if (nX == nY && nX != 0 && nY != 0)

    //                result = i;
    //        }
    //        return result;
    //    }

    //public class X_Y
    //{
    //    public int Solution(int X, int Y, int[] A)
    //    {
    //        int N = A.Length;
    //        int result = -1;
    //        int nX = 0;
    //        int nY = 0;

    //        for (int i = 0; i < N; i++)
    //        {
    //            if (A[i] == X)
    //                nX++;
    //            if (A[i] == Y)
    //                nY++;
    //            if (nX == nY && nX != 0 && nY != 0 && X >= 1 && X <= 1000000000 && Y >= 1 && Y <= 1000000000 && N <= 100000)
    //                result = i;
    //        }
    //        return result;
    //    }
    //}

    public class X_Y
    {
        public int Solution(int X, int Y, int[] A)
        {
            int N = A.Length;
            int result = -1;
            int nX = 0;
            int nY = 0;

            for (int i = 0; i < N; i++)
            {
                if (A[i] == X)
                    nX++;
                if (A[i] == Y)
                    nY++;
                if (nX == nY && nX != 0 && nY != 0)
                    result = i;
            }
            return result;
        }
    }
}

