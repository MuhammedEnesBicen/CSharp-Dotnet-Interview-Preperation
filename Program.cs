// See https://aka.ms/new-console-template for more information
void log(dynamic arg)
{
    if (arg is System.String[] || arg is List<int>)
    {
        arg = String.Join(", ", arg);
    }
    Console.WriteLine("Result: " + arg.ToString());
}

var result = "You didnt run any function yet, please uncomment the function that you want to run and run the program again";
// Uncomment the line which contains function that you want to execute

// result = Questions.Q1_FibonacciSeriesForGivenNumber(10);
// result = Questions.Q2_DublicateCharactersInString("aaabvffrtt");
// result = Questions.Q3_RemoveDublicateCharactersInString("aaabvffrtt");
// result = Questions.Q4_PalindromeStringChecker("kalaalak");
// result = Questions.Q5_NumberPalindromeChecker(1234564321);
// result = Questions.Q6_FizzBuzz(54);

// result = InterviewQuestions.IQ1_ReverseArrayBasedOnLastCharacter(["b1", "c2", "x3", "x4", "z0"]);

// result = Allgorithms.A1_TwoSum(new List<int>() {1,2,2,5},4);

// result = LeetcodeNeetcodeQuestions.LN1_3Sum(new List<int>(){-1,0,1,2,-1,-4});

// log(result);                             // Uncomment to see the result ←↑→

// Sorting Algorithms dont return anything, they just sort the array and print the result
SortingAlgorithms.SO1_SelectionSort(new int[] { 1, 5, 3, 2, 4, 6, 7, 8, 9, 0 });
