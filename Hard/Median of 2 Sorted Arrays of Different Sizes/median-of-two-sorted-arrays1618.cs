// Problem: Median of 2 Sorted Arrays of Different Sizes
// Source: https://www.geeksforgeeks.org/batch/dsa-at-your-own-pace/track/DSASP-Searching/problem/median-of-two-sorted-arrays1618
// Synced using GFG Batch → GitHub Sync

class Solution {
    public double medianOf2(int[] a, int[] b) {
        // code here
        int n1 = a.Length;
        int n2 = b.Length;
        int i=0;
        int j=0;
        int k=0;
        int[] temp = new int[n1+n2];
        while(i<n1 && j<n2){
            if(a[i] <= b[j]){
                temp[k] = a[i];
                i++;
                k++;
            }
            else{
                temp[k] = b[j];
                j++;
                k++;
            }
        }
        
        while(i<n1){
            temp[k] = a[i];
            i++;
            k++;
        }
        
        while(j<n2){
            temp[k]=b[j];
            k++;
            j++;
        }
        
        if((n1+n2)%2 != 0){
           return temp[(n1+n2)/2]; 
        }
        
        int idx = (n1+n2)/2;
        return (temp[idx]+temp[idx-1])/2.0;
    }
}
