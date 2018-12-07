namespace Epam.Task3.Game
{
    public abstract class Map
    {
        private readonly IPlayer player;
        private readonly IGameObject[,] desk;

        public Map(uint monstersPercent = 30, uint bonusPercent = 20, uint length = 10)
        {
            var temp = this.MapGenerator(monstersPercent, bonusPercent, length);
            this.desk = temp.Item1;
            this.player = temp.Item2;
            this.MapLength = length;
        }

        public uint MapLength { get; }

        public bool Move(IGameObject gameObject, int newX, int newY)
        {
            if (this.desk[newX, newY] != null && (gameObject.IsStatic || this.desk[newX, newY].IsStatic))
            {
                return false;
            }

            this.MoveObjectAction(gameObject, newX, newY);
            this.desk[newX, newY] = gameObject;
            return true;
        }

        public bool MoveObjectAction(IGameObject gameObject, int newX, int newY)
        {
            if (gameObject is IPlayer)
            {
                (this.desk[newX, newY] as INPC).HitAction(gameObject as IPlayer);
                return true;
            }

            if (this.desk[newX, newY] is IPlayer)
            {
                (gameObject as INPC).HitAction(this.player);
                return true;
            }

            return true;
        }

        protected abstract (IGameObject[,], IPlayer) MapGenerator(uint monsters, uint bonuses, uint length);
    }
}