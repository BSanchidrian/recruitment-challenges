// -----------------------------------------------------------------------
// <copyright file="FraudRadar.cs" company="Payvision">
//     Payvision Copyright © 2017
// </copyright>
// -----------------------------------------------------------------------

namespace Payvision.CodeChallenge.Refactoring.FraudDetection
{
    using Payvision.CodeChallenge.Refactoring.FraudDetection.Input;
    using Payvision.CodeChallenge.Refactoring.FraudDetection.Model;
    using Payvision.CodeChallenge.Refactoring.FraudDetection.Models.Normalization;
    using Payvision.CodeChallenge.Refactoring.FraudDetection.Services;
    using System.Collections.Generic;
    using System.Linq;

    public class FraudRadar
    {
        readonly IOrderProvider orderProvider;
        readonly IOrderNormalizer orderNormalizer;
        readonly IFraudService fraudService;

        public FraudRadar(IOrderProvider orderProvider, IOrderNormalizer orderNormalizer, IFraudService fraudService)
        {
            this.orderProvider = orderProvider;
            this.orderNormalizer = orderNormalizer;
            this.fraudService = fraudService;
        }

        public IEnumerable<FraudResult> Check()
        {
            // READ FRAUD LINES
            var orders = this.orderProvider.GetOrders().ToList();

            // NORMALIZE
            orders.ForEach(order => this.orderNormalizer.Normalize(order));

            // CHECK FRAUD
            return this.fraudService.CheckFraudulentOrders(orders);
        }
    }
}