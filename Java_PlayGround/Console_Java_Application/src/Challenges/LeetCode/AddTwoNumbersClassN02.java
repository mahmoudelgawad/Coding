package Challenges.LeetCode;

public class AddTwoNumbersClass
{
     public static ListNode addTwoNumbers(ListNode l1, ListNode l2) 
     {
        return addRecursion(l1,l2,0);
     }

     public static ListNode addRecursion(ListNode l1, ListNode l2, int carry)
     {
        if(l1 == null && l2 == null && carry == 0) return null;
        int res = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
        carry =(int) res / 10;
        return new ListNode(res%10, addRecursion(
                                        (l1 != null ? l1.next : null), 
                                        (l2 != null ? l2.next : null),
                                        carry));
     }
    //Runtime 0ms Beats 0%
    //Memory 0 MB Beats 0%
    public static boolean defaulTemplateLeetCode_Final(String s)
    {
        return true;
    }

    public static void implement()
    {
      var l1 = new ListNode(2,new ListNode(4,new ListNode(3,null)));
      var l2 = new ListNode(5,new ListNode(6,new ListNode(4,null)));
      var result = addTwoNumbers(l1,l2);
      ListNodeUtility.readList(result);       
    }
}