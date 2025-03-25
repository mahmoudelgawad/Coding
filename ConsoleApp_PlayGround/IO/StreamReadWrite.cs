using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp_PlayGround.IO
{
    internal class StreamReadWrite
    {
        private Stream _stream;

        public async Task<int> CreateWriteFileAsync(string pathFilename) 
        {
            Console.WriteLine("C W file START");
            await Task.Delay(3000);
           StreamWriter sw = new StreamWriter(pathFilename);
          await sw.WriteAsync("Hi Mahmoud!\r\n"+
                              $"{DateTime.Now.ToString()}");
           sw.Close();
            Console.WriteLine("C W file END");
            return 1;
        }
    }

    public class StreamReadWriteImplemntation 
    {
        public static async Task<int> ImplementAsync() 
        {
          StreamReadWrite streamReadWrite = new StreamReadWrite();
            await streamReadWrite.CreateWriteFileAsync("StreamReadWrite.txt");
            Console.WriteLine("StreamReadWrite.txt file called");
            return 1;
        } 
    }
}