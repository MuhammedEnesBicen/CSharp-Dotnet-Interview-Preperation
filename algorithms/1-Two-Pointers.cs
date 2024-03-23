public partial class Allgorithms
{


    /// <summary>
    /// Searches for a pair in the given array. If it finds a pair whose sum is equal to the sum parameter, returns it.
    /// 
    /// A good article about this algorithm can be found at https://www.geeksforgeeks.org/two-pointers-technique/
    /// </summary>
    /// <param name="nums">Number list</param>
    /// <param name="sum">Desired sum amount</param>
    /// <returns>The pair whose sum is equal to the sum parameter.</returns>
    public static List<int> A1_TwoSum(List<int> nums, int sum)
    {
        var result = new List<int>();

        nums.Sort();

        int lPointer = 0;
        int rPointer = nums.Count - 1;

        int tempSum = 0;
        while (lPointer < rPointer)
        {
            tempSum = nums[lPointer] + nums[rPointer];
            if (tempSum == sum)
            {
                result.AddRange([nums[lPointer], nums[rPointer]]);
                break;
            }
            else if (tempSum > sum) rPointer--;
            else lPointer++;
        }

        return result;
    }
}