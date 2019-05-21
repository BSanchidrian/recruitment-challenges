// -----------------------------------------------------------------------
// <copyright file="IFraudService.cs" company="Payvision">
//     Payvision Copyright © 2017
// </copyright>
// -----------------------------------------------------------------------

namespace Payvision.CodeChallenge.Refactoring.FraudDetection.Services
{
    using System.Collections.Generic;
    using Payvision.CodeChallenge.Refactoring.FraudDetection.Model;

    public interface IFraudService
    {
        IReadOnlyCollection<FraudResult> CheckFraudulentOrders(IList<Order> orders);
    }
}