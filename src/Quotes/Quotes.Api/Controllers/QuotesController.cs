using Microsoft.AspNetCore.Mvc;
using Quotes.Domain;

namespace Quotes.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        /// <summary>
        /// Estimates a quote
        /// </summary>
        /// <remarks>
        /// Example:
        /// POST /Quotes
        /// {
        ///     "revenue": decimal,
        ///     "state": string,
        ///     "business": string
        /// }
        /// </remarks>
        /// <param name="quoteRequest">Parameters to calculate quote with</param>
        /// <returns>Quote for the given parameters</returns>
        [HttpPost]
        public Quote EstimateQuote([FromBody] QuoteRequest quoteRequest)
        {
            return quoteRequest.CreateQuote();
        }
    }
}
