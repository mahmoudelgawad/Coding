using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.ParallelThread
{
    internal class ParallelThreadClass
    {
        public void CreateThreads() 
        {
            Thread t1 = new Thread(Method1);
            t1.Start();
            Thread t2 = new Thread(Method2);
            t2.Start();
            Thread t3 = new Thread(Method3);
            t3.Start();
            Thread t4 = new Thread(Method4);
            t4.Start();
        }

        public void CreateTasks()
        {
            Task t1 = new Task(Method1);
            t1.Start();
            Task t2 = new Task(Method2);
            t2.Start();
            Task t3 = new Task(Method3);
            t3.Start();
            Task t4 = new Task(Method4);
            t4.Start();
        }

        private void Method1() 
        {
            Thread.Sleep(1000);
            Console.WriteLine("Method1");
        }
        private void Method2()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Method2");
        }
        private void Method3()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Method3");
        }
        private void Method4()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Method4");
        }
    }

    public class ParallelThreadClassImplementation
    {
        public static void Implement()
        {
            ParallelThreadClass parallelThreadClass = new ParallelThreadClass();
            parallelThreadClass.CreateThreads();
            parallelThreadClass.CreateTasks();
        }
    }
}
