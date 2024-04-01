public partial class LeetcodeNeetcodeQuestions
{

    /// <summary>
    /// Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0
    /// |
    /// Question was taken from https://neetcode.io/quiz/3sum
    /// </summary>
    /// <returns>Prints Triplets  whose sum equal to 0</returns>
    public static void LN1_3Sum()
    {
        List<int> nums = new List<int>() { -1, 0, 1, 2, -1, -4 };
        nums.Sort();
        List<List<int>> result = new();
        for (int i = 0; i < nums.Count; i++)
        {
            var trios = FindSum(nums, i);
            result.AddRange(trios);
        }
        // Operation of getting rid of dublicate triplets 
        // it could be done by removing dublicate elements in num after sorting it
        string resultAsString =
        string.Join(" , ",
        result.Select(list => $"[{string.Join(", ", list)}]").Distinct());
        Console.WriteLine($"\n\tResult of LN1_3Sum func:\n\t{resultAsString}\n");
    }

    private static List<List<int>> FindSum(List<int> nums, int startIndex)
    {
        List<List<int>> result = new();

        int firstNumber = nums[startIndex];

        int leftPointer = startIndex + 1;
        int rightPointer = nums.Count - 1;
        int tempSum = 0;
        while (leftPointer < rightPointer)
        {
            tempSum = firstNumber + nums[leftPointer] + nums[rightPointer];
            if (tempSum == 0)
            {
                result.Add(new List<int>() { firstNumber, nums[leftPointer], nums[rightPointer] });
                leftPointer++;
                rightPointer--;
            }
            else if (tempSum < 0) leftPointer++;
            else rightPointer--;
        }
        return result;
    }

}


// The time complexity is O(n^2) because we iterate through the array once (which is O(n)),
// and for each iteration, we potentially go through the rest of the array
// using the two-pointer approach (which is also O(n)),
// thus resulting in O(n^2). The space complexity is O(1) 
// since we aren't using additional space, other than the output.