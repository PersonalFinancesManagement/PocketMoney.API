using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PocketMoney.Application.Models.Accounts.Queries;
using PocketMoney.Application.Models.Users.Commands;
using PocketMoney.Application.Models.Users.Queries;

namespace PocketMoney.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ValuesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _mediator.Send(new GetUserByIdQuery(id)));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] CreateUserCommand user)
        {
            
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
