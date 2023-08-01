using Microsoft.AspNetCore.Mvc;

namespace MFAnalytics.Application.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WishlistController : ControllerBase
{
    // GET: api/<WishlistController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<WishlistController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/<WishlistController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<WishlistController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<WishlistController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
