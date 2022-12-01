using System;
/* LeetCode Easy
You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.

Letters are case sensitive, so "a" is considered a different type of stone from "A". */
public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int count = 0;
        for (int r = 0; r<jewels.Length; r++) {
            for (int c = 0; c<stones.Length; c++) {
                if (stones[c] == jewels[r]) {
                    count++;
                }
            }
        } 
        return count;   
    }
}