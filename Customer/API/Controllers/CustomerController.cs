using System.Threading.Tasks;
using FooBar.Customer.Domain.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FooBar.Customer.API.Controllers
{
    public class CustomerController : ApiControllerBase

    {
        public CustomerController(IMediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Create new customer
        /// </summary>
        /// <param name="command">Info of customer</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateCustomerAsync([FromBody] CreateCustomerCommand command)
        {
            return Ok(await CommandAsync(command));
        }
    }
}