using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DailyPlanner
{
    public class DPplan
    {
        public static List<string> plan = new List<string>();
        public static List<string> times = new List<string>();

        public static void AddPlan(string plan, string time)
        {
            DPplan.plan.Add(plan);
            DPplan.times.Add(time);
        }

        public static string RemovePlan(int index)
        {

            if (index >= 0 && index < plan.Count)
            {
                string removed = plan[index];
                plan.RemoveAt(index);
                times.RemoveAt(index);
                return removed;
            }
            return null;
        }

        public static bool UpdatePlan(int index, string newPlan, string newTime)
        {
            if (index >= 0 && index < plan.Count)
            {
                plan[index] = newPlan;
                times[index] = newTime;
                return true;
            }

            return false;
        }
    }
}

