// Problem: Check Sorted Array
// Source: https://www.geeksforgeeks.org/problems/check-if-an-array-is-sorted0701/1
// Synced using GFG Batch → GitHub Sync

class Solution {

    public bool isSorted(int[] arr) {
        // Code here
        for(int i=1; i<arr.Length; i++){
            if(arr[i] < arr[i-1]){
                return false;
            }
        }
        return true;
    }
}
