// -----------------------------------------------------------------------
// <copyright file="Order.cs" company="Payvision">
//     Payvision Copyright © 2017
// </copyright>
// -----------------------------------------------------------------------
namespace Payvision.CodeChallenge.Refactoring.FraudDetection.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public int DealId { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string CreditCard { get; set; }

        public bool IsFraudulent(Order order) => this.DealId == order.DealId
                                                && this.State == order.State
                                                && this.ZipCode == order.ZipCode
                                                && this.Street == order.Street
                                                && this.City == order.City
                                                && this.CreditCard != order.CreditCard;
    }
}
