using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace dec_05
{
    public class BoardingPass
    {
        private string originalInput;

        public int SeatNumber { get; private set; }
        public int RowNumber { get; private set; }
        public int SeatId { get; private set; }

        public BoardingPass(string input)
        {
            this.originalInput = input;
            var fixedInput = this.originalInput.ToCharArray();
            Array.Reverse(fixedInput);

            var seatbinary = fixedInput.Take(3).Select(x => x == 'R' ? 1 : 0).ToArray();
            var rowbinary = fixedInput.Skip(3).Select(x => x == 'B' ? 1 : 0).ToArray();

            this.SeatNumber = GetValueFromBinary(seatbinary);
            this.RowNumber = GetValueFromBinary(rowbinary);
            this.SeatId = this.RowNumber * 8 + this.SeatNumber;
        }

        private static int GetValueFromBinary(int[] binary)
        {
            int result = 0;
            int currentPowOf2 = 1;

            for (int i = 0; i < binary.Length; i++)
            {
                result += binary[i] * currentPowOf2;
                currentPowOf2 *= 2;
            }

            return result;

        }
    }
}
