using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround.AttributeInfo
{
    //public abstract partial class Attribute,
    //contains private and public methods
    internal class HelpTextAttribute : Attribute
    {
        public string HelpText { get; set; }
    }
}
