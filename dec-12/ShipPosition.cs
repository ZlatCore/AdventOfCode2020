using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dec_12
{
    class ShipPosition
    {
        public (int, int) Position;
        public (int, int) Heading;

        private (int, int)[] rightTurns;
        private int headingPos;

        public ShipPosition()
        {
            this.Position = (0, 0);
            this.Heading = (1, 0);

            this.headingPos = 0;
            this.rightTurns = new (int, int)[4]
            {
                (1, 0), (0, -1), (-1, 0), (0,1)
            };
        }

        public (int, int) MoveNext(string moveText)
        {
            var startsWith = moveText[0];

            switch (startsWith)
            {
                case 'E':
                    return this.DoMove((1, 0), this.GetDistance(moveText));
                case 'W':
                    return this.DoMove((-1, 0), this.GetDistance(moveText));
                case 'N':
                    return this.DoMove((0, 1), this.GetDistance(moveText));
                case 'S':
                    return this.DoMove((0, -1), this.GetDistance(moveText));
                case 'F':
                    return this.DoMove(this.Heading, this.GetDistance(moveText));
                case 'R':
                case 'L':
                    this.RotateShip(moveText);
                    return this.Position;
            }

            return this.Position;
        }

        public (int, int) DoMove((int, int) head, int units)
        {
            var fullMove = (head.Item1 * units, head.Item2 * units);
            this.Position = (this.Position.Item1 + fullMove.Item1, this.Position.Item2 + fullMove.Item2);
            return this.Position;
        }

        public void RotateShip(string rotation)
        {
            var rotationDirection = 1;
            if (rotation.StartsWith('L'))
            {
                rotationDirection = -1;
            }

            int angle = this.GetDistance(rotation);
            angle /= 90 * rotationDirection;

            var tmp = (this.headingPos + this.rightTurns.Length + angle) % this.rightTurns.Length;
            this.Heading = this.rightTurns[tmp];
            this.headingPos = tmp;
            var a = Heading;
        }

        private int GetDistance(string input)
        {
            var justNumbers = new String(input.Where(x => char.IsDigit(x)).ToArray());
            var val = int.Parse(justNumbers);
            return val;
        }
    }
}
