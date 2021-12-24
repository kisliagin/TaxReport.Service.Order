namespace TaxReport.Service.Orders.Core.Domain.CurrencyPair
{
    public interface ICurrencyPairRepository
    {
        Task<ICurrencyPair> GetAsync(int id);
        Task<IEnumerable<ICurrencyPair>> GetAllAsync();
        Task<ICurrencyPair> CreateAsync(ICurrencyPair currencyPair);
        Task UpdateAsync(ICurrencyPair currencyPair);
        Task DeleteAsync(int id);
    }
}
