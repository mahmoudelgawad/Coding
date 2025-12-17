namespace MagicVillaAPI.CustomLogging
{
    public class Logging :ILogging
    {
        public void LogInformation(string message) 
        {
            Console.WriteLine($"#CUSTOM_INFO_LOG - {message}");
        }


        public void LogError(string message) 
        {
            Console.WriteLine($"#CUSTOM_ERROR_LOG - {message}");
        }
    }
}
