using System.Collections.Generic;
using Epam.Task7.Entities;

namespace Epam.Task7.DAL
{
    public interface IAwardsDao
    {
        void Save();
        void Add(Award aUser);
        bool Remove(uint id);
        Award GetById(uint id);
        IEnumerable<Award> Show();
    }
}