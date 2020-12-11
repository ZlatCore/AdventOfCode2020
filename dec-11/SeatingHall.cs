using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dec_11
{
    class SeatingHall
    {
        Seat[,] seats;
        private int maxx;
        private int maxy;
        List<Seat> seatList;

        public SeatingHall(string[] input)
        {
            seats = new Seat[input.Length, input[0].Length];
            seatList = new List<Seat>();
            maxx = input.Length - 1;
            maxy = input[0].Length - 1;
            int y = 0;
            foreach (var row in input)
            {
                int x = 0;
                foreach (char c in row)
                {
                    seats[y, x] = new Seat(c, y, x, this);
                    if (c == 'L')
                    {
                        seatList.Add(seats[y, x]);
                    }
                    x++;
                }
                y++;
            }
        }

        public bool DoStep()
        {
            var results = seatList.Select(x => x.CheckNextState()).ToList();
            var hadCHange = results.Count(x => x == true);
            Console.WriteLine($"ChangeCount: {hadCHange}");
            var occupied = seatList.Count(x => x.state == SeatState.Taken);
            Console.WriteLine($"Occupied: {occupied}");

            if (hadCHange > 0)
            {
                foreach (var seat in seatList)
                {
                    seat.ExecuteNextState();
                }
            }

            return hadCHange > 0;
        }
        SeatState TryGetState(int x, int y)
        {
            if (x < 0 || x > maxx || y < 0 || y > maxy)
            {
                return SeatState.Floor;
            }

            return seats[x,y].state;
        }
        public List<SeatState> GetNearbyStatesFor(int x, int y)
        {
            //Task 1 solution nearby:
            /*
               List<SeatState> results = new List<SeatState>();

               var xm1 = x - 1;
               var xp1 = x + 1;
               var ym1 = y - 1;
               var yp1 = y + 1;

               results.Add(TryGetState(xm1, ym1));
               results.Add(TryGetState(xm1, y));
               results.Add(TryGetState(xm1, yp1));

               results.Add(TryGetState(x, ym1));
               results.Add(TryGetState(x, yp1));

               results.Add(TryGetState(xp1, ym1));
               results.Add(TryGetState(xp1, y));
               results.Add(TryGetState(xp1, yp1));

               return results;
            */

            //task 2 solution for nearby:
            List<SeatState> results = new List<SeatState>();
            results.Add(FindNearestForVector((-1, -1), x, y));
            results.Add(FindNearestForVector((-1, 0), x, y));
            results.Add(FindNearestForVector((-1, 1), x, y));

            results.Add(FindNearestForVector((0, -1), x, y));
            results.Add(FindNearestForVector((0, 1), x, y));

            results.Add(FindNearestForVector((1, -1), x, y));
            results.Add(FindNearestForVector((1, 0), x, y));
            results.Add(FindNearestForVector((1, 1), x, y));

            return results;
        }

        private SeatState FindNearestForVector((int, int) vector, int startx, int starty)
        {
            var nx = startx + vector.Item1;
            var ny = starty + vector.Item2;
            var notFound = true;
            while (notFound)
            {
                if (nx < 0 || nx > maxx || ny < 0 || ny > maxy)
                {
                    return SeatState.Floor;
                }

                if (seats[nx, ny].state != SeatState.Floor)
                {
                    notFound = false;
                    return seats[nx, ny].state;
                }

                nx += vector.Item1;
                ny += vector.Item2;
            }

            return SeatState.Floor;
        }
    }

    class Seat
    {
        public int x;
        public int y;
        public SeatState state;

        public SeatState nextState;

        public SeatingHall parent;

        public Seat(char c, int x, int y, SeatingHall p)
        {
            this.x = x;
            this.y = y;
            this.parent = p;
            if (c == '.')
            {
                this.state = SeatState.Floor;
            }
            else
            {
                this.state = SeatState.Empty;
            }
        }
        public bool CheckNextState()
        {
            if (state == SeatState.Floor)
            {
                return false;
            }

            nextState = state;

            var nearby = parent.GetNearbyStatesFor(this.x, this.y);
            var occupied = nearby.Count(x => x == SeatState.Taken);
            if (state == SeatState.Empty && occupied < 1)
            {
                nextState = SeatState.Taken;
                return true;
            }
            if (state == SeatState.Taken && occupied > 4)
            {
                nextState = SeatState.Empty;
                return true;
            }

            return false;
        }

        public void ExecuteNextState()
        {
            this.state = nextState;
        }
    }

    enum SeatState
    {
        Floor,
        Empty,
        Taken
    }

}
