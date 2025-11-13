using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace ConsoleApp_PlayGround.Challenges.HackerRank
{
    //URL
    //IBM EG code examp 24 Oct 2025
    
    class DecodeNumericStringASCIIClass
    {
        //Runtime 0ms Beats 0%
        //Memory 0MB Beats 0%
       
        //#using range operator
        //#error not complete
        public static string Decode(string encode)
        {
            if (string.IsNullOrEmpty(encode)) return "";
            var chArr = encode.Reverse().ToArray();
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < chArr.Length; i++) 
            {
                //#error need fix exceed the chArr length
               char ch = (char)Convert.ToInt32(string.Join("",chArr[i..(i+2)]));
                if (char.IsAsciiLetter(ch) || ch == ' ') i += 1;
                else 
                {
                    ch = (char)Convert.ToInt32(string.Join("",chArr[i..(i+3)]));
                    i += 2;
                }
                str.Append(ch);
            }

            return str.ToString();
        }

        public static string Decode_Final(string encode)
        {
            if (string.IsNullOrEmpty(encode)) return "";
            var chArr = encode.Reverse().ToArray();
            StringBuilder result = new StringBuilder();
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < chArr.Length; i++)
            {
                str.Append(chArr[i]);
                if (str.Length >= 2) 
                {
                    char ch = (char)Convert.ToInt32(str.ToString());
                    if (char.IsAsciiLetter(ch) || ch == ' ')
                    {
                        result.Append(ch);
                        str.Clear();
                    }
                    else if (str.Length > 2) str.Clear();
                }
            }

            return result.ToString();
        }


        public static void Implement()
        {
            string encode = "701011792823411101701997927";
            string result = Decode_Final(encode);
            Console.WriteLine(result);
        }

    }
}
