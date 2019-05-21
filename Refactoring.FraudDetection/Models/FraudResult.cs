// -----------------------------------------------------------------------
// <copyright file="FraudResult.cs" company="Payvision">
//     Payvision Copyright © 2017
// </copyright>
// -----------------------------------------------------------------------

namespace Payvision.CodeChallenge.Refactoring.FraudDetection.Model
{
    public class FraudResult
    {
        public int OrderId { get; set; }
        public bool IsFraudulent { get; set; }
    }
}