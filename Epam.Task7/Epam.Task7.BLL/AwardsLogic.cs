using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.DAL;
using Epam.Task7.Entities;

namespace Epam.Task7.BLL
{
    public class AwardsLogic : IAwardsLogic
    {
        private static IAwardsDao _awardsDao;

        public AwardsLogic(IAwardsDao awardDao) => _awardsDao = awardDao;

        public void Add(Award aUser) => _awardsDao.Add(aUser);
        
        public void Remove(uint id) => _awardsDao.Remove(id);

        public Award GetById(uint id) => _awardsDao.GetById(id);

        public void Exit() => _awardsDao.Save();

        public IEnumerable<Award> Show() => _awardsDao.Show();
    }
}
