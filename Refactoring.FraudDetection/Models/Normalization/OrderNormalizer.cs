// -----------------------------------------------------------------------
// <copyright file="OrderNormalizer.cs" company="Payvision">
//     Payvision Copyright © 2017
// </copyright>
// -----------------------------------------------------------------------

namespace Payvision.CodeChallenge.Refactoring.FraudDetection.Models.Normalization
{
    using System;
    using System.Collections.Generic;
    using Payvision.CodeChallenge.Refactoring.FraudDetection.Model;

    class OrderNormalizer : IOrderNormalizer
    {
        readonly IEnumerable<Action<Order>> normalizationRules;

        public OrderNormalizer(IEnumerable<Action<Order>> normalizationRules)
        {
            this.normalizationRules = normalizationRules;
        }

        public void Normalize(Order order)
        {
            foreach (var normalizationRule in normalizationRules)
                normalizationRule(order);
        }
    }
}
