using System;

namespace ConsoleApp_PlayGround.Challenges.CoderByte
{
    public class CodeLandUsernameVailidation
    {

        public static string CodelandUsernameValidation(string str)
        {

            //rule 1
            int length = str.Length;
            if (String.IsNullOrEmpty(str) || (length <= 4 || length >= 25))
                return "false";

            //rule 2
            //rule 3
            if (!Char.IsLetter(str[0]) || str[length - 1] == '_')
                return "false";

            //rule 4
            if (!IsValidLetters(str))
                return "false";


            return "true";
        }

        public static bool IsValidLetters(string str)
        {
            foreach (char c in str)
            {
                if (Char.IsLetter(c))
                    return true;
                if (int.TryParse($"{c}", out int _))
                    return true;
                if (c == '_')
                    return true;
            }
            return false;
        }

        // keep this function call here
        public  static void Main()
        {

            Console.WriteLine(CodelandUsernameValidation(Console.ReadLine()));

        }

    }
}

