namespace All_Components_Testing_DEV.Northwind
{
    public class MockNorthwindService : INorthwindService
    {
        public Task<List<EmployeesType>> GetEmployees()
        {
            return Task.FromResult<List<EmployeesType>>(new());
        }
    }
}