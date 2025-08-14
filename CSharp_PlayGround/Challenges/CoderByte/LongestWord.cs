using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace ConsoleApp_PlayGround.Challenges.CoderByte
{
    class LongestWordClass
    {
        public static string LongestWord(string str)
        {
            var words = str.Split(' ')
                        .Select(word => 
                            string.Join("",
                                       word.Select(ch => char.IsPunctuation(ch) ? (char?)null : ch )
                                       )
                               )
                        .ToList();
            words.Remove(null);
            return words.OrderByDescending(word => word.Length).FirstOrDefault();
        }
        public static string LongestWord_final(string str)
        {
            Regex rgx = new Regex(@"[^\w\s]");
            string[] strArr = rgx.Replace(str, "").Split(" ");
            return strArr.OrderByDescending(w => w.Length).FirstOrDefault();

            //JAVASCRIPT
            /*var arr = sen.match(/[a-z]+/gi);

            // the array sort function takes a function as a parameter
            // which is used to compare each element in the array to the
            // next element in the array
            var sorted = arr.sort(function(a, b) {
              return b.length - a.length;*/
        }

        // keep this function call here
        public static void Implement()
        {
            string str = "fun&!! time";
            Console.WriteLine(LongestWord_final(str));
            str = "I love dogs";
            Console.WriteLine(LongestWord_final(str));

            /*string str = "fun&!! time";
            Console.WriteLine(LongestWord(str));
            str = "I love dogs";
            Console.WriteLine(LongestWord(str));*/

        }

    }
}
