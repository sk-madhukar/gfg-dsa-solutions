// Problem: Problem Solved Successfully
// Source: https://www.geeksforgeeks.org/problems/second-largest3735/1
// Synced using GFG Batch → GitHub Sync

class Solution {
    public int getSecondLargest(int[] arr) {
        // code here
        int largest = arr[0];
        int secondLargest = -1;
        
        for(int i=1; i<arr.Length; i++){
            if(arr[i] > largest){
                secondLargest = largest;
                largest = arr[i];
            }
            
            if(arr[i] < largest && arr[i] > secondLargest)
            {
                secondLargest = arr[i];
            }
        }
        
        return secondLargest;
    }
}
