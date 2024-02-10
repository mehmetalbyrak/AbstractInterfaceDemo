using InterfaceAbstractDemo.Entities;

namespace AbstractInterfaceDemo.Abstract;

public interface ICustomerCheckService
{
    bool CheckIfRealPerson(Customer customer);
}