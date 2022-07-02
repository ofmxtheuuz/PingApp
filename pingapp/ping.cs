using System.Net.NetworkInformation;
using System.Net;

namespace pingapp
{
    class ping
    {
        public static void Ping(string url)
        {
            Ping p1 = new Ping();
            PingReply PR = p1.Send(url);
            // check when the ping is not success
            while (!PR.Status.ToString().Equals("Success"))
            {
                Console.WriteLine(PR.Status.ToString());
                PR = p1.Send(url);
            }

            // check after the ping is n success
            while (PR.Status.ToString().Equals("Success"))
            {
                Console.WriteLine(PR.Status.ToString());
                PR = p1.Send(url);
            }
        }
    }
}