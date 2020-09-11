using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Order
{
    class Order
    {
         static void Main (string[] args)
        {
            Queue <string> myQueue = new Queue <string>();
            Stack <string> myStack = new Stack <string>();
            
            Console.WriteLine("Hi, Welcome to Tina’s Palace! There is a long line ahead of us so let’s get started. Type \"quit\" once you are done :)");
            Console.WriteLine("What would you like?");

            /*a method to display List of Orders in ascending order using queue, handle the situation where there is 
            no order placed showing "None" */
            void showQueue ()
            {
                Console.WriteLine("");
                Console.WriteLine("Order Summary for the day:");
                Console.WriteLine("");
                Console.WriteLine("List of orders:");
                int count = 1;
                if (myQueue.Count > 0)
                {
                    foreach (string var1 in myQueue)
                    {

                        Console.WriteLine($"Order #{count} {var1}");
                        count++;
                        myStack.Push(var1);
                    }
                    myQueue.Clear();
                }
                else
                {
                    Console.WriteLine("None");
                }
            }
            /*a method to display Order Tracker, handle the situation where there is 
            no order placed showing "None" */
            void showStack ()
            {
                Console.WriteLine("");
                Console.WriteLine("Order Tracker:");
                while (myStack.Count > -1)
                {
                    if (myStack.Count > 1)
                    {
                        Console.Write($"{myStack.Pop()}, ");
                    }
                    else if (myStack.Count == 1)
                    {
                        Console.Write($"{myStack.Pop()}");
                        break;
                    }
                    else
                    {
                        Console.Write("None");
                        break;
                    }
                }
            }

            do
            {
                //create input varible and convert user input into lower case to avoid typos in user input
                string userInput = Console.ReadLine().ToLower();
                
                if (userInput != "quit")
                {
                    Console.WriteLine("Next! What would you like?");

                    myQueue.Enqueue(userInput);

                }
                else
                {
                    showQueue();
                    showStack();
                    break;
                }
            }
            while (true);
        }
    }
}