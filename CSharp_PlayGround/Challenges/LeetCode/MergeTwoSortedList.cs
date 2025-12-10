using System;


namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    //https://leetcode.com/problems/merge-two-sorted-lists/description/

    
    class MergeTwoSortedListClass
    {

        //Runtime 0ms Beats 0%
        //Memory 0MB Beats 0%
        public static ListNode MergeTwoSortedList(ListNode list1, ListNode list2)
        {
            //WRONG ANSWER, not handle null, not order ascending
            ListNode result = null;
            ListNode resultHead = null;
            while (list1!= null || list2!= null) 
            {
                if (result == null)
                {
                    result = new ListNode(
                        list1 != null && list1.val < list2.val ? list1.val : list2.val,
                        list2 != null ? list2 : list1);

                    resultHead = result;

                    list1 = list1 != null ? list1.next : null;
                    list2 = list2 != null ? list2.next : null;
                }
                else 
                {
                    result.next = list1 != null && list1.val < list2.val ? list1 : list2;

                    list1 = list1 != null ? list1.next : null;
                    //ask if need switch to next node in List2
                    if(result.next.val == list2.val)
                        list2 = list2 != null ? list2.next : null;
                }              
                result = result.next;
            }
            return resultHead;
        }


        //Runtime 0ms Beats 0%
        //Memory 0 MB Beats 0%
        public static ListNode MergeTwoSortedList_Final(ListNode list1, ListNode list2)
        {
            //using recursion instead of while loop
            if (list1 == null) return list2;
            if (list2 == null) return list1;
            if (list1.val < list2.val)
            {
                list1.next = MergeTwoSortedList_Final(list1.next, list2);
                return list1;
            }
            else 
            {
                //for examble (1,2,4)(1,3,4)
                //here the start point recuresion calling loop
                //so it will return list2 at the end as first head node
                list2.next = MergeTwoSortedList_Final(list1, list2.next);
                return list2;
            }
        }
        public static void Implement()
        {
            ListNode n1 = new(1, new ListNode(2, null));
            ListNode n2 = new(3, new ListNode(4, null));
            var result = MergeTwoSortedList_Final(n1, n2);
            PrintResultNodes(result);

            n1 = new(1, new ListNode(2, new ListNode(4, null)));
            n2 = new(1, new ListNode(3, new ListNode(4, null)));
            result = MergeTwoSortedList_Final(n1, n2);
            PrintResultNodes(result);

            n1 = null;
            n2 = new(1, new ListNode(2, null));
            result = MergeTwoSortedList_Final(n1, n2);
            PrintResultNodes(result);
        }
        private static void PrintResultNodes(ListNode result) 
        {
            while (result != null) 
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
            Console.WriteLine("--------------------------");
        }

    }
}
