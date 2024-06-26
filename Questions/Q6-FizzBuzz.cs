using System.Text;

public partial class Questions
{
    public static void Q6_FizzBuzz(int n)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i < n; i++)
        {
            if (i % 15 == 0)
            {
                sb.AppendLine("FizzBuzz");
            }
            else if (i % 5 == 0)
            {
                sb.AppendLine("Buzz");
            }
            else if (i % 3 == 0)
            {
                sb.AppendLine("Fizz");
            }
            else
            {
                sb.AppendLine(i.ToString());
            }
        }

        Console.WriteLine($"\n\tResult of Q6_FizzBuzz func: \n{sb}\n");

    }
}