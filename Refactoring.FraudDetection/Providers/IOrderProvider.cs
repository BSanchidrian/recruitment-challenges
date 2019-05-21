// -----------------------------------------------------------------------
// <copyright file="IOrderProvider.cs" company="Payvision">
//     Payvision Copyright © 2017
// </copyright>
// -----------------------------------------------------------------------

namespace Payvision.CodeChallenge.Refactoring.FraudDetection.Input
{
    using Payvision.CodeChallenge.Refactoring.FraudDetection.Model;
    using System.Collections.Generic;

    public interface IOrderProvider
    {
        IEnumerable<Order> GetOrders();
    }
}
