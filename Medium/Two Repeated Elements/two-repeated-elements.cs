// Problem: Two Repeated Elements
// Source: https://www.geeksforgeeks.org/batch/dsa-at-your-own-pace/track/DSASP-Searching/problem/two-repeated-elements-1587115621
// Synced using GFG Batch → GitHub Sync

class Solution {
    public int[] twoRepeated(int[] arr) {
        // code here
        int n = arr.Length-2;
        int[] result = new int[2];
        int idx = 0;
        bool[] seen = new bool[n+1];
        for(int i=0; i<arr.Length; i++){
            if(seen[arr[i]]){
                result[idx] = arr[i];
                idx++;
                
                if(idx == 2){
                    break;
                }
            }
            else{
                seen[arr[i]] = true;
            }
        }
        
        return result;
    }
}
