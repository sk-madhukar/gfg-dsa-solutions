# Array Insert at Index

**Difficulty:** Basic
**Problem link:** [GeeksforGeeks](https://www.geeksforgeeks.org/problems/array-insert-at-index/1)
**Solution:** [array-insert-at-index.cs](./array-insert-at-index.cs)
**Language:** C#

---

## Problem statement

You are given an array arr(0-based index) and two positive integer index and val. You need to insert an val at given index.

### Examples

```text
**Input:** arr[] = [1, 2, 3, 4, 5], index = 5, val = 90Output: 1 2 3 4 5 90
**Explanation:** 90 is inserted at index 5(0-based indexing). After inserting, array elements are like [1, 2, 3, 4, 5, 90].
```

```text
**Input:** arr[] = [1, 2, 3, 4, 5], index = 2, val = 90
**Output:** [1, 2, 90, 3, 4, 5]
**Explanation:** 90 is inserted at index 2(0-based indexing). After inserting, array elements are like [1, 2, 90, 3, 4, 5].
```

## Constraints
1 ≤arr.size() ≤ 105
0 ≤ val, arr[i] ≤ 106
0 ≤ index ≤ arr.size()

---

> The README includes the public statement and sample examples visible on GFG. Hidden judge test cases are not exposed by GeeksforGeeks and cannot be uploaded.
