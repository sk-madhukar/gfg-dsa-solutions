// Problem: Allocate Minimum Pages
// Source: https://www.geeksforgeeks.org/batch/dsa-at-your-own-pace/track/DSASP-Searching/problem/allocate-minimum-number-of-pages0937
// Synced using GFG Batch → GitHub Sync

class Solution {
    public int findPages(int[] arr, int k) {
        // code Here
        
        if(arr.Length < k){
            return -1;
        }
        
        long sum = 0;
        int mx = 0;
        for(int i=0; i<arr.Length; i++){
            sum += arr[i];
            mx =Math.Max(mx, arr[i]);
        }
        
        long low = mx;
        long high = sum;
        long ans = 0;
        while(low<=high){
            long mid = (low+high)/2;
            if(isFeasible(arr, k, mid)){
                ans = mid;
                high = mid-1;
            }
            else{
                low = mid+1;
            }
        }
        return (int)ans;
    }
    
    private bool isFeasible(int[] arr, int k, long limit){
        int students = 1;
        long sum=0;
        
        foreach(int pages in arr){
            if(pages > limit){
                return false;
            }
            
            if(sum+pages > limit){
                students++;
                sum = pages;
            }
            else
            {
                sum += pages;
            }
        }
        
        return students <= k;
    }
}
