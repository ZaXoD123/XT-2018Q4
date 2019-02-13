using System;
using System.Collections.Generic;
using Epam.Task7.Entities;
using Epam.Task7.DAL;


namespace Epam.Task7.BLL
{
    public class UserLogic : IUserLogic
    {
        private IUserDao _userDao;

        public UserLogic(IUserDao userDao) => _userDao = userDao;
        
        public void Add(User aUser) => _userDao.Add(aUser);
        
        public void Remove(uint id) => _userDao.Remove(id);
        
        public void Update(User aUser) => _userDao.Update(aUser);

        public void DeleteAward(uint awardId, uint userId)
        {
            try
            {
                GetById(userId).Awards.Remove(awardId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

        public User GetById(uint id) => _userDao.GetById(id);

        public void AddAward(uint userId, uint awardId, IAwardsLogic awardsLogic)
        {
            var temp = _userDao.GetById(userId).Awards;
            try
            {
                awardsLogic.GetById(awardId);
                if (!temp.Contains(awardId))
            {
                _userDao.GetById(userId).Awards.Add(awardId);
            }
            }
            catch 
            {
                throw new Exception("Award is not exist");
            }
            
        }

        public void Exit() => _userDao.Save();
        
        public IEnumerable<User> Show() => _userDao.Show();
    }
}
