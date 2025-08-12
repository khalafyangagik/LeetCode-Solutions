public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int,int> dic = new();
        for(int i = 0; i < nums.Length; ++i)
        {
            int a = target - nums[i];
            if(dic.ContainsKey(a))
            {
                return new int[] {dic[a],i};
            }

            if (!dic.ContainsKey(nums[i]))
            {
                dic[nums[i]] = i;
            }
        }
        return new int[]{};
    }
}
