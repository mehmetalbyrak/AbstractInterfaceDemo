using AbstractInterfaceDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace AbstractInterfaceDemo.Concrete;

public class CustomerCheckManager:ICustomerCheckService
{
    public bool CheckIfRealPerson(Customer customer)
    {
        return true;
    }
}



