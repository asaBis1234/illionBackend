using Illion0.Entities;

namespace Illion0.Interface
{
    public interface IIllion
    {


        public Task<dynamic> createCustomer(CustomerCredential customer);

        public Task<dynamic> ListCustomerAccount(string TaxPayerId, string institution);

        public Task<IllionCredential> GetCustomerAccountcredential(string TaxPayerId, string institution);

        public Task<int> updatecustomertoken(string TaxPayerId, string institution);


        public Task<int> getCustomerAccountData(string TaxPayerId, string institution);

    }
}
