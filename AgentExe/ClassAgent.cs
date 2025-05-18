using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentExe
{
    internal class ClassAgent
    {
        public string CodeName;
        private int ClearanceLevel;
        
        public ClassAgent(string codeName,int clearanceLevel)
        {
            this.CodeName = codeName;
            this.ClearanceLevel = clearanceLevel;
        }

        public int GetClearanceLevel()
        {
            return ClearanceLevel;

        }

        public void SetClearanceLevel(int level)
        {
            if (level >= 1 && level <= 5)
            {
                ClearanceLevel = level;
            }
        }
        public void Report()
        {
            Console.WriteLine($"Agent {CodeName} reporting. Clearance Level:{ClearanceLevel}");
        }
    }
}
