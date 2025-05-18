using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentExe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassAgent a = new ClassAgent ("chili", 5);
            a.SetClearanceLevel (0);
            Console.WriteLine (a.GetClearanceLevel ());
            a.Report();

            Mission mission1 = new Mission ("har","gaza",a);
            mission1.Brief ();

            string increaptmsg = IntelTools.EncryptMessage("asdf");
            IntelTools.LogTransmission(a.CodeName, increaptmsg);

        }
    }
}
