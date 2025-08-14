using ConsoleApp_PlayGround.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayGround
{
    public class SelectFromArrayString
    {
        public string GetCarRegisteration() 
        {
            var data = GenerateData.CreateVehicleDetails();
            string registeration = (new string[] { data["Eire_Vrm"], data["VRM_Curr"], data["VRM_MVRIS"] }).Where(v => string.IsNullOrEmpty(v) == false).FirstOrDefault();
            return registeration;
        }
    }

    public class SelectFromArrayStringImplementation 
    {
        public static void Implement()
        {
         SelectFromArrayString selectFromArrayStringObj = new SelectFromArrayString();

            Console.WriteLine("#SelectFromArrayStringImplementation#");
            Console.WriteLine($"{selectFromArrayStringObj.GetCarRegisteration()}");
        }
    }


}
