using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.Challenges.LeetCode
{
    public class ListNodeUtility
    {
        public static ListNode CreateTheList(int[] values)
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

        public static void ShowTheList(ListNode ln)
        {
            if (ln == null) return;
            Console.Write(ln.val);
            ln = ln.next;
            ShowTheList(ln);
        }
    }
}
