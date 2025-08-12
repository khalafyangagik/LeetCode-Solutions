public class Solution 
{
    public void SortColors(int[] nums) 
    {
        int min = 0;
        for(int i = 0;i < nums.Length;i++)
        {
            min = i;
            for(int j = i+1;j < nums.Length;j++)
            {
                if(nums[j] < nums[min])
                {
                    min = j;
                }
            }
            swap(nums, i, min);
        }
    }
    private void swap(int[] nums, int i, int j)
    {
        int tmp = nums[j];
        nums[j] = nums[i];
        nums[i] = tmp;
    }
}
