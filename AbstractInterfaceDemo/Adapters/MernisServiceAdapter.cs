using AbstractInterfaceDemo.Abstract;
using AbstractInterfaceDemo.KPSPublic;
using InterfaceAbstractDemo.Entities;

namespace AbstractInterfaceDemo.Adapters;

public class MernisServiceAdapter:ICustomerCheckService
{
    public bool CheckIfRealPerson(Customer customer)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.
            EndpointConfiguration.KPSPublicSoap);
        return client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName.ToUpper(),
            customer.LastName.ToUpper(), customer.DateOfBirth.Year)
            .Result.Body.TCKimlikNoDogrulaResult;
    }
}