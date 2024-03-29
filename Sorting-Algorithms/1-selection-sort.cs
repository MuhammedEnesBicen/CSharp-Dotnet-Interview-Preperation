public partial class SortingAlgorithms
{
    ///
    ///<summary>
    /// Selection Sort
    /// Time Complexity: O(n^2)
    /// Space Complexity: O(1)
    ///  || A good article about this algorithm can be found at https://www.dotnetoffice.com/2018/10/c-program-selection-sorting.html
    ///</summary>
    ///
    ///<param name="arr">Array to be sorted</param>
    ///<returns>Nothing just prints Sorted array</returns>
    public static void SO1_SelectionSort(int[] arr)
    {
        int[] result = new int[arr.Length];

        int startIndex = 0;

        while (startIndex < arr.Length)
        {
            int minIndex = startIndex;
            for (int i = startIndex; i < arr.Length; i++)
            {
                if (arr[i] < arr[minIndex])
                {
                    minIndex = i;
                }
            }

            int temp = arr[startIndex];
            arr[startIndex] = arr[minIndex];
            arr[minIndex] = temp;

            startIndex++;
        }

        Console.WriteLine("Selection Sort Result: ");
        Console.Write($"[ {string.Join(", ", arr)} ]");
    }

}