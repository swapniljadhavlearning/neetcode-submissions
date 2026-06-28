public class Solution {
    public int[] TwoSum(int[] nums, int target) {
      Dictionary<int, int> map = new Dictionary<int ,int>();
      // Key: The number itself | Value: Its index in the array
           for (int i = 0; i < nums.Length; i++){
            int complement  = target - nums[i];
            if(map.ContainsKey(complement)){
               
               // If the complement is already in the map, we found our pair!
                return new int[]{
                   map[complement],i
                };
            }
            // Otherwise, store the current number and its index
               map[nums[i]] =i ;
            
           } 
           return new int[0];// Fallback (problem guarantees a solution)
    }
}
