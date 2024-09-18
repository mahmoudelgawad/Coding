using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{

    //Reference
    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record#positional-syntax-for-property-definition

    //using with primary constructor, on onlys record make public properties from primary constructor parameters
    public record PersonPrim(string FirstName, string LastName);

    public record PersonRequiredInit
    {
        public required string FirstName { get; init; }
        public required string LastName { get; init; }
    };

    public record Person
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    };

    /// <summary>
    /// value type
    /// </summary>
    /// 

    //readonly will make init properties
    public readonly record struct PointPrim(double X, double Y, double Z);
    public record struct Point
    {
        public double X { get; init; }
        public double Y { get; init; }
        public double Z { get; init; }
    }
    /*
     While records can be mutable, they're primarily intended for supporting immutable data models. The record type offers the following features:

    Concise syntax for creating a reference type with immutable properties
    Built-in behavior useful for a data-centric reference type:
        Value equality
        Concise syntax for nondestructive mutation
        Built-in formatting for display
    Support for inheritance hierarchies
     */
    public class RecordClassImplementation
    {
        public static void Implement() 
        {
            var personPrim = new PersonPrim("firstname","lastname");
            var personRequiredInit = new PersonRequiredInit { FirstName="",LastName="" };
            
            // Error
            //personRequiredInit.FirstName = "sdsds"; 

            var pointPrim = new PointPrim();
            //Error
            //pointPrim.X=12;
        }

    }
}
