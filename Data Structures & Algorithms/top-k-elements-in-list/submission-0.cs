public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Dictionary<int,int> frequency = new Dictionary<int,int>();
        foreach(int i in nums)
        {
            if(frequency.ContainsKey(i))
            {
                frequency[i]++;
            }
            else
            {
                frequency.Add(i,1);
            }
        }
    return frequency.OrderByDescending(x=>x.Value).Take(k).Select(x=>x.Key).ToArray();        
    }
}
