public class Solution {
    public bool CanPartitionKSubsets(int[] nums, int k) {
        var n = nums.Length;
        if (k > n)
        {
            return false;
        }
        
        var frequencies = new Dictionary<int, int>();
        var values = new HashSet<int>();
        var totalSum = 0;
        
        // count frequency of each value in nums,
        // and calculate sum of all values in 
        for (var i = 0; i < n; i++)
        {
            var val = nums[i];
            
            if (frequencies.ContainsKey(val))
            {
                frequencies[val]++;
            }
            else
            {
                frequencies.Add(val, 1);
                values.Add(val);
            }
            
            totalSum += val;
        }
        
        var targetSum = totalSum / k;
        
        foreach (var val in values)
        {
            //var val = freqPair.Key;
            var freq = frequencies[val];
            
            if (val == targetSum)
            {
                frequencies[val] = 0;
                continue;
            }
            else if (freq == 0)
            {
                continue;
            }
            else if (val > targetSum)
            {
                return false;
            }     
            var targetAddend = targetSum - val;
            
            if (frequencies.ContainsKey(targetAddend))
            {
                var addendCount = frequencies[targetAddend];
                
                while (freq > 0 && addendCount > 0)
                {
                    freq--;
                    addendCount--;
                }
                
                if (freq > 0 || addendCount > 0)
                {
                    return false;
                }
                else
                {
                    frequencies[val] = freq;
                    frequencies[targetAddend] = addendCount;
                }
            }
            else
            {
                return false;
            }
        }
        
        return true;
        
    }
}