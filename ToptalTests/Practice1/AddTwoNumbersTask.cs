using System;
using System.Collections.Generic;
using System.Text;

namespace ToptalTests.Practice1
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
    }

    //You are given two non-empty linked lists representing two non-negative integers.
    //The digits are stored in reverse order, and each of their nodes contains a single digit.
    //Add the two numbers and return the sum as a linked list.
    //You may assume the two numbers do not contain any leading zero, except the number 0 itself.
    public class AddTwoNumbersTask
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode fake = new ListNode(0);
            ListNode p = fake;

            ListNode p1 = l1;
            ListNode p2 = l2;

            int carry = 0;
            while (p1 != null || p2 != null)
            {
                int sum = carry;
                if (p1 != null)
                {
                    sum += p1.val;
                    p1 = p1.next;
                }

                if (p2 != null)
                {
                    sum += p2.val;
                    p2 = p2.next;
                }

                if (sum > 9)
                {
                    carry = 1;
                    sum -= 10;
                }
                else
                {
                    carry = 0;
                }

                ListNode l = new ListNode(sum);
                p.next = l;
                p = p.next;
            }

            //don't forget check the carry value at the end
            if (carry > 0)
            {
                ListNode l = new ListNode(carry);
                p.next = l;
            }
            return fake.next;
        }
    }
}
