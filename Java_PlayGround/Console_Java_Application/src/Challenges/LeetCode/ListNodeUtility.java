package Challenges.LeetCode;

public class ListNodeUtility 
{
    public static void readList(ListNode list)
    {
        while(list != null)
            {
                System.out.print(list.val + " ");
                list = list.next;
            }

    }   
}
