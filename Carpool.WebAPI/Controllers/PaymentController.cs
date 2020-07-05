using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Carpool.WebAPI.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace Carpool.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        public IActionResult Post([FromBody]PaymentModel payment)
        {
            // You can optionally create a customer first, and attached this to the CustomerId
            var charge = new ChargeCreateOptions
            {
                Amount = Convert.ToInt32(payment.Amount * 100), // In cents, not dollars, times by 100 to convert
                Currency = "usd", // or the currency you are dealing with
                Description = "something awesome",
                Source = payment.Token
                
            };

            var service = new ChargeService();

            try
            {
                var api_options = new RequestOptions
                {
                    ApiKey = "sk_test_P4flPzJBB89yG0N0Ghsm5Pzq00JmS8gy3L"
                };
                var response = service.Create(charge, api_options);

                return Ok(response.Paid);
                // Record or do something with the charge information
            }
            catch (StripeException ex)
            {
                StripeError stripeError = ex.StripeError;

                // Handle error
            }

            // Ideally you would put in additional information, but you can just return true or false for the moment.
            return Ok(true);
        }
    }
}