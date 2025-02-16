using System;
using System.IO;

namespace DocumentosOrtobio
{
    public static class ActivityLogger
    {
        private static string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "activity_log.txt");

        public static void Initialize(string customLogFilePath)
        {
            logFilePath = customLogFilePath;
        }

        public static void Log(string activity)
        {
            string logMessage = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {GetLocalIPAddress()} - {Environment.UserName} - {activity}{Environment.NewLine}";
            File.AppendAllText(logFilePath, logMessage);
        }

        private static string GetLocalIPAddress()
        {
            var host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "Local IP Address Not Found!";
        }
    }
}