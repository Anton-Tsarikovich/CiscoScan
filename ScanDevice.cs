using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinimalisticTelnet;
using System.Globalization;
using System.IO;

namespace CiscoScan
{
    class ScanDevice
    {
        static DirectoryInfo pathName = new DirectoryInfo(@"D:\ScanCiskoDevices\");
        public static string TelnetScan(string userName, string password, string ip, string command)
        {
            String outMessage = "";
            TelnetConnection tc = new TelnetConnection();
            String tcpOut = tc.Login(ip,userName, password, 100);
            if (tcpOut == "error")
                return "I can't connect to device";
            System.Threading.Thread.Sleep(100);
            tc.WriteLine(command);
            System.Threading.Thread.Sleep(1000);
            outMessage += tc.Read();
            while (outMessage.Remove(0, outMessage.Length - 10).Contains("More"))
            {
                tc.WriteLine(" ");
                System.Threading.Thread.Sleep(100);
                outMessage += tc.Read();
            }
           // if (outMessage.Contains("Authentication failed") || outMessage.Contains("Password") || outMessage == "")
              //  return "Authentication failed";
            System.Threading.Thread.Sleep(100);
            tc.WriteLine("exit");
            return outMessage;
        }
        public static void WriteToFile(string text, string command, string ip)
        {

            new DirectoryInfo(pathName.ToString() + command).Create();
            File.WriteAllText(pathName.ToString() + command + @"\" + ip + ".txt", text);
        }
        public static string[] ReadFromFile(string command, string ip)
        {
            if (File.Exists(pathName.ToString() +  command + @"\" + ip + ".txt"))
            {
                try
                {
                    String[] allText = File.ReadAllLines(pathName.ToString() +  command + @"\" + ip + ".txt");
                    return allText;
                }
                catch (FileNotFoundException e)
                {
                    return null;
                }
            }
            else
                return null;
        }
    }
}
