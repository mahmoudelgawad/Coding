using ConsoleApp_PlayGround.DTO;
using ConsoleApp_PlayGround.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApp_PlayGround.Serialization
{
    internal class SerializationClass
    {
        public void SerializeAsBinary() 
        {
            Employee employeeObj = new Employee();
            employeeObj.FirstName = "Mahmoud";
            employeeObj.LastName = "Ahmed";

            var binaryFormatter = new BinaryFormatter();
            var stream = new FileStream("data.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            binaryFormatter.Serialize(stream,employeeObj);
            stream.Close();

        }

        public void DeserializeAsBinary()
        {
            var binaryFormatter = new BinaryFormatter();
            var stream = new FileStream("data.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            Employee employeeObj = (Employee) binaryFormatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine($"{employeeObj.FirstName}, {employeeObj.LastName}");

            

        }
    }

    internal class SerializationImeplement : Iimplementation 
    {
        public static void Implement() 
        {
            SerializationClass ser = new SerializationClass();
            ser.SerializeAsBinary();
            ser.DeserializeAsBinary();
         
        }

        // explicit interface implemntation, with no any access modifier
        void Iimplementation.Implement() 
        {
            SerializationImeplement.Implement();
        }
    }
}
