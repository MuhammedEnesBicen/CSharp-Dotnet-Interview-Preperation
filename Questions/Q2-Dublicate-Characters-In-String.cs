using System.Text;

public partial class Questions
{
    public static void Q2_Dublicate_Characters_In_String(string str)
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

        Console.WriteLine($"\n\tResult of Q2_Dublicate_Characters_In_String func: {sb}\n");

    }
}