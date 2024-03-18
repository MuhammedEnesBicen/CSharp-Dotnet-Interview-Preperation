using System.Text;
public partial class Questions
{
    public static String Q3_RemoveDublicateCharactersInString(string str)
    {

        List<char> chars = str.ToCharArray().ToList();
        int i = 0;
        while (i < chars.Count)
        {
            if (chars.Take(i).Contains(chars[i]))
            {
                chars.RemoveAt(i);
            }
            else
            {
                i++;
            }

        }

        return new string(chars.ToArray());
    }
}