namespace Arsys.API.Controllers.Storage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StorageManagementController : ControllerBase
    {
        // GET: api/<ProductsManagermentController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProductsManagermentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsManagermentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductsManagermentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsManagermentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
