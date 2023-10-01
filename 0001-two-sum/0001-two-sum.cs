public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
       Dictionary<int, int> numIndexMap = new Dictionary<int, int>();

       for(int i = 0; i < nums.Length; i++)
       {
           int complement = target - nums[i];
           if(numIndexMap.ContainsKey(complement))
           {
               return new int[] {numIndexMap[complement], i};
           }
           numIndexMap[nums[i]] = i;
       }
       return new int[0];
    }
}