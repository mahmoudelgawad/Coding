using System;

namespace ConsoleApp_PlayGround
{
    internal class SpanClass
    {
        //# Span is struct , value type , memory safe for searching, filtering or select from Array/String without allocate extra memory 
        public void ArrayToSpan() 
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            Span<int> spanIntArr = arr;
            var res = spanIntArr.Slice(start: 3, length: 4);
            
            int val = res[3];
        }

        public void StringToReadOnlySpan() 
        {
            string text = "mahmoud ahmed";
            ReadOnlySpan<char> spn = text.AsSpan();
            spn.Slice(3);

            char val = spn[3];
        }

        public int FindFirstIndexOccurrence(string str, string target) 
        {
            for (int i = 0; i <= str.Length - target.Length; i++) 
            {
                //#instead using string.Substring
                if (str.AsSpan(i, target.Length).SequenceEqual(target)) return i;
            }
            return -1;
        }

    }

    public class SpanClassImplementation 
    {
        public static void Implmenet() 
        {
            SpanClass sp = new SpanClass();
            int res = sp.FindFirstIndexOccurrence("leetcode", "tco");
        }
    }
}
