using System;
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
                l1 = l2.next;
            }

           int n1;
           int n2;
           int.TryParse(string.Join("",strBN1.ToString().Reverse()),out n1);
           int.TryParse(string.Join("",strBN2.ToString().Reverse()),out n2);
           
           int result = n1 + n2;
            ListNode resultListNode = null;
            ListNode firstNode = null;
            foreach (char ch in result.ToString().Reverse())
            {
              resultListNode = new ListNode(val: Convert.ToInt32(ch));
              if (firstNode == null) firstNode = resultListNode;
              resultListNode = resultListNode.next;                      
            } 
            return firstNode;
        }


        //Runtime 0ms Beats 0%
        //Memory 0 MB Beats 0%
        public static bool AddTwoNumbers_Final(string s)
        {
            return true;
        }

        public static void Implement()
        {
            /* 
             string s = "({})";
             Console.WriteLine(AddTwoNumbers(s));

             s = "()";
             Console.WriteLine(AddTwoNumbers(s));
            */


            /*
              int start = DateTime.Now.Millisecond;
              Console.WriteLine(AddTwoNumbers_Final(haystack,needle));
              Console.WriteLine(DateTime.Now.Millisecond - start);  
             */
        }

    }
}
