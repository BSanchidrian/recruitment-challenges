// -----------------------------------------------------------------------
// <copyright file="NormalizationRules.cs" company="Payvision">
//     Payvision Copyright © 2017
// </copyright>
// -----------------------------------------------------------------------

namespace Payvision.CodeChallenge.Refactoring.FraudDetection.Models.Normalization
{
    using System;
    using Payvision.CodeChallenge.Refactoring.FraudDetection.Model;

    static class NormalizationRules
    {
        public static void NormalizeState(Order order)
        {
            order.State = order.State.Replace("il", "illinois").Replace("ca", "california").Replace("ny", "new york");
            order.Street = order.Street.Replace("st.", "street").Replace("rd.", "road");
        }

        public static void NormalizeStreet(Order order)
        {
            order.Street = order.Street.Replace("st.", "street").Replace("rd.", "road");
        }

        public static void NormalizeEmail(Order order)
        {
            var aux = order.Email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);
            var atIndex = aux[0].IndexOf("+", StringComparison.Ordinal);
            aux[0] = atIndex < 0 ? aux[0].Replace(".", "") : aux[0].Replace(".", "").Remove(atIndex);
            order.Email = string.Join("@", new string[] { aux[0], aux[1] });
        }
    }
}
