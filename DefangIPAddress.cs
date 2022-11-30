using System;
/* LeetCode Easy
Given a valid (IPv4) IP address, return a defanged version of that IP address.

A defanged IP address replaces every period "." with "[.]".
*/
public class Solution {
  public string DefangIPaddr(string address) {
    string solution = "";
      for (int i = 0; i<address.Length; i++) {
        if (address[i] == '.') { 
          solution += "[.]"; 
        }
        else { 
        solution += address[i]; 
      }
    } 
    return solution;
  }
}

