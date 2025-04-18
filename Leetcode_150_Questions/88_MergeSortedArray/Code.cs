public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int totalLen = m + n - 1;
        while (n > 0 && m > 0)
        {
            if (nums1[m - 1] > nums2[n - 1])
            {
                nums1[totalLen--] = nums1[m - 1];
                m--;
            }
            else
            {
                nums1[totalLen--] = nums2[n - 1];
                n--;
            }
        }
        while (n > 0)
        {
            nums1[totalLen--] = nums2[n - 1];
            n--;
        }
        while (m > 0)
        {
            nums1[totalLen--] = nums1[m - 1];
            m--;
        }
    }
}