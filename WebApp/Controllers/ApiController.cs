using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data;

namespace WebApp.Controllers
{ 

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        public class RET { public string MESSAGE { get; set; } }

        private readonly DbCtx _context;

        public ValuesController(DbCtx context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IList<Models.User>> Get()//get all users...
        {   
            return Ok(_context.Users);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Models.User> Get(int id)
        {
            
            return Ok(_context.Users.Find(id));
        }
        
        // POST api/values
        [HttpPost]
        public ActionResult<RET> Post([FromBody] Models.User value)
        {
            RET ret = new RET();

            try
            {
                if (value.Id==0)
                    _context.Users.Add(new Models.User { Age = value.Age, Address = value.Address, Name = value.Name });
                else
                {
                    Models.User user = _context.Users.Find(value.Id);
                    user.Address = value.Address; user.Age = value.Age; user.Name = value.Name;
                    _context.Users.Update(user);
                }
                _context.SaveChanges();
                ret.MESSAGE = "OK";
            }
            catch (System.Exception)
            {
                ret.MESSAGE = "ERROR...";
            }
            
            return Ok(ret);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<RET> Delete(int id)
        {
            RET ret = new RET();
            try
            {
                Models.User usr = _context.Users.Find(id);
                _context.Users.Remove(usr);
                _context.SaveChanges();
                ret.MESSAGE = "OK";
            }
            catch (System.Exception)
            {
                ret.MESSAGE = "ERROR...";
            }
            return Ok(ret);
        }
    }
}
