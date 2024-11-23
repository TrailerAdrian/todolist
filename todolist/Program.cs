using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the to do list program");
            List<string> tasklist = new List<string>();
            string option = "";

            while(option != "e")
            {
                Console.WriteLine("What would you like to do");
                Console.WriteLine("Enter 1 to add a task to the list");
                Console.WriteLine("Enter 2 to remove an item from the list");
                Console.WriteLine("Enter 3 to view the list");
                Console.WriteLine("Enter e to exit the program");

                option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine("Please enter the name of the task you would like to add to the list");
                    string task = Console.ReadLine();
                    tasklist.Add(task);
                    Console.WriteLine("You have sucessfully added the item to the list");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < tasklist.Count; i++)
                    {
                        Console.WriteLine(i + " " + tasklist[i]);
                    }
                    Console.WriteLine("Please enter the number of the task to remove from the list");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    tasklist.RemoveAt(taskNumber);
                }
                else if (option == "3")
                {
                    Console.WriteLine("Your current tasks in the list are :");

                    for (int i = 0; i < tasklist.Count; i++)
                    {
                        Console.WriteLine(tasklist[i]);
                    }
                }
                else if (option == "e")
                {
                    Console.WriteLine("Exiting program");
                }
                else
                {
                    Console.WriteLine("Invalid option please try again");
                }
            }
            Console.WriteLine("Thank you for using my program");
            Console.ReadLine();

        }
    }
}
