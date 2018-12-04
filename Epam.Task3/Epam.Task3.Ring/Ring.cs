namespace Epam.Task3.Ring
{
    using System;

    public class Ring
    {
        public Ring(double firstRadius, double secondRadius, double x, double y)
        {
            if (firstRadius <= 0 || secondRadius <= 0 || firstRadius < secondRadius)
            {
                throw new Exception("Incorrect input values!");
            }

            this.FirstRingBase = new Round.Round(firstRadius, x, y);
            this.SecondRingBase = new Round.Round(secondRadius, x, y);
            this.RingArea = this.FirstRingBase.RoundArea - this.SecondRingBase.RoundArea;
        }

        // Aggregation example
        public Round.Round FirstRingBase { get; }

        public Round.Round SecondRingBase { get; }

        public double RingArea { get; }
    }
}