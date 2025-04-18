using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to To Do list program.");
            List<string> taskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("---------------------------------------------------------------");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 to add a task to the list.");
                Console.WriteLine("Enter 2 to remove a task from the list.");
                Console.WriteLine("Enter 3 to view the list.");
                Console.WriteLine("Enter e to exit the program");

                option = Console.ReadLine();

                if (option == "1")
                {

                    Console.WriteLine("Enter the Task name to add in the list: ");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine("Task added to the list.");
                }

                else if (option == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + " : " + taskList[i]);
                    }

                    Console.WriteLine("Please enter the Number Beside of your task that you want to remove.");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);

                }

                else if (option == "3")
                {
                    Console.WriteLine("Current Task in the List : ");

                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(taskList[i]);
                    }
                }

                else if (option == "e")
                {
                    Console.WriteLine("Exiting Program...");
                }

                else
                {
                    Console.WriteLine("Invalid Input! Please enter Correct input.");
                }

                Console.WriteLine("Thanks for Using the Program.");


            }


        }
    }
}