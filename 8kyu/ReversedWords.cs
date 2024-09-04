//Complete the solution so that it reverses all of the words within the string passed in.

//Words are separated by exactly one space and there are no leading or trailing spaces.

//Example(Input --> Output):

//"The greatest victory is that which requires no battle"-- > "battle no requires which that is victory greatest The"


//My Solution

public class ReversedWordsProblem
{
    public static string ReverseWords(string str)
    {
        String[] array = str.Split(' ');
        String correctedString = "";
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                correctedString = correctedString + array[i];
                break;
            }
            correctedString = correctedString + array[i] + " ";
        }
        return correctedString;
    }
}