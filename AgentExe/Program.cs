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
            
            a.Report();
        }
    }
}
