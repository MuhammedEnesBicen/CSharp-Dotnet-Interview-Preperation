public partial class InterviewQuestions
{
    // Input: ["bl", "c2", "x3", "x4", "z0"]
    // Output: ["z0", "bl", "c2", "x3", "x4"]
    public static void IQ1_Reverse_Array_Based_On_Last_Character()
    {
        string[] arr = ["b1", "c2", "x3", "x4", "z0"];

        // return SolutionWithoutLINQ(arr); // Call if you want to call second solution
        string ReverseString(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        var result = arr.Select(a => ReverseString(a)).Order().Select(a => ReverseString(a)).ToArray();


        Console.WriteLine($"\n\tResult of IQ1_Reverse_Array_Based_On_Last_Character func: {String.Join(", ", result)}\n");

    }

    private static string[] SolutionWithoutLINQ(string[] arr)
    {
        // You can call this inside of function above

        string ReverseString(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        string[] reversed = new string[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            reversed[i] = ReverseString(arr[i]);
        }

        Array.Sort(reversed);

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = ReverseString(reversed[i]);
        }

        return arr;

    }
}