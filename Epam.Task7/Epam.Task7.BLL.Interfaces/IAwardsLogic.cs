using System.Collections.Generic;
using Epam.Task7.Entities;

namespace Epam.Task7.BLL
{
    public interface IAwardsLogic
    {
        void Add(Award aUser);
        void Remove(uint id);
        void Exit();
        Award GetById(uint id);
        IEnumerable<Award> Show();
    }
}