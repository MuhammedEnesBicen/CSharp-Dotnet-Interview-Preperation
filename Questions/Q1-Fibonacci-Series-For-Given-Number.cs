using System.Text;

public partial class Questions
{
    public static void Q1_Fibonacci_Series_For_Given_Number(int number)
    {
        int prev2nd = 1, prev = 1, current = 0;
        StringBuilder sb = new StringBuilder();
        sb.Append(prev2nd + " " + prev + " ");
        for (int i = 2; i < number; i++)
        {
            current = prev2nd + prev;
            prev2nd = prev;
            prev = current;
            sb.Append(current + " ");
        }
        var result = sb.ToString();
        Console.WriteLine($"\n\tResult of Q1_Fibonacci_Series_For_Given_Number func: {result}\n");
    }
}