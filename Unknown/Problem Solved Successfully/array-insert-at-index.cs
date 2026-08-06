// Problem: Problem Solved Successfully
// Source: https://www.geeksforgeeks.org/problems/array-insert-at-index/1
// Synced using GFG Batch → GitHub Sync

using System.Collections.Generic;

class Solution {
    public void insertAtIndex(List<int> arr, int index, int val) {
        // code here
        arr.Add(val);
        int n = arr.Count;
        for(int i=n-2; i>=index; i--){
            int temp = arr[i];
            arr[i] = arr[i+1];
            arr[i+1] = temp;
        }
    }
}
