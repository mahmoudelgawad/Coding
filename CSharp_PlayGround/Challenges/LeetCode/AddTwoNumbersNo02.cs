using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //https://leetcode.com/problems/add-two-numbers/description/


    class AddTwoNumbersClass
    {

        //Runtime 0ms Beats 0%
        //Memory 0MB Beats 0%
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            StringBuilder strBN1 = new StringBuilder();
            StringBuilder strBN2 = new StringBuilder();
            while (true) 
            {              
                strBN1.Append(l1.val);
                if (l1.next == null) break;
                l1 = l1.next;
            }
            while (true)
            {
                strBN2.Append(l2.val);
                if (l2.next == null) break;
                l2 = l2.next;
            }

           long n1;
           long n2;
           long.TryParse(string.Join("",strBN1.ToString().Reverse()),out n1);
           long.TryParse(string.Join("",strBN2.ToString().Reverse()),out n2);
           
            long result = n1 + n2;
            return  CreateTheList(result.ToString().Reverse()
                      .Select(c => Convert.ToInt32($"{c}")).ToArray());
        }


        //Runtime 0ms Beats 0%
        //Memory 0 MB Beats 0%
        public static bool AddTwoNumbers_Final(string s)
        {
            return true;
        }

        private static ListNode CreateTheList(int[] values)
        {
            ListNode ln = null;
            ListNode first = null;
            values.ToList().ForEach(v => {
                if (ln == null)
                    ln = new ListNode(val: v);
                else if (ln.next == null)
                {
                    ln.next = new ListNode(val: v);
                    ln = ln.next;
                }

                if (first == null) first = ln;

            });
           return first;
        }

        private static void ShowTheList(ListNode ln) 
        {
            if (ln == null) return; 
            Console.Write(ln.val);
            ln = ln.next;
            ShowTheList(ln);
        }

        public static void Implement()
        {
            ListNode l1 = CreateTheList(new int[] { 2, 4, 3 });
            ListNode l2 = CreateTheList(new int[] { 5, 6, 4 });
            
            var result = AddTwoNumbers(l1, l2);   
            ShowTheList(result);
            Console.WriteLine("");

            l1 = CreateTheList(new int[] { 9 });
            l2 = CreateTheList(new int[] { 1,9,9,9,9,9,9,9,9,9});

            result = AddTwoNumbers(l1, l2);
            ShowTheList(result);
            Console.WriteLine("");

        }

    }
}
