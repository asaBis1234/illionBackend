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

namespace Illion0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IllionController : ControllerBase
    {

        private readonly IIllion _illion;
        public IllionController(IIllion illion)
        {
            _illion= illion;
        }

        


        [HttpPost]
        public async Task<IActionResult> Create([FromBody]CustomerCredential value)
        {
            try
            {

               
                var result=await _illion.createCustomer(value);

                if (result == null)
                {
                    return StatusCode(500, "server error");
                }

                if (result.GetType().GetProperty("customerId")==null)
                {
                    return NotFound(result);
                }
               
                return Ok(result);

                
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("accountlist")]

        public async Task<IActionResult> Getcustomer(string taxpayerid,string institution)
        {
            try
            {
                var res=await _illion.ListCustomerAccount(taxpayerid, institution);

                if(res.Item1.accounts == null)
                {
                    return NotFound("invalid input");
                }

                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                
            }
        }



        [HttpGet("transactiondata")]

        public async Task<IActionResult> Getcustomerdata(string taxpayerid, string institution)
        {
            try
            {
                var res = await _illion.getCustomerAccountData(taxpayerid, institution);

                if (res == null)
                {
                    return NotFound("invalid input");
                }

                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
    }
}
