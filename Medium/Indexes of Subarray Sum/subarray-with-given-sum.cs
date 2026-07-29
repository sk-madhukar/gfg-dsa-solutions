// Problem: Indexes of Subarray Sum
// Source: https://www.geeksforgeeks.org/batch/dsa-at-your-own-pace/track/DSASP-Searching/problem/subarray-with-given-sum-1587115621
// Synced using GFG Batch → GitHub Sync

class Solution {
    public List<int> subarraySum(int[] arr, int target) {
        // Code Here
        int sum = 0;
        int i=0;
        for(int j=0; j<arr.Length; j++){
            sum +=arr[j];
            
            while(sum > target && i < j){
                sum -= arr[i];
                i++;
            }
            
            if(sum == target){
                return new List<int>{i+1, j+1};
            }
        }
        return new List<int>{-1};
    }
}
