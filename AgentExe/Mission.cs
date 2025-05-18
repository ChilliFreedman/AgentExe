using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentExe
{
    internal class Mission
    {
        public string MissionName;
        public string TargetLocation;
        public ClassAgent AssignedAgent;

        public Mission(string missionName, string targetLocation, ClassAgent assignedAgent)
        {
            this.MissionName = missionName;
            this.TargetLocation = targetLocation;
            this.AssignedAgent = assignedAgent;
        }

        public void Brief()
        {
            Console.WriteLine($"Mission: {MissionName}, Target: {TargetLocation},Agent: {AssignedAgent.CodeName}");
        }

    }
}
