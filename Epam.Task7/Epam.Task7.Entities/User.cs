using System;
using System.Collections.Specialized;

namespace Epam.Task7.Entities
{
    [Serializable]
    public class User
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString() => $"{Id} {Name} {DateOfBirth} {(DateTime.Today - DateOfBirth).TotalDays/364}";
    }
}
