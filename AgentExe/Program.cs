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
            //check class ClassAgent

            //ClassAgent a = new ClassAgent ("chili", 5);
            //a.SetClearanceLevel (0);
            //Console.WriteLine (a.GetClearanceLevel ());
            //a.Report();
            ////check class mission

            //Mission mission1 = new Mission ("har","gaza",a);
            //mission1.Brief ();
            //// check class inteltools
            //string increaptmsg = IntelTools.EncryptMessage("asdf");
            //IntelTools.LogTransmission(a.CodeName, "increaptmsg");

            ClassAgent unit8200 = new ClassAgent("dan", 5);

            Report rep = new Report();
            rep.UrgencyLevel = 4;
            MissionControl.AnalyzeReport(rep);
            IntelTools.LogTransmission(unit8200.CodeName, "There are riots in Gaza today.");




        }
    }
}
