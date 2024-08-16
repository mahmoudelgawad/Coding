using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    internal abstract class AbstractClass
    {
        protected int age;
        protected string name;
        protected string address = "defaulrAddress";

        public abstract string GetName();

        // can conatin complete method implementation Vs Interface
        // not should all members to be abstract
        // as static class members should static
        public int GetAge() 
        {
            return age;
        }
    }

    internal class AbstractClassSon : AbstractClass 
    {
        public AbstractClassSon(string name ,int age, string address) 
        {
            base.name = name;
            base.age = age;
            base.address = address;
        }

        public override string GetName() 
        {
            return $"{name}, Address:{address}";
        }
    }

    public class AbstractClassImplementation 
    {
        public static void Implement() 
        {
            var c = new AbstractClassSon("Mahmoud",40,"Nozha");
            Console.WriteLine(c.GetName());
            Console.WriteLine(c.GetAge());
            //Console.WriteLine(c.address); //ERROR: it's protected 
        }
    }
}
