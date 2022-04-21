using Dapper;
using Illion0.Context;
using Illion0.Entities;
using Illion0.Interface;

namespace Illion0.Services
{
    public class SIllionToken : IIllionToken
    {
        private readonly dapperContext _context;
        public SIllionToken(dapperContext context)
        {
            _context = context;
        }
        public async Task<int> createCustomeToken(IllionToken illionToken)
        {

            int result = 0;
            
                var query = "INSERT INTO encryptKey (TaxPayerId,institution,customerId,encryptionKey) VALUES (@TaxPayerId,@institution,@customerId,@encryptionKey)";

                var parameters = new DynamicParameters();
                parameters.Add("TaxPayerId", illionToken.TaxPayerId);
                parameters.Add("institution", illionToken.institution);
                parameters.Add("customerId", illionToken.customerId);
            parameters.Add("encryptionKey", illionToken.encryptionKey);

                using (var connection = _context.CreateConnection())
                {
                   result=  await connection.ExecuteAsync(query, parameters);
                }
            return result;
        }

        public async Task<IllionToken> findCustomerToken(string taxPayerId, string institution)
        {
            var squery = "SELECT * FROM encryptKey WHERE TaxPayerId = @TaxPayerId and institution=@institution";
            
            using (var connection = _context.CreateConnection())
            {


                var par = new DynamicParameters();
                par.Add("TaxPayerId", taxPayerId);
                par.Add("institution", institution);
            var   result = await connection.QuerySingleOrDefaultAsync<IllionToken>(squery, par);


                if (result == null)
                {
                    return null;
                }

                return result;
            }
        }

        public async Task<int> updateCustomerIDandToken(IllionToken illionToken)
        {
            int result = 0;


            //find
            
            var findtoken = await this.findCustomerToken(illionToken.TaxPayerId,illionToken.institution);
          


            if(findtoken == null)
            {
                result = await createCustomeToken(illionToken);

                return result;
            }


                var query = "UPDATE encryptKey SET customerId = @customerId, encryptionKey = @encryptionKey WHERE TaxPayerId = @TaxPayerId and institution = @institution";
           
            var parameters = new DynamicParameters();
            parameters.Add("TaxPayerId", illionToken.TaxPayerId);
            parameters.Add("institution", illionToken.institution);
            parameters.Add("customerId", illionToken.customerId);
            parameters.Add("encryptionKey", illionToken.encryptionKey);

            using (var connection = _context.CreateConnection())
            {
                result = await connection.ExecuteAsync(query, parameters);
            }
            return result;
        }

        public async Task<int> updateCustomerTokenOnly(IllionToken illionToken)
        {
            var findtoken = await this.findCustomerToken(illionToken.TaxPayerId, illionToken.institution);

            if(findtoken == null)
            {
                return 0;
            }

            int result = 0;

            var query = "UPDATE encryptKey SET  encryptionKey = @encryptionKey WHERE TaxPayerId = @TaxPayerId and institution = @institution and customerId = @customerId";

            var parameters = new DynamicParameters();
            parameters.Add("TaxPayerId", illionToken.TaxPayerId);
            parameters.Add("institution", illionToken.institution);
            parameters.Add("customerId", illionToken.customerId);
            parameters.Add("encryptionKey", illionToken.encryptionKey);

            using (var connection = _context.CreateConnection())
            {
                result = await connection.ExecuteAsync(query, parameters);
            }
            return result;

        }


        
    }
}
