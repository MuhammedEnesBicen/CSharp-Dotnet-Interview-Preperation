public partial class LeetcodeNeetcodeQuestions
{

    /// <summary>
    /// Definition and details about this question can be found at https://neetcode.io/quiz/container-with-most-water
    /// </summary>
    public static void LN2_Container_With_Most_Water()
    {

        int[] arr = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

        int maxArea = 0;
        int leftPointer = 0;
        int rightPointer = arr.Length - 1;

        while (leftPointer < rightPointer)
        {
            int width = rightPointer - leftPointer;
            int height = Math.Min(arr[leftPointer], arr[rightPointer]);
            maxArea = Math.Max(maxArea, width * height);

            if (arr[leftPointer] < arr[rightPointer])
                leftPointer++;
            else
                rightPointer--;
        }

        Console.WriteLine($"\n\tResult of LN2_Container_With_Most_Water func: \n\tMax Area = {maxArea}\n");
    }
}