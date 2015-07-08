using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ListApplication.Controllers
{
    [Route("api/[controller]")]
    public class ListController : Controller
    {
        IEnumerable<ListItem> listItems = new List<ListItem> {
            new ListItem { Id = 1, Name = "My Item", IsActive = true }
        };
        
        // GET: api/values
        [HttpGet(Name ="getAll")]
        public IEnumerable<ListItem> Get()
        {
            return listItems;
        }

        // GET api/values/5
        [HttpGet("{id}", Name = "getById")]
        public ListItem Get(int id)
        {
            return listItems.FirstOrDefault(listItem => listItem.Id == id);
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
