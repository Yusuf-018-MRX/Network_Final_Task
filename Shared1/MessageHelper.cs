namespace Shared
{
    public class MessageHelper
    {
        public static void FormatMessage(string command, string key, string value = "")
        {
            if (value != "")
            {
                Console.WriteLine($"{command} {key} {value}");
            }
            else 
            {
                Console.WriteLine($"{command} {key}");
            }
        }
    }
}