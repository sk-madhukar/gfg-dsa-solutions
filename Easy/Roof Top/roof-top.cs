// Problem: Roof Top
// Source: https://www.geeksforgeeks.org/batch/dsa-at-your-own-pace/track/DSASP-Searching/problem/roof-top-1587115621
// Synced using GFG Batch → GitHub Sync

class Solution {
    public int maxStep(int[] arr) {
        // code here
        int n = arr.Length;
        int count = 0;
        int maxCount = 0;
        
        for(int i=1; i<n; i++){
            if(arr[i] > arr[i-1]){
                count++;
                maxCount = Math.Max(maxCount, count);
            }
            else{
                count = 0;
            }
        }
        
        return maxCount;
    }
}
