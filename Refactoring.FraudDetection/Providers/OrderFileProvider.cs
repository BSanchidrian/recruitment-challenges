// -----------------------------------------------------------------------
// <copyright file="OrderFileProvider.cs" company="Payvision">
//     Payvision Copyright © 2017
// </copyright>
// -----------------------------------------------------------------------

namespace Payvision.CodeChallenge.Refactoring.FraudDetection.Input
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using Payvision.CodeChallenge.Refactoring.FraudDetection.Model;
    using Payvision.CodeChallenge.Refactoring.FraudDetection.Providers;

    public class OrderFileProvider : IOrderFileProvider
    {
        public string FilePath { get; set; }

        public OrderFileProvider(string filePath)
        {
            this.FilePath = filePath;
        }

        public IEnumerable<Order> GetOrders()
        {
            var lines = File.ReadAllLines(this.FilePath);
            return lines.Select(this.ParseOrderLine);
        }

        Order ParseOrderLine(string line)
        {
            var items = line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            return new Order
            {
                OrderId = int.Parse(items[0]),
                DealId = int.Parse(items[1]),
                Email = items[2].ToLower(),
                Street = items[3].ToLower(),
                City = items[4].ToLower(),
                State = items[5].ToLower(),
                ZipCode = items[6],
                CreditCard = items[7]
            };
        }
    }
}
