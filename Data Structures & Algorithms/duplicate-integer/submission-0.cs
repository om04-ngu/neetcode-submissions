public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        var length = nums.Length;
        for(int i=0; i<length ; i++)
        {
            for(int j = i+1; j<length; j++)
            {
                if(nums[i]==nums[j])
                {
                    return true;
                }
            }
        }
        return false;
        
    }
}