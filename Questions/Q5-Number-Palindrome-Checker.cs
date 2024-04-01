public partial class Questions
{
    public static void Q5_Number_Palindrome_Checker(int num)
    {
        bool result = false;
        int originalNumber = num;

        int reversed = 0;
        while (num > 0)
        {
            reversed *= 10;
            reversed += num % 10;
            num /= 10;
            if (reversed == originalNumber) result = true;
        }

        string resultAsString = (result) ?
                 $"{originalNumber} is a palindrome" : $"{originalNumber} is not a palindrome";

        Console.WriteLine($"\n\tResult of Q5_Number_Palindrome_Checker func: {resultAsString}\n");

    }
}