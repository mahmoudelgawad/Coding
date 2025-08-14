using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp_PlayGround
{
    /*
     "MyLibrary1" -> "Class1"
    1- load assembly (path of dll)
    2- Get Type of loaded assembly (namespace.className )
    3- Activate classNameType
    4-Get Type of className

        -----------------
    classNameType.GetMembers() //return 'MemberInfo'
    classNameType.GetProperties() //return 'PropertyInfo'
        -----------------
    classNameType.InvokeMember("name", options...);
        -----------------
     */

    internal class Reflection
    {
        void test() 
        {
            Assembly.LoadFile("path of dll");
        }
    }
}
