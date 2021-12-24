using TaxReport.Service.Orders.Core.Enums;

namespace TaxReport.Service.Orders.Core.Domain.Order
{
    public interface IOrder
    {
        int OrderId { get; }
        string Symbol { get; }
        DateTime Date { get; }
        OrderStatus Status { get; }
        OrderType Type { get; }
        double Quantity { get; }
        string Currency { get; }
    }
}
