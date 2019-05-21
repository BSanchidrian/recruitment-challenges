// -----------------------------------------------------------------------
// <copyright file="IOrderNormalizer.cs" company="Payvision">
//     Payvision Copyright © 2017
// </copyright>
// -----------------------------------------------------------------------

namespace Payvision.CodeChallenge.Refactoring.FraudDetection.Models.Normalization
{
    using Payvision.CodeChallenge.Refactoring.FraudDetection.Model;

    public interface IOrderNormalizer
    {
        void Normalize(Order order);
    }
}
