// Problem: Peak element
// Source: https://www.geeksforgeeks.org/batch/dsa-at-your-own-pace/track/DSASP-Searching/problem/peak-element
// Synced using GFG Batch → GitHub Sync

class Solution {
    public int peakElement(int[] arr) {
        // code here
        int low = 0;
        int high = arr.Length-1;
        
        while(low <= high){
            int mid = (low+high)/2;
            if((mid==0 || arr[mid] >= arr[mid-1]) &&
              (mid == arr.Length-1 || arr[mid] >= arr[mid+1])){
                  return mid;
              }
              
            if(mid > 0 && arr[mid] <= arr[mid-1]){
                high = mid-1;
            }
            else{
                low = mid+1;
            }
        }
        return -1;
    }
}
