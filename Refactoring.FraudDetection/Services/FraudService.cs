// -----------------------------------------------------------------------
// <copyright file="FraudService.cs" company="Payvision">
//     Payvision Copyright © 2017
// </copyright>
// -----------------------------------------------------------------------

namespace Payvision.CodeChallenge.Refactoring.FraudDetection.Services
{
    using Payvision.CodeChallenge.Refactoring.FraudDetection.Model;
    using System.Collections.Generic;

    class FraudService : IFraudService
    {
        public IReadOnlyCollection<FraudResult> CheckFraudulentOrders(IList<Order> orders)
        {
            var fraudResults = new List<FraudResult>();

            for (int i = 0; i < orders.Count; i++)
            {
                var current = orders[i];

                for (int j = i + 1; j < orders.Count; j++)
                {
                    var isFraudulent = current.IsFraudulent(orders[j]);

                    if (isFraudulent)
                        fraudResults.Add(new FraudResult { IsFraudulent = true, OrderId = orders[j].OrderId });
                }
            }

            return fraudResults;
        }
    }
}
