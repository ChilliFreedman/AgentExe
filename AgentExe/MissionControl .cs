using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentExe
{
    static class MissionControl
    {
        //If UrgencyLevel == 3 => print "High priority. Monitor closely."

        static public void AnalyzeReport(Report r)
        {
            if (r.UrgencyLevel >= 4)
            {
                Console.WriteLine("Immediate response required.");

            }
            else if (r.UrgencyLevel == 3)
            {
                Console.WriteLine("High priority. Monitor closely.");

            }
            else
            {
                Console.WriteLine("Routine analysis.");
            }
        }
    }
}
