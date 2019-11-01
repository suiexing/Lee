using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lee
{
    public class Solution
    {
        /// (1)
        /// <summary>
        /// 给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 整数，并返回他们的数组下标。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            int[] newNum = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {

                        newNum[0] = i;
                        newNum[1] = j;
                    }
                }
            }
            return newNum;
        }
        /// (2)
        /// <summary>
        /// 给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，并且它们的每个节点只能存储 一位 数字。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum2(int[] nums, int target)

        {
            int[] newNum = new int[2];
            List<int> T = nums.ToList();
            for (int i = 0; i < nums.Length; i++)
            {
                int num = target - nums[i];

                if (T.Contains(num))
                {
                    if (i != T.IndexOf(num))
                    {
                        newNum[0] = i;
                        newNum[1] = T.IndexOf(num);
                        return newNum;
                    }
                }
            }
            return newNum;
        }

        ///(3)
        /// <summary>
        /// 给定一个字符串，请你找出其中不含有重复字符的 最长子串 的长度。
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            ListNode p = l1;
            ListNode q = l2;
            int addNum = 0;
            while (q != null)
            {
                if (p.next == null && q.next != null)
                    p.next = new ListNode(0);
                if (q.next == null && p.next != null)
                    q.next = new ListNode(0);
                int sumAll = addNum + p.val + q.val;
                p.val = sumAll % 10;
                addNum = sumAll / 10;
                if (p.next == null && q.next == null)
                    break;
                p.next = new ListNode(addNum);
                p = p.next;
                q = q.next;
            }
            return l1;
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        //"abcabcbb"
        public int LengthOfLongestSubstring(string s)
        {
            int max=0;
            char[] charArray = s.ToCharArray();
            int k = 0;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (charArray[i] == charArray[j])
                    {
                        i = j + 1;
                        break;
                    }
                    if (i - j + 1 > k)
                        max = i - j + 1;
                }
            }
            return max;
        }

    }
}
