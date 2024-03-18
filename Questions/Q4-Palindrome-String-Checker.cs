public partial class Questions{
    public static string Q4_PalindromeStringChecker(string str){
        bool result = true;
        var chars = str.ToCharArray();
        int start = 0;
        int end = chars.Length-1;

        while(start < end){
            if(chars[start]!= chars[end]){
                result=false;
                break;
            }
            start++;
            end--;
        }

        return (result) ?
         $"{str} is a palindrome" : 
         $"{str} is not palindrome. The {start+1}th ({chars[start]}) character is not equal to {end+1}th ({chars[end]}) character.";
    }
}