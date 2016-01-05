using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using ttg_api.Models;


namespace ttg_api.Controllers
{  
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        [FromServices]
        public ITodoRepository TodoItems { get; set; }
    
        // GET: api/todo
        [HttpGet]
        public IEnumerable<TodoItem> GetAll()
        {
            return TodoItems.GetAll();
        }

        // GET api/todo/5
        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult Get(string id)
        {
            var item = TodoItems.Find(id);
            
            if (item == null)
                return HttpNotFound();
            else
                return new ObjectResult(item);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] TodoItem todo)
        {
            if (ModelState.IsValid)
            {
                // Do something with the product (not shown).
                return CreatedAtRoute("GetTodo", new { controller = "Todo", id = todo.Key }, todo);
            }
            else
            {
                return HttpBadRequest(ModelState); 
            }
        }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody]string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}
