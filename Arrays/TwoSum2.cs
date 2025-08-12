public class Solution 
{
    public int[] TwoSum(int[] arr, int target) 
    {
        int start = 0;
        int end = arr.Length - 1;

      while(arr[start] + arr[end] != target)
      {
            if(arr[start] + arr[end] > target)
            {
                end--;
            }

            else
            {
                start++;
            }
      }

      return new int[] {start + 1,end + 1};
    }
}
