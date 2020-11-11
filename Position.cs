using System;

namespace SimpleGameFramework
{
    public class Position
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        public Position(int xCoordinate, int yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }

        public override string ToString()
        {
            return $"[{XCoordinate}, {YCoordinate}]";
        }
    }
}
