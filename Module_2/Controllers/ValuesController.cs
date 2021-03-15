using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Module_2.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value3", "value4", "value5" };
        }

        // GET api/values/5
        //input:integer
        //output: the nest four integers after the input integer
        public int Get (int id)
        {
            decimal quotient = (decimal)id / 2;
            quotient = Math.Ceiling(quotient);
            return (int)(quotient);
        }

        // POST api/values 
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
