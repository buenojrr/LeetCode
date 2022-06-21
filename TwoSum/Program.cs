using System;
using System.Collections.Generic;

namespace CSharp
{
  class TwoSum
  {

    public static void Main(String[] args)
    {
      int[] novo = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };

      int[] result = findIndex(novo, 11);


      Console.WriteLine("[" + string.Join(",", result) + "]");
    }

    public static int[] findIndex(int[] nums, int target)
    {
      Dictionary<int, int> map = new Dictionary<int, int>();

      int len = nums.Length;
      for (int i = 0; i < len; i++)
      {
        int complement = target - nums[i];

        if (map.ContainsKey(complement))
        {
          return new int[] { map.GetValueOrDefault(complement), i };
        }
        map.TryAdd(nums[i], i);
      }
      return new int[] { };
    }
  }
}
