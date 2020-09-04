using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace Wwbweibo.Utils.Net
{
    public static class IpUtils
    {
        public static string GetCurrentIpAddress()
        {
            return NetworkInterface.GetAllNetworkInterfaces()
                .Where(p => p.OperationalStatus == OperationalStatus.Up)
                .Select(p => p.GetIPProperties())
                .SelectMany(p => p.UnicastAddresses)
                .FirstOrDefault(p =>
                    !IPAddress.IsLoopback(p.Address) && p.Address.AddressFamily == AddressFamily.InterNetwork)?.Address
                .ToString();
        }
    }
}