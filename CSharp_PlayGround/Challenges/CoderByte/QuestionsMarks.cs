using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.Challenges.CoderByte
{
    class QuestionsMarksClass
    {
        private static StringBuilder strb;
        public static string QuestionsMarks_answer(string str)
        {
            string result = "false";
            int qcounter = 0;
            char prevdigit = 'a';
            char curdigit = 'a';
            for (int i = 0; i < str.Length; i++)
            {
                char digit = str[i];
                if (digit == '?')
                {
                    qcounter++;
                }
                if (Char.IsDigit(digit))
                {

                    if (prevdigit == 'a')
                    {
                        prevdigit = digit;
                    }
                    else if (curdigit == 'a')
                    {
                        curdigit = digit;
                        ///Console.Write((int)char.GetNumericValue(prevdigit) + (int)char.GetNumericValue(curdigit) + ":"+qcounter);
                        if ((int)char.GetNumericValue(prevdigit) + (int)char.GetNumericValue(curdigit) == 10 && qcounter == 3)
                        {
                            result = "true";
                            prevdigit = curdigit;
                            curdigit = 'a';
                        }
                        else if ((int)char.GetNumericValue(prevdigit) + (int)char.GetNumericValue(curdigit) == 10 && qcounter != 3)
                        {
                            return "false";
                        }

                    }
                    qcounter = 0;
                }
            }

            return result;
        }
        public static string QuestionsMarks_final(string str)
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
        public static string QuestionsMarks_Recursion(string str)
        {
            return searchingSteps(str);
        }
        private static string searchingSteps(string str)
        {
            var startIndex = str.IndexOf("???");
            if (startIndex < 0)
            {
                return "false";
            }


            if (isBetweenDigit(str, startIndex))
            {
                return "true";
            }
            else if ((str.Length - (startIndex + 2)) > 3)
            {
                //replace first found ??? to ###, then repeat again as recursion
                //call self method
                strb = new StringBuilder(str);
                strb[startIndex] = '#';
                strb[startIndex + 1] = '#';
                strb[startIndex + 2] = '#';
                return searchingSteps(strb.ToString());
            }

            return "false";
        }
        private static bool isBetweenDigit(string str, int startIndex)
        {
            //go left
            bool leftDigit = str.Substring(0, startIndex).ToList()
                .Select(c => int.TryParse(c.ToString(), out int n) ? n : (int?)null)
                .Any(n => n != null);

            //go right      
            bool rightDigit = str.Substring(startIndex + 3, str.Length - (startIndex + 3)).ToList()
                .Select(c => int.TryParse(c.ToString(), out int n) ? n : (int?)null)
                .Any(n => n != null);

            return leftDigit && rightDigit ? true : false;
        }

        // keep this function call here
        public static void Implement()
        {
            string str = "mahmoud3???7sdmks2fff???gg5";
            Console.WriteLine(QuestionsMarks_final(str));

            str = "mahmouda???bsdmks2fff???gg5";
            Console.WriteLine(QuestionsMarks_final(str));

            str = "mahmouda??5?bsdmksvfff??5?";
            Console.WriteLine(QuestionsMarks_final(str));

            str = "mahmouda???bsdmksvfff???";
            Console.WriteLine(QuestionsMarks_final(str));

            str = "9???1???9??1???9";
            Console.WriteLine(QuestionsMarks_final(str));

            str = "5??aaaaaaaaaaaaaaaaaaa?5?5";
            Console.WriteLine(QuestionsMarks_final(str));

        }

    }
}
