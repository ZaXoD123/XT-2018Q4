using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace Epam.Task7.Entities
{
    [Serializable]
    public class User
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<uint> Awards { get; set; } = new List<uint>();

        public override string ToString() =>$"{Id} {Name} {DateOfBirth.DayOfYear} {(int)((DateTime.Today - DateOfBirth).TotalDays / 364)}";
        
    }
}
