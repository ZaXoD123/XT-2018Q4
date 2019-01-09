using System.Collections.Generic;
using Epam.Task7.Entities;

namespace Epam.Task7.BLL
{
    public interface IUserLogic
    {
        void Add(User aUser);
        void Remove(uint id);
        void Update(User aUser);
        void Exit();
        void AddAward(uint userId, uint awardId, IAwardsLogic awardsLogic);
        User GetById(uint id);
        IEnumerable<User> Show();
        
    }
}