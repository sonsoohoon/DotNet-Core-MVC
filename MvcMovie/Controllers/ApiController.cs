using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class Person
    {
        public long id { get; set; }
        public string name { get; set; }
    }

    [Route("[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        // GET: api/<ApiController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET <ApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value is " + id;
        }

        // GET <ApiController>/5/brique
        [HttpGet("{id}/{name}")]
        public string GetPath(int id, string name)
        {
            return "value is " + id + " " + name;
        }

        // GET <ApiController>/5?name=brique
        [HttpGet("{Action}")]
        public string GetQuery(string name)
        {
            return "value is " + name;
        }

        // POST <ApiController>
        // {"id":1,"name": "shson"}
        [HttpPost]
        public string Post(Person person)
        {
            return "name " + person.id + " " + person.name;
        }

        // PUT <ApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE <ApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
