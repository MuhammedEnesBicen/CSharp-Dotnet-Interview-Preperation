using System.Text;
public partial class Questions
{
    public static void Q3_Remove_Dublicate_Characters_In_String(string str)
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

        Console.WriteLine($"\n\tResult of Q3_Remove_Dublicate_Characters_In_String func: {new string(chars.ToArray())}\n");
    }
}