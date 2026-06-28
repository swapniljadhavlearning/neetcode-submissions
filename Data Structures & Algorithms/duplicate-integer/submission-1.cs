
public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        HashSet<int> numHash = new HashSet<int>();

        foreach (int num in nums)
        {
            if (numHash.Contains(num))
            {
                return true;
            }

            numHash.Add(num);
        }

        return false;
    }
}