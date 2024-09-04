//Usually when you buy something, you're asked whether your credit card number, phone number or answer to your most secret question is still correct. However, since someone could look over your shoulder, you don't want that shown on your screen. Instead, we mask it.

//Your task is to write a function maskify, which changes all but the last four characters into '#'.

//Examples (input --> output):
//"4556364607935616"-- > "############5616"
//     "64607935616"-- > "#######5616"
//               "1"-- > "1"
//                ""-- > ""

//// "What was the name of your first pet?"
//"Skippy"-- > "##ippy"
//"Nananananananananananananananana Batman!"-- > "####################################man!"


//My Solution

public static class CreditCardMaskProblem
{
    // return masked string
    public static string Maskify(string cc)
    {
        if (cc.Length < 4)
        {
            return cc;
        }
        string mask = "";
        for (int i = 4; i < cc.Length; i++)
        {
            mask = mask + "#";
        }
        mask = mask + cc.Substring(cc.Length - 4);
        return mask;
    }
}