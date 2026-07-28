# Minimum Number in a sorted rotated array

**Difficulty:** Basic
**Problem link:** [GeeksforGeeks](https://www.geeksforgeeks.org/batch/dsa-at-your-own-pace/track/DSASP-Searching/problem/minimum-number-in-a-sorted-rotated-array-1587115620)
**Solution:** [minimum-number-in-a-sorted-rotated-array.cs](./minimum-number-in-a-sorted-rotated-array.cs)
**Language:** C#

---

## Problem statement

Given an array of distinct elements which was initially sorted. This array may be rotated at some unknown point. The task is to find the minimum element in the given sorted and rotated array.

### Example 1

```text
**Input:**
N = 10
arr[] = {2,3,4,5,6,7,8,9,10,1}
**Output:** 1
**Explanation:** The array is rotated
once anti-clockwise. So minimum
element is at last index (n-1)
which is 1.
```

### Example 2

```text
**Input:**
N = 5
arr[] = {3,4,5,1,2}
**Output:** 1
**Explanation:** The array is rotated
and the minimum element present is
at index (n-2) which is 1.
```

Your Task:
The task is to complete the function minNumber() which takes the array arr[] and its starting and ending indices (low and high) as inputs and returns the minimum element in the given sorted and rotated array.

## Constraints
1 <= N <= 107
1 <= arr[i] <= 107

---

> The README includes the public statement and sample examples visible on GFG. Hidden judge test cases are not exposed by GeeksforGeeks and cannot be uploaded.
