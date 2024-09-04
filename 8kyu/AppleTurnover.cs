//Alan is known for referring to the temperature of the apple turnover as Hotter than the sun!.According to space.com the temperature of the sun's corona is 2,000,000 degrees Celsius, but we will ignore the science for now.

//Task
//Your job is simple, if x squared is more than 1000, return It's hotter than the sun!!, else, return Help yourself to a honeycomb Yorkie for the glovebox.


//My Solution

public class AppleTurnoverProblem
{
    public static string Apple(object n)
    {
        int value;
        if (n is String s)
        {
            value = Int32.Parse(s);
        }
        else
        {
            value = (int)n;
        }
        return value * value > 1000 ? "It's hotter than the sun!!" : "Help yourself to a honeycomb Yorkie for the glovebox.";
    }
}