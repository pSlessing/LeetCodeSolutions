public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        
        int[] nums3 = new int[(nums1.Length + nums2.Length)];
        int nums1index = 0;
        int nums2index = 0;


        //Do a partial merge of the two arrays
        for(int i = 0; i < ((nums1.Length + nums2.Length + 2) / 2); i++)
        {
            //Make sure empty arrays are ignored
            if(nums1index < nums1.Length && nums2index < nums2.Length)
            {
                if(nums1[nums1index] < nums2[nums2index])
                {
                    nums3[i] = nums1[nums1index];
                    nums1index++;
                }
                else
                {
                    nums3[i] = nums2[nums2index];
                    nums2index++;
                }
            }
            else if(nums1index == nums1.Length)
            {
                nums3[i] = nums2[nums2index];
                nums2index++;
            }
            else
            {
                nums3[i] = nums1[nums1index];
                nums1index++;
            }
        }

        //Check total length of nums3 array, and return result based on that
        if((nums1.Length + nums2.Length) % 2 == 0)
        {
            int middleValue = nums3.Length / 2;
            return ((double)nums3[middleValue] + (double)nums3[middleValue - 1]) / 2;
        }
        else
        {
            return nums3[nums3.Length / 2];
        }

    }
}
