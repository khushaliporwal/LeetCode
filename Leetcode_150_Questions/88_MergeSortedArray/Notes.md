Beats: 100%, Runtime: 0ms

- Goal:
	Merge two sorted arrays nums1 and nums2 into one sorted array, in-place in nums1.

- How it works:
	1. Start filling nums1 from the end to avoid overwriting its original values.
	2. Use a pointer totalLen = m + n - 1 to track where to place the next largest value.
	3. Compare the last elements of nums1 and nums2:
	4. Place the larger one at totalLen.
	5. Move the corresponding pointer (m or n) back.
	6. After one array is exhausted, copy any remaining elements from nums2 into nums1.

-  Time Complexity: O(m + n)
-  Space Complexity: O(1)

`int[] nums1 = {1, 3, 5, 0, 0, 0}; // m = 3`   
`int[] nums2 = {2, 4, 6};          // n = 3`   

totalLen = m + n - 1 = 5 (last index of nums1)

## Step-by-Step Merge Process

| m | n | nums1                  | Action                                 |
|---|---|------------------------|----------------------------------------|
| 3 | 3 | {1, 3, 5, 0, 0, 0}     | Compare 5 and 6 → place 6 at index 5   |
| 3 | 2 | {1, 3, 5, 0, 0, 6}     | Compare 5 and 4 → place 5 at index 4   |
| 2 | 2 | {1, 3, 5, 0, 5, 6}     | Compare 3 and 4 → place 4 at index 3   |
| 2 | 1 | {1, 3, 5, 4, 5, 6}     | Compare 3 and 2 → place 3 at index 2   |
| 1 | 1 | {1, 3, 3, 4, 5, 6}     | Compare 1 and 2 → place 2 at index 1   |
| 1 | 0 | {1, 2, 3, 4, 5, 6}     | Done! Remaining values already in place |

