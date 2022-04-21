using Illion0.Entities;

namespace Illion0.Interface
{
    public interface IIllionToken
    {
        Task<int> createCustomeToken(IllionToken illionToken);
        Task<int> updateCustomerIDandToken(IllionToken illionToken);

        Task<int> updateCustomerTokenOnly(IllionToken illionToken);

        Task<IllionToken> findCustomerToken(string taxPayerId,string institution);
    }
}
