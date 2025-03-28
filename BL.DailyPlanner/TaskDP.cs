using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DailyPlanner
{
    public class DPTask
    {
        public static List<string> tasks = new List<string>();
        public static List<string> times = new List<string>();

        public static void AddTask(string task, string time)
        {


            DPTask.tasks.Add(task);
            DPTask.times.Add(time);


        }
    }
}

