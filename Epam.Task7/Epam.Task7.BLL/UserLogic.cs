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
        

        public void Exit() => _userDao.Save();
        
        public IEnumerable<User> Show() => _userDao.Show();
    }
}
