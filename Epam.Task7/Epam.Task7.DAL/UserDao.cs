using Epam.Task7.Entities;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace Epam.Task7.DAL
{
    public class UserDao : IUserDao
    {
        private static Dictionary<uint, User> _users;
        private static BinaryFormatter _binaryFormatter;
        private static FileStream _defaultDataFile;

        public UserDao()
        {
            _binaryFormatter = new BinaryFormatter();
            _defaultDataFile = new FileStream("data.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            try
            {
                _users = _binaryFormatter.Deserialize(_defaultDataFile) as Dictionary<uint, User>;
                _defaultDataFile.Close();
            }
            catch
            {
                
                _users = new Dictionary<uint, User>();
            }
        }

        public void Save()
        {
            _defaultDataFile = new FileStream("data.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            _binaryFormatter.Serialize(_defaultDataFile, _users);
        }

        public void Add(User aUser)
        {
            aUser.Id = (_users.Count != 0) ? _users.Keys.Max() + 1 : 1;
            _users.Add(aUser.Id, aUser);
        }

        public bool Remove(uint id) => _users.Remove(id);

        public bool Update(User aUser)
        {
            if (_users.ContainsKey(aUser.Id))
            {
                _users[aUser.Id] = aUser;
                return true;
            }

            return false;
        }
        
        public IEnumerable<User> Show() => _users.Values;
    }
}
