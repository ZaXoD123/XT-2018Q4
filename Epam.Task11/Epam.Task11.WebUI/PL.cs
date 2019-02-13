using Epam.Task7.Entities;
using System;
using System.Collections.Generic;
using Epam.Task7.BLL;

namespace PLMain
{
    public static class WebPL
    {
        private static IUserLogic userLogic = Epam.Task7.Common.Dependencies.UserLogic;
        private static IAwardsLogic awardsLogic = Epam.Task7.Common.Dependencies.AwardsLogic;


        public static void Add(string name, DateTime date)
        {
            var user = new User();
            user.DateOfBirth = date;
            user.Name = name;
            userLogic.Add(user);
            userLogic.Exit();
        }

        public static void Delete(uint i)
        {
            userLogic.Remove(i);
            userLogic.Exit();
        }

        public static IEnumerable<(dynamic,dynamic)> Show()
        {
            foreach (var item in userLogic.Show())
            {

                if (item.Avatar.Data != "")
                {
                    yield return (item.Avatar.Data, " " + item);
                }
                else
                {
                    yield return ("/noavatar.jpg", " " + item);
                }
                
                foreach (var itemAward in item.Awards)
                {
                    var temp = awardsLogic.GetById(itemAward);
                    if (temp.Avatar.Data != "")
                    {
                        yield return (temp.Avatar.Data,"    "+ temp);
                    }
                    else
                    {
                        yield return ("/noavatarAward.png", "    " + temp);
                    }
                }
            }
        }

        public static void Save()
        {
            userLogic.Exit();
            awardsLogic.Exit();
        }

        public static void AddAward(string a)
        {
            awardsLogic.Add(new Award() { Title = a });
            awardsLogic.Exit();
        }

        public static IEnumerable<(dynamic, dynamic)> ShowAwards()
        {
            foreach (var item in awardsLogic.Show())
            {
                if (item.Avatar.Data != "")
                {
                    yield return (item.Avatar.Data, " " + item);
                }
                else
                {
                    yield return ("/noavatarAward.png", " " + item);
                }
            }
        }

        public static void AddAwardForUser(uint userId, uint awardId)
        {
            userLogic.AddAward(userId, awardId, awardsLogic);
            userLogic.Exit();
        }

        public static void UserUpdate(uint userId,string name, DateTime date)
        {
            var a = userLogic.GetById(userId);
            a.Name = name;
            a.DateOfBirth = date;
            userLogic.Update(a);
            userLogic.Exit();
        }

        public static void DeleteAward(uint id)
        {
            foreach (var item in userLogic.Show())
            {
                userLogic.DeleteAward(id,item.Id);
            }
            awardsLogic.Remove(id);
            awardsLogic.Exit();
            userLogic.Exit();
        }

        public static User GetUserById(uint id) => userLogic.GetById(id);
        public static Award GetAwardById(uint id) => awardsLogic.GetById(id);
    }
}
