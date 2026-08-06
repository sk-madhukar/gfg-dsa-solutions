// Problem: Largest in Array
// Source: https://www.geeksforgeeks.org/problems/largest-element-in-array4009/1
// Synced using GFG Batch → GitHub Sync

class Solution {
    public int largest(List<int> arr) {
        // code here.
        int largestElement = arr[0];
        for(int i=1; i<arr.Count; i++){
            if(arr[i] > largestElement){
                largestElement = arr[i];
            }
        }
        return largestElement;
    }
}
