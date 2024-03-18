// See https://aka.ms/new-console-template for more information
void log(dynamic arg) => Console.WriteLine("Result: " + arg.ToString());

// Uncomment the line which contains function that you want to execute

//var result = Questions.Q1_FibonacciSeriesForGivenNumber(10);
//var result = Questions.Q2_DublicateCharactersInString("aaabvffrtt");
//var result = Questions.Q3_RemoveDublicateCharactersInString("aaabvffrtt");
// var result = Questions.Q4_PalindromeStringChecker("kalaalak");
//var result = Questions.Q5_NumberPalindromeChecker(1234564321);
var result = Questions.Q6_FizzBuzz(54);

log(result);
