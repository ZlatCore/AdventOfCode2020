using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dec_12
{
    class ShipWaypoint
    {
        public (int, int) Position;
        public (int, int) Waypoint;

        public ShipWaypoint()
        {
            this.Position = (0, 0);
            this.Waypoint = (10, 1);
        }

        public (int, int) MoveNext(string moveText)
        {
            var startsWith = moveText[0];

            switch (startsWith)
            {
                case 'E':
                    this.MoveWaypoint((1, 0), this.GetDistance(moveText));
                    break;
                case 'W':
                    this.MoveWaypoint((-1, 0), this.GetDistance(moveText));
                    break;
                case 'N':
                    this.MoveWaypoint((0, 1), this.GetDistance(moveText));
                    break;
                case 'S':
                    this.MoveWaypoint((0, -1), this.GetDistance(moveText));
                    break;
                case 'F':
                    this.DoMove(this.GetDistance(moveText));
                    break;
                case 'R':
                case 'L':
                    this.RotateWaypoint(moveText);
                    break;
            }

            return this.Position;
        }

        public void DoMove(int units)
        {
            var xMove = this.Waypoint.Item1 * units;
            var yMove = this.Waypoint.Item2 * units;

            this.Position = (this.Position.Item1 + xMove, this.Position.Item2 + yMove);
        }

        public void MoveWaypoint((int, int) head, int units)
        {
            var fullMove = (head.Item1 * units, head.Item2 * units);
            this.Waypoint = (this.Waypoint.Item1 + fullMove.Item1, this.Waypoint.Item2 + fullMove.Item2);
        }

        public void RotateWaypoint(string rotation)
        {
            var rotationDirection = 1;
            if (rotation.StartsWith('L'))
            {
                rotationDirection = -1;
            }

            int angle = this.GetDistance(rotation);
            angle *= rotationDirection * -1;
            var radians = (MathF.PI / 180) * angle;
            
            float sin = MathF.Sin(radians);
            float cos = MathF.Cos(radians);

            float tx = this.Waypoint.Item1;
            float ty = this.Waypoint.Item2;
            var x = (cos * tx) - (sin * ty);
            var y = (sin * tx) + (cos * ty);
            this.Waypoint = ((int)Math.Round(x, 0), (int)Math.Round(y, 0));
        }

        private int GetDistance(string input)
        {
            var justNumbers = new String(input.Where(x => char.IsDigit(x)).ToArray());
            var val = int.Parse(justNumbers);
            return val;
        }
    }
}
