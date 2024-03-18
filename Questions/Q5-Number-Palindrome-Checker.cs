public partial class Questions
{
    public static string Q5_NumberPalindromeChecker(int num)
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

        return (result) ?
                 $"{originalNumber} is a palindrome" : $"{originalNumber} is not a palindrome";
    }
}