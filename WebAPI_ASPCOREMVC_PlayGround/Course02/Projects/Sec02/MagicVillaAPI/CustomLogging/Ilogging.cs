namespace MagicVillaAPI.CustomLogging
{
    public interface ILogging
    {
        //#functions name same as Microsoft Logger
     void LogInformation(string message);
     void LogError(string message);
    }
}
