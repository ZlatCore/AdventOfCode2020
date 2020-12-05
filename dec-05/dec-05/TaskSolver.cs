using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dec_05
{
    public class TaskSolver
    {

        public static int GetHighestSeatId(string[] input)
        {
            var boardingPasses = input.Select(x => new BoardingPass(x)).ToList();

            var highestBoardingPass = boardingPasses.Aggregate((cur, next) => cur.SeatId < next.SeatId ? next : cur);

            return highestBoardingPass.SeatId;
        }

        internal static int GetYourSeat(string[] input)
        {
            int result = 0;
            
            var boardingPasses = input.Select(x => new BoardingPass(x)).ToList();
            List<int> emptySeats = new List<int>();
            for (int i = 1; i < 1028; i++)
            {
                var hasSeat = boardingPasses.Any(x => x.SeatId == i);
                if (hasSeat)
                {
                    if (emptySeats.Count == 1)
                    {
                        result = emptySeats.First();
                        break;
                    }

                    emptySeats.Clear();
                }
                else
                {
                    emptySeats.Add(i);
                }
            }

            return result;
        }
    }
}
