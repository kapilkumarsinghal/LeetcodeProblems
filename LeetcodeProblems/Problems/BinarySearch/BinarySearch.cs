using System;

namespace LeetCodeProblems.Problems.BinarySearch {

    class BinarySearch {
        public void solve() {
            string temp = Console.ReadLine();
            string[] tempString = temp.Split(',');
            int[] nums = new int[tempString.Length];
            for (int i = 0; i < tempString.Length; i++)
            {
                nums[i] = Convert.ToInt32(tempString[i]);
            }
            int target = Convert.ToInt32(Console.ReadLine());
            int res = binarySearch(nums,target);
            Console.WriteLine("res is {0}", res);
        }

            public int binarySearch(int[] nums, int target) {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                //Console.WriteLine("Mid is {0}{1}{2}",mid,left,right);
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }


            return -1;

        }
    }
}