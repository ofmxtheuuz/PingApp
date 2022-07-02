using System.Net.NetworkInformation;
using System.Net;

namespace pingapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("     pingapp");
            Console.Write("URL: ");
            string url = Console.ReadLine();
            ping.Ping(url);
        }
    }
}