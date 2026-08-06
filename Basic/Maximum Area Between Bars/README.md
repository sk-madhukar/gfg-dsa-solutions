# Maximum Area Between Bars

**Difficulty:** Basic
**Problem link:** [GeeksforGeeks](https://www.geeksforgeeks.org/batch/dsa-at-your-own-pace/track/DSASP-Searching/problem/maximum-water-between-two-buildings)
**Solution:** [maximum-water-between-two-buildings.cs](./maximum-water-between-two-buildings.cs)
**Language:** C#

---

## Problem statement

Given an integer array height[], where height[i] represents the height of the ith bar arranged in a row, find the maximum rectangular area that can be formed by selecting any two bars. The area is calculated based on the original positions of the selected bars.

### Examples

```text
**Input:** height[] = [2, 5, 4, 3, 7]
**Output:** 10
**Explanation:**The maximum rectangular area is formed by selecting the bars of heights 5 and 7.
There are 2 bars between them, so the area is: min(5, 7) × 2 = 10
```

```text
**Input:** height[] = [1, 3, 4]
**Output:** 1
**Explanation:** Selecting bars 1 and 4 gives one bar between them, so the area is: min(1, 4) × 1 = 1
```

## Constraints
1 ≤ height.size() ≤ 105
1 ≤ height[i] ≤ 104

---

> The README includes the public statement and sample examples visible on GFG. Hidden judge test cases are not exposed by GeeksforGeeks and cannot be uploaded.
