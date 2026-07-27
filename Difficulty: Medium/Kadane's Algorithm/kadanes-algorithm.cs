class Solution {
    public int maxSubarraySum(int[] arr) {
        // code here
          // code here
        int res = arr[0];
        int maxEnding = arr[0];
        
        for(int i=1; i<arr.Length; i++){
            maxEnding = Math.Max(maxEnding+arr[i], arr[i]);
            res = Math.Max(res, maxEnding);
        }
        
        return res;
    }
}