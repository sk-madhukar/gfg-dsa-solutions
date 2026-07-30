# Count Only Repeated

**Difficulty:** Medium
**Problem link:** [GeeksforGeeks](https://www.geeksforgeeks.org/batch/dsa-at-your-own-pace/track/DSASP-Searching/problem/count-only-repeated2047)
**Solution:** [count-only-repeated2047.cs](./count-only-repeated2047.cs)
**Language:** C#

---

## Problem statement

Given a sorted array arr[] of positive integers where the elements are consecutive, meaning the difference between adjacent distinct elements is exactly 1. In the array, exactly one element is repeated one or more times, while all other elements appear exactly once.

Find and return the repeated element and the number of times it occurs in the array. If no element is repeated, return [-1, -1].

### Examples

```text
**Input:** arr[] = [1, 2, 3, 3, 4]
**Output:** 3 2
**Explanation:** In the given array, 3 is occuring two times.
```

```text
**Input:** arr[] = [2, 3, 4, 5, 5]
**Output:** 5 2
**Explanation:** In the given array, 5 is occuring two times.
```

```text
**Input:** arr[] = [1, 2, 3]
**Output:** -1 -1
**Explanation:** In the given array, there's no repeating element, and thus the output is -1 -1.
```

## Constraints
1 <= arr.size() <= 107
1 <= arr[i] <= arr.size()

---

> The README includes the public statement and sample examples visible on GFG. Hidden judge test cases are not exposed by GeeksforGeeks and cannot be uploaded.
