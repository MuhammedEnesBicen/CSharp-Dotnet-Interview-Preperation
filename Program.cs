// See https://aka.ms/new-console-template for more information
void log(dynamic arg)
{
    if (arg is System.String[] || arg is List<int>)
    {
        arg = String.Join(", ", arg);
    }
    Console.WriteLine("Result: " + arg.ToString());
}
// Uncomment the line which contains function that you want to execute

//var result = Questions.Q1_FibonacciSeriesForGivenNumber(10);
//var result = Questions.Q2_DublicateCharactersInString("aaabvffrtt");
//var result = Questions.Q3_RemoveDublicateCharactersInString("aaabvffrtt");
//var result = Questions.Q4_PalindromeStringChecker("kalaalak");
//var result = Questions.Q5_NumberPalindromeChecker(1234564321);
//var result = Questions.Q6_FizzBuzz(54);

//var result = InterviewQuestions.IQ1_ReverseArrayBasedOnLastCharacter(["b1", "c2", "x3", "x4", "z0"]);

//var result = Allgorithms.A1_TwoSum(new List<int>() {1,2,2,5},4);

var result = LeetcodeNeetcodeQuestions.LN1_3Sum(new List<int>(){-1,0,1,2,-1,-4});

log(result);
