using InterfaceAbstractDemo.Entities;

namespace AbstractInterfaceDemo.Abstract;

public class BaseCustomerManager:ICustomerService
{
    public virtual void Save(Customer customer)
    {
        Console.WriteLine("Saved to db : " + customer.FirstName);
    }
}