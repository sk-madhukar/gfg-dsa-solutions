// Problem: Count Only Repeated
// Source: https://www.geeksforgeeks.org/batch/dsa-at-your-own-pace/track/DSASP-Searching/problem/count-only-repeated2047
// Synced using GFG Batch → GitHub Sync

class Solution {
    public List<int> findRepeating(int[] arr) {
        // code here
        
        int n = arr.Length;
        // int[] freq = new int[n+1];
        // for(int i=0; i<n; i++){
        //     freq[arr[i]]++;
        // }
        // for(int i=0; i<freq.Length; i++){
        //     if(freq[i] > 1){
        //         return new List<int>{i, freq[i]};
        //     }
        // }
        // return new List<int>{-1, -1};
        
        int repeated = -1;
        int count = -1;
        int i = 1;
        for(; i<n; i++){
            if(arr[i] == arr[i-1]){
                repeated = arr[i];
                count = 2;
                break;
            }
        }
        int j = i+1;
        while(j<n && arr[j] == repeated){
            count++;
            j++;
        }
        return new List<int>{repeated, count};
    }
}
