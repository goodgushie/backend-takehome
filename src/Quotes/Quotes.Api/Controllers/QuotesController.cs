using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Quotes.Domain;

namespace Quotes.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        [HttpPost]
        public Quote EstimateQuote()
        {
            // TODO: Accept json object
            return new Quote((decimal).943, (decimal).5, 6000, 4);
        }
    }
}
