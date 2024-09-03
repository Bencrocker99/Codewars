//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

//Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.

//Additionally, if the number is negative, return 0.

//Note: If the number is a multiple of both 3 and 5, only count it once.


//My Solution

using System;
public static class Kata
{
    public static int Solution(int value)
    {
        int sum = 0;
        for (int i = 0; i < value; i++)
        {
            if (i * 5 < value)
            {
                sum += i * 5;
            }
            if ((((i * 3) % 5) == 0) && i * 3 < value)
            {
                continue;
            }
            else if (i * 3 < value)
            {
                sum += i * 3;
            }
            else
            {
                return sum;
            }
        }
        return sum;
    }
}