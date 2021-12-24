namespace TaxReport.Service.Orders.Core.Domain.Order
{
    public interface IOrderRepository
    {
        Task<IOrder> GetAsync(int id);
        Task<IEnumerable<IOrder>> GetAllAsync();
        Task<IOrder> CreateAsync(IOrder order);
        Task UpdateAsync(IOrder order);
        Task DeleteAsync(int id);
    }
}
