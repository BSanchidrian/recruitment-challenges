// -----------------------------------------------------------------------
// <copyright file="FraudRadarBuilder.cs" company="Payvision">
//     Payvision Copyright © 2017
// </copyright>
// -----------------------------------------------------------------------

namespace Payvision.CodeChallenge.Refactoring.FraudDetection
{
    using Payvision.CodeChallenge.Refactoring.FraudDetection.Input;
    using Payvision.CodeChallenge.Refactoring.FraudDetection.Model;
    using Payvision.CodeChallenge.Refactoring.FraudDetection.Models.Normalization;
    using Payvision.CodeChallenge.Refactoring.FraudDetection.Services;
    using System;
    using System.Collections.Generic;

    public static class FraudRadarBuilder
    {
        static IEnumerable<Action<Order>> GetNormalizationRules()
        {
            return new List<Action<Order>>
            {
                NormalizationRules.NormalizeState,
                NormalizationRules.NormalizeStreet,
                NormalizationRules.NormalizeEmail,
            };
        }

        public static FraudRadar Build(IOrderProvider orderFileProvider) =>
            // It would be a good idea to use a dependency container to prevent manual instanciation
            new FraudRadar(
                orderFileProvider,
                new OrderNormalizer(GetNormalizationRules()),
                new FraudService()
                );
    }
}
