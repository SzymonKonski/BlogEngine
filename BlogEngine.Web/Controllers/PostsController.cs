using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogEngine.Application.Interfaces;
using BlogEngine.Application.Services;
using BlogEngine.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlogEngine.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _service;

        public PostsController(IPostService service)
        {
            _service = service;

        }
        // GET: api/<PostsController>
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PostsController>/5
        [HttpGet("{id}")]
        public ActionResult<PostViewModel> Get(int id)
        {
            var model = _service.GetById(id);
            return Ok(model);
        }

        // POST api/<PostsController>
        [HttpPost]
        public void Post([FromBody] PostViewModel value)
        {
            _service.Create(value);
        }

        // PUT api/<PostsController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] PostViewModel value)
        {

        }

        // DELETE api/<PostsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _service.Delete(id);
        }
    }
}
