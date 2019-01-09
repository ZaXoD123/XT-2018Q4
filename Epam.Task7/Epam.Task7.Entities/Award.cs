using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.Entities
{
    [Serializable]
    public class Award
    {
        public uint Id { get; set; }
        public string Title { get; set; }

        public override string ToString() => $"{Id} {Title}";
    }
}
