// Problem: Minimum Number in a sorted rotated array
// Source: https://www.geeksforgeeks.org/batch/dsa-at-your-own-pace/track/DSASP-Searching/problem/minimum-number-in-a-sorted-rotated-array-1587115620
// Synced using GFG Batch → GitHub Sync

class Solution {
    // Complete this function
    // Function to find the minimum element in sorted and rotated array.
    public int minNumber(int[] arr, int low, int high) {
        // Your code here
        while(low < high){
            int mid = (low+high)/2;
            if(arr[mid] > arr[high]){
                low = mid+1;
            }
            else{
                high = mid;
            }
        }
        return arr[low];
    }
}
