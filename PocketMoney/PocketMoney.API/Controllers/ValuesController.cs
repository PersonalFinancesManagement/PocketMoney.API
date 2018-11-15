using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using PocketMoney.API.Model;
using PocketMoney.Data.DataAccess;

namespace PocketMoney.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private UserData _userData;
        private readonly AppSettings _appSettings;
        public ValuesController(IOptions<AppSettings> appsettings)
        {
            _appSettings = appsettings.Value;
            _userData = new UserData(_appSettings.ConnectionString);
        }
        
        
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(_userData.GetUserInfo(1));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
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
