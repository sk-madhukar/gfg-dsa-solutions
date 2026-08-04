# Two Repeated Elements

**Difficulty:** Medium
**Problem link:** [GeeksforGeeks](https://www.geeksforgeeks.org/batch/dsa-at-your-own-pace/track/DSASP-Searching/problem/two-repeated-elements-1587115621)
**Solution:** [two-repeated-elements.cs](./two-repeated-elements.cs)
**Language:** C#

---

## Problem statement

You are given an integer array arr of size n+2. All elements of the array are in the range from 1 to n. Also, all elements occur once except two numbers which occur twice. Find the two repeating numbers.
Note: Return the numbers in their order of appearing twice. So, if x and y are repeating numbers, and x's second appearance comes before the second appearance of y, then the order should be (x, y).

### Examples

```text
**Input:** n = 4, arr[] = [1, 2, 1, 3, 4, 3]
**Output:** [1, 3]
**Explanation:** In the given array, 1 and 3 are repeated two times, and as 1's second appearance occurs before 2's second appearance, so the output should be 1 3.
```

```text
**Input:** n = 2, arr[] = [1, 2, 2, 1]
**Output:** [2, 1]
**Explanation:** In the given array, 1 and 2 are repeated two times and second occurence of 2 comes before 1. So the output is 2 1.
```

## Constraints
2 ≤ n ≤ 105
1 ≤ arr[i] ≤ n

---

> The README includes the public statement and sample examples visible on GFG. Hidden judge test cases are not exposed by GeeksforGeeks and cannot be uploaded.
