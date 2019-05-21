// -----------------------------------------------------------------------
// <copyright file="BitCounter.cs" company="Payvision">
//     Payvision Copyright © 2017
// </copyright>
// -----------------------------------------------------------------------

namespace Payvision.CodeChallenge.Algorithms.CountingBits
{
    using System;
    using System.Collections.Generic;

    public class PositiveBitCounter
    {
        public IEnumerable<int> Count(int input)
        {
            if (input < 0)
                throw new ArgumentException("The number must be a positive value");

            if (input == 0)
                return new List<int> { 0 };

            var result = new List<int>(32) { -1 };
            for(var position = 0; input != 0; position++)
            {
                // Checks if the last bit is 1
                if ((input & 1) == 1)
                    result.Add(position);
                // Moves 1 bit to the right
                input >>= 1;
            }
            result[0] = result.Count - 1;
            return result;
        }
    }
}