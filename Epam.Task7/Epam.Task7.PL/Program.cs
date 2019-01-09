using Epam.Task7.Entities;
using System;
using Epam.Task7.BLL;

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
            var awardsLogic = Common.Dependencies.AwardsLogic;

        InputStart:
            Console.WriteLine("Users database. Please, enter command:{0}  Add{0}  Delete{0}  Show{0}  Add award{0}  Show awards{0}  Add award 4 user{0}  Exit", Environment.NewLine);
            switch (Console.ReadLine()?.ToLower())
            {
                //Just Example. There is no checks for correct input! Sorry
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
                        foreach (var itemAward in item.Awards)
                        {
                            Console.WriteLine("  {0}",awardsLogic.GetById(itemAward));
                        }
                    }
                    goto InputStart;
                case "exit":
                    userLogic.Exit();
                    awardsLogic.Exit();
                    break;
                case "add award":
                    awardsLogic.Add(new Award(){ Title = "Gold"});
                    awardsLogic.Add(new Award() { Title = "Silver" });
                    awardsLogic.Add(new Award() { Title = "Bronze" });
                    ConsoleShow("Awards added");
                    goto InputStart;
                case "show awards":
                    Console.Clear();
                    foreach (var item in awardsLogic.Show())
                    {
                        Console.WriteLine(item.ToString());
                    }
                    goto InputStart;
                case "add award 4 user":
                    Console.Clear();
                    Console.WriteLine("Enter userId and awardId");
                    userLogic.AddAward(uint.Parse(Console.ReadLine()), uint.Parse(Console.ReadLine()), awardsLogic);
                    goto InputStart;
                default:
                    ConsoleShow("Wrong command. Try again!");
                    goto InputStart;
            }
        }
    }
}
