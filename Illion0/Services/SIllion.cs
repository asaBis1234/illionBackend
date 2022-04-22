using Dapper;
using Illion0.Context;
using Illion0.Entities;
using Illion0.Interface;


using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Dynamic;
using System.Net;
using System.Net.Http.Headers;


namespace Illion0.Services
{
    public class SIllion :IIllion
    {

        private readonly dapperContext _context;
        private readonly IIllionToken _illionToken;

        string url = "https://apitest.bankfeeds.com.au/v1/";

        HttpClient client;
        public SIllion(dapperContext context, IIllionToken illionToken)
        {
            _context= context;
            _illionToken= illionToken;
             client= new HttpClient();
            client.BaseAddress = new Uri(url);

            // Setting content type.                   
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-API-KEY", "19e857ab-fcbe-4d6a-903a-e151c37abda1");

        }

        public async Task<dynamic> createCustomer(CustomerCredential customer)
        {
            try
            {

               
                encryptKey responseObj;

                string result = null;

              
                    // Initialization.  
                    HttpResponseMessage response = new HttpResponseMessage();

                    // HTTP POST  
                    response = await client.PostAsJsonAsync("customer/create", customer).ConfigureAwait(false);

                    // Verification  
                    if (response.IsSuccessStatusCode)
                    {
                        // Reading Response.  
                        result = response.Content.ReadAsStringAsync().Result;
                        responseObj = JsonConvert.DeserializeObject<encryptKey>(result);



                        if (responseObj.customerId == null)
                        {
                            return result;
                        }


                    //find DB
                    


                        var squery = "SELECT * FROM IllionCredential WHERE TaxPayerId = @TaxPayerId and institution=@institution";

                        using (var connection = _context.CreateConnection())
                        {

                        
                        var par = new DynamicParameters();
                        par.Add("TaxPayerId", "gs6287337");
                        par.Add("institution", customer.credentials.institution);
                       var  findcredential = await connection.QuerySingleOrDefaultAsync<IllionCredential>(squery, par);


                        var parameters = new DynamicParameters();
                        parameters.Add("TaxPayerId", "gs6287337");
                        parameters.Add("userName", customer.credentials.username);
                        parameters.Add("password", customer.credentials.password);
                        parameters.Add("institution", customer.credentials.institution);

                        if (findcredential == null)
                        {
                            var iquery = "INSERT INTO IllionCredential (TaxPayerId,userName,password,institution) VALUES (@TaxPayerId,@userName,@password,@institution)";
                            
                           
                              var insertresult=  await connection.ExecuteAsync(iquery, parameters);

                            if (insertresult == 0)
                            {
                                return null;
                            }

                            IllionToken illionToken = new IllionToken(){
                                customerId = responseObj.customerId,
                                encryptionKey = responseObj.encryptionKey,
                                institution = customer.credentials.institution,
                                TaxPayerId = "gs6287337" };

                         var insertresulttoken= await  _illionToken.createCustomeToken(illionToken);

                            if(insertresulttoken == 0)
                            {
                                return "save credential but token";
                            }
                        }
                        else
                        {
                            var uquery = "UPDATE IllionCredential SET userName=@userName,password=@password WHERE TaxPayerId=@TaxPayerId and institution=@institution";
                          

                         var updateresult=   await connection.ExecuteAsync(uquery, parameters);

                            if (updateresult == 0)
                            {
                                return null;
                            }

                            IllionToken illionToken = new IllionToken()
                            {
                                customerId = responseObj.customerId,
                                encryptionKey = responseObj.encryptionKey,
                                institution = customer.credentials.institution,
                                TaxPayerId = "gs6287337"
                            };


                            var updateresulttoken = await _illionToken.updateCustomerIDandToken(illionToken);


                            if(updateresulttoken == 0)
                            {
                                return "update credential but token";
                            }

                        }

                    }

                    




                    return responseObj;
                        
                    }

                

                     return "invalid credential";


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return ex.Message;
            }
        }

        public async Task<IllionCredential> GetCustomerAccountcredential(string TaxPayerId, string institution)
        {
            
                var squery = "SELECT * FROM IllionCredential WHERE TaxPayerId = @TaxPayerId and institution=@institution";

                using (var connection = _context.CreateConnection())
                {


                    var par = new DynamicParameters();
                    par.Add("TaxPayerId",TaxPayerId);
                    par.Add("institution", institution);
                    var findcredential = await connection.QuerySingleOrDefaultAsync<IllionCredential>(squery, par);


                    return findcredential;
                }

        }

        public async Task<dynamic> getCustomerAccountData(string TaxPayerId, string institution)
        {

            var findtoken = await _illionToken.findCustomerToken(TaxPayerId, institution);

            if (findtoken == null)
            {
                return null;
            }


            bankStateAccountData responseObj;

            string result = null;

            ReqAccount reqAccount = new ReqAccount()
            {
                customerId = findtoken.customerId,
                encryptionKey = findtoken.encryptionKey
            };


            // Initialization.  
            HttpResponseMessage response = new HttpResponseMessage();

            // HTTP POST  
            response = await client.PostAsJsonAsync("customer/data", reqAccount).ConfigureAwait(false);



            // Verification  
            if (response.IsSuccessStatusCode)
            {


                // Reading Response.  
                result = response.Content.ReadAsStringAsync().Result;

                responseObj = JsonConvert.DeserializeObject<bankStateAccountData>(result);

                //when deserialize object, assign null value also to it attribute 


                if (responseObj.accounts == null)
                {

                    var deresult = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);

                    if (deresult["error_code"] == "40101")
                    {
                        var updatecredential = await this.updatecustomertoken(TaxPayerId, institution);

                        if (updatecredential == 1)
                        {
                            var gettoken = await _illionToken.findCustomerToken(TaxPayerId, institution);



                            ReqAccount reqAccount1 = new ReqAccount()
                            {
                                customerId = gettoken.customerId,
                                encryptionKey = gettoken.encryptionKey
                            };


                            response = await client.PostAsJsonAsync("customer/data", reqAccount1).ConfigureAwait(false);

                            if (response.IsSuccessStatusCode)
                            {
                                result = response.Content.ReadAsStringAsync().Result;

                                responseObj = JsonConvert.DeserializeObject<bankStateAccountData>(result);

                                if (responseObj.accounts == null)
                                {

                                    var deresult1 = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);

                                    if (deresult1["error_code"] == "40101")
                                    {
                                        return "somthing is happend";
                                    }

                                }


                            }
                        }
                    }
                    else
                    {
                        return result;
                    }

                }


