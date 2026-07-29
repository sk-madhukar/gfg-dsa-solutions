# Roof Top

**Difficulty:** Easy
**Problem link:** [GeeksforGeeks](https://www.geeksforgeeks.org/batch/dsa-at-your-own-pace/track/DSASP-Searching/problem/roof-top-1587115621)
**Solution:** [roof-top.cs](./roof-top.cs)
**Language:** C#

---

## Problem statement

Given and array arr[] representing the heights of n consecutive buildings. You can move from the roof of a building to the roof of the next adjacent building. You need to find the maximum number of consecutive steps you can put forward such that every step is to a higher building than the previous one.

### Examples

```text
**Input:** arr[] = [1, 2, 2, 3, 2] Output: 1 Explanation: Only pairs like 1 -> 2 or 2 -> 3 increase in height, and each such run has just 1 step. So the maximum consecutive upward steps is 1.
```

```text
**Input:** arr[] = [10, 20, 30, 40, 25, 50]Output: 3Explanation: 10 -> 20 -> 30 -> 40 are strictly increasing heights, so the maximum consecutive upward steps is 3.
```

```text
**Input:** arr[] = [4, 3, 2, 1]Output: 0Explanation: There are no contiguous increasing heights
```

## Constraints
1 ≤ arr.size() ≤ 105
1 ≤ arr[i] ≤ 105

---

> The README includes the public statement and sample examples visible on GFG. Hidden judge test cases are not exposed by GeeksforGeeks and cannot be uploaded.
