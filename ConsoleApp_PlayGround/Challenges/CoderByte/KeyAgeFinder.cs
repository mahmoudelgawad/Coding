using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.Challenges.CoderByte
{
    public class KeyAgeFinder
    {
        public async Task FindKeyAge()
        {
            HttpClient client = new HttpClient();
            string s = await client.GetStringAsync("https://coderbyte.com/api/challenges/json/age-counting");
            s = s.Replace("{","").Replace("}","").Replace("\"","").Replace("data","").Replace(":","")
                .Replace(" ","");
            var response = s.Split(",");
            int counter = 0;
            for (int i = 0; i < response.Length; i++)
            {
                if (i + 1 >= response.Length) 
                {
                    break;
                }   
                if (response[i + 1].ToLower().Contains("age"))
                {
                    var ageArr = response[i + 1].Split("=");
                    int age;
                    int.TryParse(ageArr[1], out age);
                    if (age >= 50)
                    {
                        //SearchResult.Add(response[i]);
                        //SearchResult.Add(response[i + 1]);
                        ++counter;
                    }
                    if (i + 2 < response.Length)
                    {
                        ++i;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
