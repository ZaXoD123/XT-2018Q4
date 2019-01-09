using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Epam.Task7.Entities;

namespace Epam.Task7.DAL
{
    public class AwardsDao : IAwardsDao
    {
        private static Dictionary<uint, Award> _award;
        private static BinaryFormatter _binaryFormatter;
        private static FileStream _defaultDataFile;

        public AwardsDao()
        {
            _binaryFormatter = new BinaryFormatter();
            _defaultDataFile = new FileStream("data.datawards", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            try
            {
                _award = _binaryFormatter.Deserialize(_defaultDataFile) as Dictionary<uint, Award>;
                _defaultDataFile.Close();
            }
            catch
            {
                _award = new Dictionary<uint, Award>();
            }
            _defaultDataFile.Close();
        }

        public void Save()
        {
            _defaultDataFile = new FileStream("data.datawards", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            _binaryFormatter.Serialize(_defaultDataFile, _award);
        }

        public void Add(Award aUser)
        {
            aUser.Id = _award.Count != 0 ? _award.Keys.Max() + 1 : 1;
            _award.Add(aUser.Id, aUser);
        }

        public Award GetById(uint id) => _award[id];

        public bool Remove(uint id)
        {
            return _award.Remove(id);
        }

        public IEnumerable<Award> Show()
        {
            return _award.Values;
        }
    }
}