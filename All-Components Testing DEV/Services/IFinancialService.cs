namespace All_Components_Testing_DEV.Financial
{
    public interface IFinancialService
    {
        Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue();
    }
}