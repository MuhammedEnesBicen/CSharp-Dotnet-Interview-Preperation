using System.Text;

public partial class Questions
{
    public static StringBuilder Q2_DublicateCharactersInString(string str)
    {
        StringBuilder sb = new StringBuilder();

        Dictionary<char, int> countOfCharsDict = new Dictionary<char, int>();
        foreach (char item in str)
        {
            if (countOfCharsDict.ContainsKey(item))
            {
                countOfCharsDict[item] += 1;
                if (countOfCharsDict[item] <= 2)
                    sb.Append(item + " ");
            }
            else
            {
                countOfCharsDict[item] = 1;
            }
        }

        return sb;
    }
}