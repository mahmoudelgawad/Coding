using System;
using System.Linq;


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
            int qCounter = 0;
            char startDigit = 'n';
            char endDigit = 'n';
            string result = "false";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '?' && startDigit != 'n')
                {
                    ++qCounter;
                }
                if (char.IsDigit(str[i]))
                {
                    if (startDigit == 'n')
                    {
                        startDigit = str[i];
                    }
                    else if (endDigit == 'n')
                    {
                        endDigit = str[i];

                        if ((int)(char.GetNumericValue(startDigit) + (int)char.GetNumericValue(endDigit)) == 10 && qCounter == 3)
                        {
                            result = "true";
                            startDigit = endDigit;
                            endDigit = 'n';
                        }
                        else if ((int)(char.GetNumericValue(startDigit) + (int)char.GetNumericValue(endDigit)) == 10 && qCounter != 3)
                        {
                            return "false";
                        }
                    }
                }
            }
            return result;
        }

        // keep this function call here
        public static void Implement()
        {
            string str = "fun&!! time";
            Console.WriteLine(LongestWord(str));

            str = "I love dogs";
            Console.WriteLine(LongestWord(str));



        }

    }
}
