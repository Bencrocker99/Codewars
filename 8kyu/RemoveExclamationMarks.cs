//Write function RemoveExclamationMarks which removes all exclamation marks from a given string.


//My Solution

public class RemoveExclamationMarksProblem
{
    public static string RemoveExclamationMarks(string s)
    {
        string correctedString = s.Replace("!", "");
        return correctedString;
    }
}