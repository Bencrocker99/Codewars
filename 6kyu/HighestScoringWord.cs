//Given a string of words, you need to find the highest scoring word.

//Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.

//For example, the score of abad is 8 (1 + 2 + 1 + 4).

//You need to return the highest scoring word as a string.

//If two words score the same, return the word that appears earliest in the original string.

//All letters will be lowercase and all inputs will be valid.


//My Solution

public class HighestScoringWordSolution
{
    public static string High(string s)
    {
        const int ASCII_VALUE_OFFSET = 96;

        string[] words = s.Split(' ');

        int currentHighestScore = 0;
        string currentHighestScoringWord = "";

        foreach(string word in words)
        {
            int score = 0;

            foreach(char letter in word)
                score += letter - ASCII_VALUE_OFFSET;

            if (score > currentHighestScore)
            {
                currentHighestScore = score;
                currentHighestScoringWord = word;
            }
        }

        return currentHighestScoringWord;
    }
}
