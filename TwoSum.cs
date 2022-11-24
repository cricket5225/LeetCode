using System;
/* LeetCode Easy
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order. */
public class Solution {
  public int[] TwoSum(int[] nums, int target) {
    int length = nums.GetLength(0);
    int[] solution = new int[] {69,42};
    for (int i = 0; i<length; i++) {
      for (int j = 0; j<(length-1); j++) {
        int compare = nums[i] + nums[j];
        if (compare == target) {
          solution[0] = i;
          solution[1] = j;
          break;
        }
      } 
    } 
    return solution;   
  }
}