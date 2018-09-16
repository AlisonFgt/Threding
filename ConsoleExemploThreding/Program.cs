using System;
using System.Threading;

namespace ConsoleExemploThreding
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAcct acct = new BankAcct(10);
            Thread[] threads = new Thread[15];

            Thread.CurrentThread.Name = "main";
            Thread.CurrentThread.Priority = ThreadPriority.Highest;


            for (int i = 0; i < 15; i++)
            {
                Thread t = new Thread(() => acct.IssueWithdraw(1));
                t.Name = i.ToString();
                threads[i] = t;
            }

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Thread { threads[i].Name } Alive : { threads[i].IsAlive }");
                threads[i].Start();
                Console.WriteLine($"Thread { threads[i].Name } Alive : { threads[i].IsAlive }");
            }

            Console.WriteLine($"Current Priority : { Thread.CurrentThread.Priority } ");

            Console.WriteLine($"Thread { Thread.CurrentThread.Name } Ending.");

            Console.ReadLine();
        }
    }
}


//result : 

//Thread 0 Alive : False
//Thread 0 Alive : True
//Thread 1 Alive : False
//Thread 1 Alive : True
//Thread 2 Alive : False
//Thread 2 Alive : True
//Thread 3 Alive : False
//Thread 3 Alive : True
//Thread 4 Alive : False
//Thread 4 Alive : True
//Thread 5 Alive : False
//Thread 5 Alive : True
//Thread 6 Alive : False
//Thread 6 Alive : True
//Thread 7 Alive : False
//Thread 7 Alive : True
//Thread 8 Alive : False
//Removed 10 and 9 left in Account
//Removed 9 and 8 left in Account
//Thread 8 Alive : True
//Removed 8 and 7 left in Account
//Removed 7 and 6 left in Account
//Removed 6 and 5 left in Account
//Thread 9 Alive : False
//Removed 5 and 4 left in Account
//Removed 4 and 3 left in Account
//Removed 3 and 2 left in Account
//Removed 2 and 1 left in Account
//Thread 9 Alive : True
//Thread 10 Alive : False
//Thread 10 Alive : True
//Thread 11 Alive : False
//Removed 1 and 0 left in Account
//Thread 11 Alive : True
//Thread 12 Alive : False
//Sorry 0 in Account
//Thread 12 Alive : True
//Thread 13 Alive : False
//Thread 13 Alive : True
//Thread 14 Alive : False
//Sorry 0 in Account
//Thread 14 Alive : True
//Current Priority : Highest
//Thread main Ending.
//Sorry 0 in Account
//Sorry 0 in Account

