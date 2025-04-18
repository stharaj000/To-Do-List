using System;
using System.Collections.Generic;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Welcome to the To-Do List App =====\n");

            List<string> tasks = new List<string>();
            string input = "";

            while (input != "e")
            {
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("[1] Add Task");
                Console.WriteLine("[2] Remove Task");
                Console.WriteLine("[3] View Tasks");
                Console.WriteLine("[e] Exit");
                Console.Write("Enter your choice: ");
                input = Console.ReadLine()?.ToLower();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter a new task: ");
                        string newTask = Console.ReadLine();
                        tasks.Add(newTask);
                        Console.WriteLine("✅ Task added!");
                        break;

                    case "2":
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("⚠ No tasks to remove.");
                            break;
                        }

                        Console.WriteLine("Here are your current tasks:");
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            Console.WriteLine($"[{i}] {tasks[i]}");
                        }

                        Console.Write("Enter the task number to remove: ");
                        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < tasks.Count)
                        {
                            Console.WriteLine($"🗑 Removed: {tasks[index]}");
                            tasks.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("❌ Invalid index.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("📝 Your Tasks:");
                        if (tasks.Count == 0)
                        {
                            Console.WriteLine("No tasks yet!");
                        }
                        else
                        {
                            foreach (var task in tasks)
                            {
                                Console.WriteLine($"- {task}");
                            }
                        }
                        break;

                    case "e":
                        Console.WriteLine("👋 Exiting... Goodbye!");
                        break;

                    default:
                        Console.WriteLine("❌ Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
