namespace EntityFramework
{
    public interface ICustomerRepository
    {
        int Insert(Customer customer);
        int Update(Customer customer);
        int Delete(int customerId);
    }
}
