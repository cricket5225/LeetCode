using System;
/* LeetCode Easy
Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).

Return the running sum of nums. */
public class Solution {
  public int[] RunningSum(int[] nums) {
    int[] sum = new int[nums.GetLength(0)];
    sum[0] = nums[0];
    for (int i = 1; i<nums.GetLength(0); i++) {
      sum[i] = sum[i-1] + nums[i];
    }
    return sum;
  }
}