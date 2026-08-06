// Problem: Maximum Area Between Bars
// Source: https://www.geeksforgeeks.org/batch/dsa-at-your-own-pace/track/DSASP-Searching/problem/maximum-water-between-two-buildings
// Synced using GFG Batch → GitHub Sync

class Solution {
	public int maxArea(int[] height) {
		// code here
		int n = height.Length;
		
		
		//Brute Force. TC:O(n^2)
		/*
		int area = 0;
		for (int i = 0; i<n - 1; i++) {
			for (int j = i + 1; j<n; j++) {
				area = Math.Max(area, Math.Min(height[i],height[j])*(j - i-1));
			}
		}
		*/
		
		//Time Complexity: O(n)
		int left = 0;
		int right = n-1;
		int area = 0;
		while(left < right)
		{
		    area = Math.Max(area, Math.Min(height[left], height[right]) * (right-left-1));
		    if(height[left] < height[right]){
		        left++;
		    }
		    else{
		        right--;
		    }
		}
		
		return area;
	}
};
