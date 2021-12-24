namespace TaxReport.Service.Orders.Core.Domain.CurrencyPair
{
    public interface ICurrencyPair
    {
        int CurrencyPairId { get; }
        string BaseCurrency { get; }
        string QuoteCurrency { get; }
        DateTime Date { get; }
        double Open { get; }
        decimal Close { get; }
    }
}
