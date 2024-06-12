using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Schema;

namespace lock_password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            string  d,e;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("    Welcome To Ciet Company  ");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Choose Your Device");
            Console.WriteLine("1.MOBLIE");
            Console.WriteLine("2.DESKTOP");
            Console.WriteLine("Choose the option either 1 (or) 2 :");
            Console.ForegroundColor = ConsoleColor.Blue;
            a = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (a == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" Set The Password : ");
                c = Convert.ToInt32(Console.ReadLine());              
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Successfully set the password....");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("enter password to login");
                b = Convert.ToInt32(Console.ReadLine());
                if (c==b && b.ToString().Length == 4 || b.ToString().Length == 6) 
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Welcome To Login");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Password sholud be..numreic with length 4 0r 6");
                    Console.Clear();
                    string ps1; int i = 0, a1 = 5;
                    while (i <= 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Password is incorrect.. Retry again...");                     
                        Console.WriteLine("Enter password to login : ");
                        ps1 = Console.ReadLine();
                        Console.Clear();
                        i += 1;
                    }
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(" So many faliure attempts");
                    Console.Clear();
                    while (a1 <= 5)
                    {

                        Console.WriteLine("Please try again  " + a1 + " seconds");
                        a1 -= 1;
                        Thread.Sleep(1000);
                        Console.Clear();
                        if (a1 == -1)
                        {
                            break;
                        }
                        else if (a1 <= 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Please try again  " + a1 + " seconds");

                            a1 -= 1;
                            Thread.Sleep(1000);
                            Console.Clear();

                        }

                    }
                    Console.WriteLine("Enter password to login : ");
                }
             
            }
            else if (a == 2)
            {
                  string ps;
                   Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Enter Password To Set: ");
                   e = Console.ReadLine();
                   Console.Clear();
                   Console.ForegroundColor = ConsoleColor.DarkBlue;
                   Console.WriteLine("Successfully set the password....");
                   Console.Clear();
                   Console.WriteLine("enter password to login");
                     ps = Console.ReadLine();
                     Console.Clear();
                    if (ps == e)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Welcome To Login");
                    }
                    else
                    {
                        string ps1; int i = 0, a1 = 30;
                        while (i <= 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong Password...please try again");
                            Console.WriteLine("Enter password to login : ");
                            ps1 = Console.ReadLine();
                            Console.Clear();
                            i += 1;
                        }
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(" So many faliure attempts");
                        Console.Clear();
                        while (a1 <= 30)
                        {

                            Console.WriteLine("Please try again  " + a1 + " seconds");
                            a1 -= 1;
                            Thread.Sleep(1000);
                            Console.Clear();
                            if (a1 == -1)
                            {
                                break;
                            }
                            else if (a1 <= 5)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Please try again  " + a1 + " seconds");

                                a1 -= 1;
                                Thread.Sleep(1000);
                                Console.Clear();

                            }

                        }
                        Console.WriteLine("Enter password to login : ");
                    } 
                
            }
            else
            {
                Console.WriteLine("Choose correct Option:");
            }
        }
    }
}
