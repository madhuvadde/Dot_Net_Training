using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MVC_API.Models;

namespace MVC_API.Controllers
{
    public class StoreController : ApiController
    {
        // GET api/<controller>
        DataBaseAccessLayer.DataBase DBLayer = new DataBaseAccessLayer.DataBase();
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [HttpPost]
        public Boolean PostComponent([FromBody]String component)
        {
            Boolean result = DBLayer.AddComponent(component);
            return result;

        }

        [HttpPost]
        public Boolean InsertCategory(Category category )
        {
            Boolean result = DBLayer.AddCategoryToComponent(category.Component, category.CategoryName, category.Link);
            return result;

        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}