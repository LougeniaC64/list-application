using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace ListApplication.Controllers
{
    [Route("api/[controller]")]
    public class ListController : Controller
    {
        ICollection<ListItem> listItems = new List<ListItem> {
            new ListItem { Id = 1, Name = "My Item", IsActive = true }
        };
        
        // GET: api/list
        [HttpGet(Name ="getAll")]
        public IEnumerable<ListItem> Get()
        {
            return this.listItems;
        }

        // GET api/list/5
        [HttpGet("{id}", Name = "getById")]
        public ListItem Get(int id)
        {
            return this.listItems.FirstOrDefault(listItem => listItem.Id == id);
        }

        // POST api/list
        [HttpPost(Name = "create")]
        public IEnumerable<ListItem> Post([FromBody]string value)
        {
            var id = (this.listItems.Max(listItem => (int?)listItem.Id) ?? 0) + 1;
            this.listItems.Add(new ListItem() { Id = id, Name = value, IsActive = true });

            return this.listItems;
        }

        //// PUT api/list/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/list/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