                IllionToken lasttoken = new IllionToken()
                {
                    institution = institution,
                    TaxPayerId = TaxPayerId,
                    customerId = responseObj.customer.customerId,
                    encryptionKey = responseObj.customer.encryptionKey
                };

                var tokenupdate = await _illionToken.updateCustomerTokenOnly(lasttoken);

                if (tokenupdate == 0)
                {
                    return "not last token update";
                }


                return responseObj;


            }

            return "api not work";

        }

        public async Task<(Accounts,string)> ListCustomerAccount(string TaxPayerId,string institution)
        {
            try
            {
                var findtoken= await _illionToken.findCustomerToken(TaxPayerId, institution);

                if(findtoken == null)
                {
                    return (null,null);
                }


                Accounts responseObj;

                string result = null;

                ReqAccount reqAccount = new ReqAccount()
                {
                    customerId = findtoken.customerId,
                    encryptionKey = findtoken.encryptionKey
                };
               

                // Initialization.  
                HttpResponseMessage response = new HttpResponseMessage();

                // HTTP POST  
                response = await client.PostAsJsonAsync("customer/accounts", reqAccount).ConfigureAwait(false);



                // Verification  
                if (response.IsSuccessStatusCode)
                {

                    
                    // Reading Response.  
                    result = response.Content.ReadAsStringAsync().Result;

                    responseObj = JsonConvert.DeserializeObject<Accounts>(result);

                    //when deserialize object, assign null value also to it attribute 


                    if (responseObj.accounts == null)
                    {
                       
                        var deresult=JsonConvert.DeserializeObject<Dictionary<string, string>>(result);

                       if(deresult["error_code"] == "40101")
                        {
                            var updatecredential = await this.updatecustomertoken(TaxPayerId, institution);

                            if(updatecredential == 1)
                            {
                                var gettoken=await _illionToken.findCustomerToken(TaxPayerId, institution);

                                

                               ReqAccount reqAccount1 = new ReqAccount()
                                {
                                    customerId = gettoken.customerId,
                                    encryptionKey = gettoken.encryptionKey
                                };


                                response = await client.PostAsJsonAsync("customer/accounts", reqAccount1).ConfigureAwait(false);

                                if (response.IsSuccessStatusCode)
                                {
                                    result = response.Content.ReadAsStringAsync().Result;

                                    responseObj = JsonConvert.DeserializeObject<Accounts>(result);

                                    if(responseObj.accounts == null)
                                    {

                                        var deresult1 = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);

                                        if (deresult1["error_code"] == "40101")
                                        {
                                            
                                            return (null,"somthing is happend");
                                        }

                                    }

                                    
                                    }
                            }
                        }
                        else
                        {
                            return (null,result);
                        }

                    }


                    IllionToken lasttoken = new IllionToken()
                    {
                        institution = institution,
                        TaxPayerId = TaxPayerId,
                        customerId = responseObj.customer.customerId,
                        encryptionKey = responseObj.customer.encryptionKey
                    };

                    var tokenupdate = await _illionToken.updateCustomerTokenOnly(lasttoken);

                    if (tokenupdate == 0)
                    {
                        return (null,"not last token update");
                    }


                    return (responseObj,null);


                }

                return (null,"api not work");
                
                }
            catch (Exception ex)
            {

                Console.Write(ex);
                return (null,ex.Message);
            }
        }

        public async Task<int> updatecustomertoken(string TaxPayerId, string institution)
        {
            
                var customer = await this.GetCustomerAccountcredential(TaxPayerId, institution);

                encryptKey responseObj;

                string result = null;


            Credentials credentials = new Credentials()
            {
                institution = institution,
                username = customer.username,
                password = customer.password

            };

            CustomerCredential customer1 = new CustomerCredential()
            {
                credentials = credentials
            };
                
                // Initialization.  
                HttpResponseMessage response = new HttpResponseMessage();

                // HTTP POST  
                response = await client.PostAsJsonAsync("customer/create", customer1).ConfigureAwait(false);

                // Verification  
                if (response.IsSuccessStatusCode)
                {
                    // Reading Response.  
                    result = response.Content.ReadAsStringAsync().Result;
                    responseObj = JsonConvert.DeserializeObject<encryptKey>(result);


                    


                    if (responseObj.customerId == null)
                    {
                        return 0;
                    }

                IllionToken illionToken = new IllionToken()
                {
                    customerId = responseObj.customerId,
                    encryptionKey = responseObj.encryptionKey,
                    institution = institution,
                    TaxPayerId = TaxPayerId
                };


                var updateresulttoken = await _illionToken.updateCustomerIDandToken(illionToken);


                if (updateresulttoken == 1)
                {
                    return 1;
                }


                
            }

            return 0;

        }


       

    }
}
