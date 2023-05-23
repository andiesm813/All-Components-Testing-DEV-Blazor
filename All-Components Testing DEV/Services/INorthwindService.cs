namespace All_Components_Testing_DEV.Northwind
{
    public interface INorthwindService
    {
        Task<List<EmployeesType>> GetEmployees();
    }
}