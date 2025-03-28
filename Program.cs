using System;
using System.Collections.Generic;
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
                Console.WriteLine("[1] Add Task");
                Console.WriteLine("[2] View Tasks");
                Console.WriteLine("[3] Exit");

                Console.Write("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("What will be your task?: ");
                        string task = Console.ReadLine();

                        Console.Write("Enter the time for your task (morning/noon/evening): ");
                        string time = Console.ReadLine();
                        DPTask.AddTask(task, time);
                        Console.WriteLine("Task added successfully!");
                        break;
                    case 2:
                        ViewTasks();
                        break;
                    case 3:
                        Console.WriteLine("Goodbye! Have a productive day.");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }


        static void ViewTasks()
        {
            if (DPTask.tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            Console.WriteLine("Your Tasks:");
            for (int i = 0; i < DPTask.tasks.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {DPTask.tasks[i]} at {DPTask.times[i]}");
            }
        }
    }
}
