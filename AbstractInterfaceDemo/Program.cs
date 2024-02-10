using AbstractInterfaceDemo.Abstract;
using AbstractInterfaceDemo.Adapters;
using AbstractInterfaceDemo.Concrete;
using InterfaceAbstractDemo.Entities;


BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
customerManager.Save(new Customer
{
    DateOfBirth = new DateTime(1995, 4, 22),
    FirstName = "Léa",
    LastName = "Seydoux",
    NationalityId = Convert.ToInt64("12345678910")
});