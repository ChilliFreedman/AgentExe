using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AgentExe
{
    static class IntelTools
    {
        static public string EncryptMessage(string msg)
        {
            return new string(msg.Reverse().ToArray());


        }

        static public void LogTransmission(string agentName, string message)
        {
            Console.WriteLine($"{agentName} sent encrypted message: {message}");
        }
    }
}
