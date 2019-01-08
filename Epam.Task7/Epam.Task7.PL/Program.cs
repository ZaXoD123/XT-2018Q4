using Epam.Task7.Entities;
using System;

namespace Epam.Task7.PL
{
    class Program
    {
        static void ConsoleShow(string str)
        {
            Console.Clear();
            Console.WriteLine(str);
            Console.ReadKey();
            Console.Clear();
        }
        

        static void Main(string[] args)
        {
            var userLogic = Common.Dependencies.UserLogic;
        //var user = new User();

        InputStart:
            Console.WriteLine("Users database. Please, enter command:{0}  Add{0}  Delete{0}  Show{0}  Exit", Environment.NewLine);
            switch (Console.ReadLine()?.ToLower())
            {
                case "add":
                    var user = new User();
                    user.DateOfBirth = new DateTime(1998,12,5);
                    user.Name = "NotNikolai";
                    userLogic.Add(user);
                    ConsoleShow(user.Name + " is added");
                    goto InputStart;
                case "delete":
                    userLogic.Remove(uint.Parse(Console.ReadLine()));
                    ConsoleShow("Remove completed!");
                    goto InputStart;
                case "show":
                    Console.Clear();
                    foreach (var item in userLogic.Show())
                    {
                        Console.WriteLine(item.ToString());
                    }
                    goto InputStart;
                case "exit":
                    userLogic.Exit();
                    break;
                default:
                    ConsoleShow("Wrong command. Try again!");
                    goto InputStart;
            }

        }
    }
}
