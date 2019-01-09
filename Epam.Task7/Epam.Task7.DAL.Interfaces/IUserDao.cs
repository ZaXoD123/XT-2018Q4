using System.Collections.Generic;
using Epam.Task7.Entities;

namespace Epam.Task7.DAL
{
    public interface IUserDao
    {
        void Save();
        void Add(User aUser);
        bool Remove(uint id);
        bool Update(User aUser);
        User GetById(uint id);
        IEnumerable<User> Show();
    }
}