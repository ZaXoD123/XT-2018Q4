using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3.Game
{
    public interface IGameObject
    {
        bool IsStatic { get; }
    }

    public interface INPC 
    {
        bool IsStatic { get; }

        void HitAction(IPlayer player);
    }

    public interface IPlayer
    {
        uint Health { get; }
    }
}
