using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using BL.DailyPlanner;


namespace DailyPlanner2
{
    internal class Program
    {


        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Welcome to Daily Planner! Please select an action:");
                Console.WriteLine("[1] Add Plan");
                Console.WriteLine("[2] Remove Plan");
                Console.WriteLine("[3] View Plan");
                Console.WriteLine("[4] Update Plan");
                Console.WriteLine("[5] Exit");

                Console.Write("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("What will be your plan?: ");
                        string plan = Console.ReadLine();

                        Console.Write("Enter the time for your plans (morning/noon/evening): ");
                        string time = Console.ReadLine();
                        DPplan.AddPlan(plan, time);
                        Console.WriteLine("Plan added successfully!");
                        break;

                    case 2:
                        RemovePlan();
                        break;

                    case 3:
                        ViewPlan();
                        break;

                    case 4:
                        UpdatePlan();
                        break;

                    case 5:
                        Exit();
                        Console.WriteLine("Hope to see you again");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        static void RemovePlan()
        {
            if (DPplan.plan.Count == 0)
            {
                Console.WriteLine("No plan to remove.");
                return;
            }

            Console.WriteLine("Here are your current plans: ");
            for (int i = 0; i < DPplan.plan.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {DPplan.plan[i]} at {DPplan.times[i]}");
            }

            Console.WriteLine("Enter the number of the plan you want to remove: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            string removed = DPplan.RemovePlan(index);

            if (removed != null)
            {
                Console.WriteLine($"Removed plan: {removed}");
            }
            else
            {
                Console.WriteLine("Invalid Number. No plan was removed");
            }
        }

        static void ViewPlan()
        {
            if (DPplan.plan.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            Console.WriteLine("Plans:");
            for (int i = 0; i < DPplan.plan.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {DPplan.plan[i]} at {DPplan.times[i]}");
            }
        }

        static void UpdatePlan()
        {
            if (DPplan.plan.Count == 0)
            {
                Console.WriteLine("No plans to update");
                return;
            }

            Console.WriteLine("Here are your current plans: ");
            for (int i = 0; i < DPplan.plan.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {DPplan.plan[i]} at {DPplan.times[i]}");
            }

            Console.WriteLine("Enter the number of the plan you want to update: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.Write("Enter your new plan: ");
            string newPlan = Console.ReadLine();

            Console.Write("Enter the new time: ");
            string newTime = Console.ReadLine();

            bool success = DPplan.UpdatePlan(index, newPlan, newTime);

            if (success)

            {
                Console.WriteLine("Plan has been updated successfully");
            }

            else
            {
                Console.WriteLine("Invalid Number. No plan was updated");
            }

        }

        static void Exit()
        {
            Console.WriteLine("Goodbye! Have a productive day.");
            return;
        }
    }
}
