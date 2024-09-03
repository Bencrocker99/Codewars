//Create a function that gives a personalized greeting. This function takes two parameters: name and owner.

//Use conditionals to return the proper message:

//case    return
//name equals owner   'Hello boss'
//otherwise   'Hello guest'


//My Solution

public class Kata
{
    public static string Greet(string name, string owner)
    {
        if (Equals(name, owner))
        {
            return "Hello boss";
        }
        else return "Hello guest";
    }
}