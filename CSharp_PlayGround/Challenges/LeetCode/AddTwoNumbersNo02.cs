using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //https://leetcode.com/problems/add-two-numbers/description/


    class AddTwoNumbersClass
    {

        //Not working with big digits numbers
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
            return  ListNodeUtility.CreateTheList(result.ToString().Reverse()
                      .Select(c => Convert.ToInt32($"{c}")).ToArray());
        }


        //using recursion method with carry&total (/10, %10) divisions 
        public static ListNode AddTwoNumbers_Final(ListNode l1, ListNode l2)
        {
            return AddTwoNumbersRec(l1,l2);
        }

        private static ListNode AddTwoNumbersRec(ListNode l1, ListNode l2, int carry = 0) 
        {
            //First Line is hardest to imagine when to quit :)
            if (l1 == null && l2 == null && carry == 0) return null;
            int total = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
            carry = total / 10;
            //'?' null conditional operator
            return new ListNode(total % 10, AddTwoNumbersRec(l1?.next, l2?.next, carry));
        }


        public static void Implement()
        {

            
            ListNode l1 = ListNodeUtility.CreateTheList(new int[] { 2, 4, 3 });
            ListNode l2 = ListNodeUtility.CreateTheList(new int[] { 5, 6, 4 });
            
            var result = AddTwoNumbers_Final(l1, l2);   
            ListNodeUtility.ShowTheList(result);
            Console.WriteLine("");

            l1 = ListNodeUtility.CreateTheList(new int[] { 9 });
            l2 = ListNodeUtility.CreateTheList(new int[] { 1,9,9,9,9,9,9,9,9,9});

            result = AddTwoNumbers_Final(l1, l2);
            ListNodeUtility.ShowTheList(result);
            Console.WriteLine("");
            

        }

    }
}
