// -----------------------------------------------------------------------
// <copyright file="IOrderFileProvider.cs" company="Payvision">
//     Payvision Copyright © 2017
// </copyright>
// -----------------------------------------------------------------------

namespace Payvision.CodeChallenge.Refactoring.FraudDetection.Providers
{
    using Payvision.CodeChallenge.Refactoring.FraudDetection.Input;

    interface IOrderFileProvider : IOrderProvider 
    {
        string FilePath { get; set; }
    }
}
