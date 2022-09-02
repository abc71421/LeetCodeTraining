namespace CSharp.No001;

public class No001
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(target - nums[i]))
                return new[] {map[target - nums[i]], i};

            if (!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i],i);
            }
        }

        return new []{0,0};
    }

}