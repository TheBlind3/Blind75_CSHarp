using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBlind75
{
    public class ArrayProblems
    {
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the 
        /// two numbers such that they add up to target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can return the answer in any order.
        /// </summary>
        /// <param name="nums">Array of Sample Numbers to find the target.</param>
        /// <param name="target">The number the two integers from nums should add up to.</param>
        /// <returns>An int[2] of the two indices of integers in nums that add up to target.</returns>
        public int[] TwoSumN2(int[] nums, int target)
        {
            int[] answer = new int[2];

            for(int x = 0; x < nums.Length; x++)
            {
                for(int y = 0; y < nums.Length; y++)
                {
                    if (nums[y] + nums[x] == target && y !=x)
                    {
                        answer[0] = x;
                        answer[1] = y;
                        return answer;
                    }
                }
            }

            return answer;
        }
        /// <summary>
        /// Given an array of integers nums and an integer target, return indices of the 
        /// two numbers such that they add up to target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// You can return the answer in any order.
        /// </summary>
        /// <param name="nums">Array of Sample Numbers to find the target.</param>
        /// <param name="target">The number the two integers from nums should add up to.</param>
        /// <returns>An int[2] of the two indices of integers in nums that add up to target.</returns>
        public int[] TwoSum(int[] nums, int target)
        {
            //Go through the entire list and put keys into dictionary as we go. 
            // As we store each value, the key will be the difference between the target and the num and the value will be the index.
            //As we iterate through the array, if a key exists that is equal to nums[x] that means that key's value and the current value 
            // add up to the target. Return the value of the dictionary[nums[x]] and the current index(x).
            Dictionary<int, int> diffs = new Dictionary<int, int>(nums.Length);
            for (int x = 0; x < nums.Length; x++)
            {
                if (diffs.ContainsKey(nums[x]))
                {
                    return new int[2] { diffs[nums[x]], x };
                }
                if (!diffs.ContainsKey(target - nums[x]))
                {
                    diffs.Add(target - nums[x], x);
                }
            }

            return new int[2];
        }
        /// <summary>
        /// You are given an array prices where prices[i] is the price of a given stock on the ith day.
        ///You want to maximize your profit by choosing a single day to buy one stock and choosing a different 
        ///day in the future to sell that stock.
        ///Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.
        /// </summary>
        /// <param name="prices">Array(int) that indicates the price of a given stock on the ith day</param>
        /// <returns>Maximum profit as an int.</returns>
        public int MaxProfit(int[] prices)
        {
            int min = prices[0]; //Initialize bases
            int max = prices[0];
            int maxdiff = 0;
            for (int x = 0; x < prices.Length; x++)
            {
                if (prices[x] < min) //if price is ever less than the min: reset min and reset max to
                {                    //ensure max is always after min
                    min = prices[x];
                    max = prices[x];
                }
                if (prices[x] > max)//set new max 
                {
                    max = prices[x];
                    if (maxdiff < max - min)  //set maxprofit if > the previously calculated max profit
                    {
                        maxdiff = max - min;
                    }
                }
            }
            return maxdiff;
        }
        /// <summary>
        /// Given an integer array nums, return true if any value appears at least
        /// twice in the array, and return false if every element is distinct.
        /// </summary>
        /// <param name="nums">Array of ints</param>
        /// <returns>true if there is a duplicate, false if not.</returns>
        public bool ContainsDuplicate(int[] nums)
        {
            //Add values to a Hashset if Add returns false then is a duplicate.
            HashSet<int> set = new HashSet<int>(nums.Length); 
            for (int x = 0; x < nums.Length; x++)
            {
                if (!set.Add(nums[x]))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Given an integer array nums, return an array answer such that answer[i] is equal to the 
        /// product of all the elements of nums except nums[i].
        /// The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
        /// You must write an algorithm that runs in O(n) time and without using the division operation
        /// </summary>
        /// <param name="nums">An integer array</param>
        /// <returns>An array of ints that is the product of all other numbers.</returns>
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] answer = new int[nums.Length];
            HashSet<int> set = new HashSet<int>(nums);
            foreach (int x in set)
            {
                  
            }


            return answer;
        }





    }
}
