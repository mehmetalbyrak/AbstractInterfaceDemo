using AbstractInterfaceDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace AbstractInterfaceDemo.Concrete;

public class NeroCustomerManager:BaseCustomerManager
{
    private ICustomerCheckService _customerCheckService;
    
    public NeroCustomerManager(ICustomerCheckService customerCheckService)
    {
        _customerCheckService = customerCheckService;
    }

    public override void Save(Customer customer)
    {
        if (_customerCheckService.CheckIfRealPerson(customer))
        {
            base.Save(customer);
        }
        else
        {
            throw new Exception("Not a valid person");
        }
    }
}