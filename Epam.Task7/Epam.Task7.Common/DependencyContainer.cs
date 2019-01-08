using Epam.Task7.BLL;
using Epam.Task7.DAL;

namespace Epam.Task7.Common
{
    public static class Dependencies
    {
        private static IUserDao _userDao;
        private static IUserLogic _userLogic;

        public static IUserDao UserDao => _userDao ?? (_userDao = new UserDao());
        public static IUserLogic UserLogic => _userLogic ?? (_userLogic = new UserLogic(UserDao));
    }
}
